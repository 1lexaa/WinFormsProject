using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace WinForms.Forms
{
    public partial class ProgressForm : Form
    {
        private readonly NLog.Logger _logger;
        private readonly Random _random;
        private float _progressTime;
        
        private int _progressState;
        private bool _rollback;
        private bool _stopped;

        private CancellationTokenSource cts;
        public ProgressForm(NLog.Logger logger, Random random)
        {
            _logger = logger;
            _random = random;
            cts = null!;
            InitializeComponent();

        }
        private void ProgressForm_Load(object sender, EventArgs e)
        {
            listBoxStyle.Items.Add(new BarStyle { Title = "Thin", Height = 15 });
            listBoxStyle.Items.Add(new BarStyle { Title = "Norm", Height = 23 });
            listBoxStyle.Items.Add(new BarStyle { Title = "Tall", Height = 46 });
            listBoxStyle.SelectedIndex = 1;

            comboBoxTime.Items.Add("1");
            comboBoxTime.Items.Add("2");
            comboBoxTime.Items.Add("3");
            comboBoxTime.SelectedIndex = 0; 
            _progressTime = 1;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            
        }
        private void listBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStyle.SelectedItem == null) return;
            // MessageBox.Show(listBoxStyle.SelectedItem.ToString());
            progressBar1.Height = ((BarStyle)listBoxStyle.SelectedItem).Height;


        }
        private void UpdateProgress()
        {
            progressBar1.Value = _progressState;
        }
        // Старт
        private void StartHandler(object obj)
        {
            
            if (obj is not CancellationToken) return;
            CancellationToken token = (CancellationToken)obj;
            for (int i = _progressState; i <= progressBar1.Maximum; i++)
            {
                _progressState = i;
                this.Invoke((Action)UpdateProgress);
                Thread.Sleep(((int)_progressTime) * 10);
                
                // Проверка 
                if (token.IsCancellationRequested)
                {
                    break;
                }
                //  обнуление 
                if (_progressState == progressBar1.Maximum)
                {
                    MessageBox.Show("Done");
                    buttonContinue.Visible = false;
                    buttonRollback.Visible = false;
                    buttonStart.Visible = true;
                    buttonStop.Visible = false;
                    Thread.Sleep(1000);
                    progressBar1.Value = progressBar1.Minimum;
                }
            }
        }

        // Откат 
        private void RollbackHandler(object obj)
        {
           
            if (obj is not CancellationToken) return;
            CancellationToken token = (CancellationToken)obj;
            for (int i = _progressState; i >= progressBar1.Minimum; i--)
            {
                _progressState = i;
                this.Invoke((Action)UpdateProgress);
                Thread.Sleep(((int)_progressTime) * 10);
                
                if (token.IsCancellationRequested)
                {
                    break;
                }
                // бар достиг минимума
                if (_progressState == progressBar1.Minimum)
                {
                    MessageBox.Show("Cancelled");
                    buttonContinue.Visible = false;
                    buttonRollback.Visible = false;
                    buttonStart.Visible = true;
                    buttonStop.Visible = false;
                    progressBar1.Value = progressBar1.Minimum;
                }
            }

        }

        // старт
        private void buttonStart_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            _rollback = false;
            _stopped = false;
            _progressState = progressBar1.Minimum;
            buttonContinue.Visible = false;
            buttonRollback.Visible = false;
            buttonStart.Visible = false;
            buttonStop.Visible = true;
            Task.Run(() => StartHandler(cts.Token));
        }
        // Продолжить
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            buttonContinue.Visible = false;
            buttonRollback.Visible = false;
            buttonStart.Visible = false;
            buttonStop.Visible = true;
            _stopped = false;
            Task.Run(() => StartHandler(cts.Token));
        }

        // Откат
        private void buttonRollback_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            buttonContinue.Visible = false;
            buttonRollback.Visible = false;
            buttonStart.Visible = false;
            buttonStop.Visible = false;
            _rollback = true;
            _stopped = false;
            Task.Run(() => RollbackHandler(cts.Token));
        }
        // Стоп
        private void buttonStop_Click(object sender, EventArgs e)
        {
            // проверка на двойной стоп 
            if (_stopped)
            {
                progressBar1.Value = progressBar1.Minimum;
                _stopped = false;
                buttonContinue.Visible = false;
                buttonRollback.Visible = false;
                buttonStart.Visible = true;
                buttonStop.Visible = false;
            }
            else
            {
                
                buttonContinue.Visible = true;
                buttonRollback.Visible = true;
                buttonStart.Visible = false;
                buttonStop.Visible = true;
                _stopped = true;
                cts?.Cancel();
            }

        }

        private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBoxTime.Text == String.Empty) return;
            _progressTime = Convert.ToSingle(comboBoxTime.Text);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Создаем строку для контента из комбобокса
            String content = String.Empty;
            
            if (comboBoxTime.Text.Contains("."))
                content = comboBoxTime.Text.Replace('.', ',');
            else content = comboBoxTime.Text;

            try
            {
                // конверт
                float res = Convert.ToSingle(content);
          
                if (res < 10 && res > 0)
                    comboBoxTime.Items.Add(content);
                else MessageBox.Show("Инвалид инпут! Введите дробное число от 0 до 10");
            }
            catch (Exception ex) // исключение
            {
                _logger.Warn(ex);
                MessageBox.Show("Инвалид инпут! Введите дробное число от 0 до 10");
            }
        }


    }
    class BarStyle
    {
        public String? Title { get; set; }
        public int Height { get; set; }
        public override string ToString()
        {
            return Title ?? "--";
        }
    }
}
