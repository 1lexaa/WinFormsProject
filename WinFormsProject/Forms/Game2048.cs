using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Forms
{
    public partial class Game2048 : Form
    {
        private readonly Random _random;
        public Game2048(Random random)
        {
            _random = random;
            InitializeComponent();
        }

        private void Game2048_Load(object sender, EventArgs e)
        {
            panelGameField.BackColor = Color.FromArgb(0xBB, 0xAD, 0xA0);
           
            ClearGameField();
            AddCell();
            ColorCells();
            this.ActiveControl = null;
        }

        
        // Clear all field cells
       private void ClearGameField()
        {
            foreach (var control in panelGameField.Controls)
            {
                if (control is Label lbl) lbl.Text = "0";
            }
        }
        
        // Produce new cell
        private void AddCell()
        {
          
            // Looking for empty cells
            Label? lbl;
            List<Label> emptyCells = new List<Label>();
            for(int i = 0; i < 4; i++)
                for(int j = 0; j < 4; j++)
                {
                    String name = "cell" + i + j;
                    lbl = panelGameField.Controls.Find(name, false)[0] as Label;
                    if(lbl?.Text == "0")
                    {
                        emptyCells.Add(lbl);
                    }
                }
            if(emptyCells.Count == 0)
            {
                // game over
                return;
            }

            // random CELL from empty
            lbl = emptyCells[_random.Next(emptyCells.Count)];
            // 90% - 2 , 10% - 4
            lbl.Text = _random.Next(10) == 0 
                ? "4" 
                : "2";

        }


        // Change Cells Colors
        private void ColorCells()
        {
            foreach(var control in panelGameField.Controls)
            {
                var lbl = control as Label; 
                if(lbl != null)
                {
                    switch (lbl.Text)
                    {
                        case "0":
                            lbl.BackColor = Color.FromArgb(0xCD, 0xC1, 0xB5);
                            lbl.ForeColor = Color.FromArgb(0xCD, 0xC1, 0xB5);
                            break;
                        case "2":
                            lbl.BackColor = Color.FromArgb(0xEE, 0xE4, 0xDA);
                            lbl.ForeColor = Color.FromArgb(0x77, 0x6E, 0x65);
                            break;
                        case "4": 
                            lbl.BackColor = Color.FromArgb(0xED, 0xE0, 0xC8);
                            lbl.ForeColor = Color.FromArgb(0x77, 0x6E, 0x65);
                            break;
                        case "8": 
                            lbl.BackColor = Color.FromArgb(0xF2, 0xB1, 0x79);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        case "16": 
                            lbl.BackColor = Color.FromArgb(0xF5, 0x95, 0x63);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        case "32": 
                            lbl.BackColor = Color.FromArgb(0xF6, 0x7C, 0x5F);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        case "64": 
                            lbl.BackColor = Color.FromArgb(0xF6, 0x5E, 0x3B);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        case "128": 
                            lbl.BackColor = Color.FromArgb(0xED, 0xCF, 0x72);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        case "256": ;
                            lbl.BackColor = Color.FromArgb(0xED, 0xCC, 0x50);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        case "512": 
                            lbl.BackColor = Color.FromArgb(0xED, 0xC8, 0x50);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        case "1024": 
                            lbl.BackColor = Color.FromArgb(0xED, 0xC5, 0x3F);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                        case "2048": 
                            lbl.BackColor = Color.FromArgb(0xED, 0xC2, 0x2E);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                       
                        default:
                            lbl.BackColor = Color.FromArgb(0x3C, 0x3A, 0x32);
                            lbl.ForeColor = Color.FromArgb(0xF9, 0xF6, 0xF2);
                            break;
                    }
                }
            }
        }

        private void Game2048_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());

            switch (e.KeyCode)
            {
                case Keys.Left: MakeMove(MoveDirection.Left); break;
                case Keys.Right: MakeMove(MoveDirection.Right); break;
                case Keys.Up: MakeMove(MoveDirection.Up); break;
                case Keys.Down: MakeMove(MoveDirection.Down); break;


                case Keys.Escape: Close(); break;
            }
        }

        private bool MoveLeft()
        {
            bool wasMove = false;
            //Shift all non-empty cells to left
            for (int i = 0; i < 4; i++) // lines
            {
                for(int k = 0; k < 3; k++)
                for (int j = 0; j < 3; j++)
                {
                    Label lbl1 = (Label)panelGameField.Controls.Find("cell" + i + j,false)[0];
                    Label lbl2 = (Label)panelGameField.Controls.Find("cell" + i + (j+1), false)[0];
                    if(lbl1.Text == "0" && lbl2.Text != "0")
                    {
                        lbl1.Text = lbl2.Text;
                        lbl2.Text = "0";
                            wasMove = true;
                    }
                }

                // Collapse
                for (int j = 0; j < 3; j++)
                {
                    Label lbl1 = (Label)panelGameField.Controls.Find("cell" + i + j, false)[0];
                    Label lbl2 = (Label)panelGameField.Controls.Find("cell" + i + (j + 1), false)[0];
                    if (lbl1.Text == lbl2.Text )
                    {
                        lbl1.Text = (int.Parse(lbl1.Text) * 2).ToString();
                        lbl2.Text = "0";
                        j++;
                        wasMove = true;
                    }
                }
                //Shift after collapse
                for (int j = 1; j < 3; j++)
                {
                    Label lbl1 = (Label)panelGameField.Controls.Find("cell" + i + j, false)[0];
                    Label lbl2 = (Label)panelGameField.Controls.Find("cell" + i + (j + 1), false)[0];
                    if (lbl1.Text == "0" && lbl2.Text != "0")
                    {
                        lbl1.Text = lbl2.Text;
                        lbl2.Text = "0";
                        wasMove = true;
                    }
                }

            }
          
            return wasMove;
        }
        private bool MoveRight()
        {
            bool wasMove = false;
            //Shift all non-empty cells to left
            for (int i = 0; i < 4; i++) // lines
            {
                for (int k = 0; k < 3; k++)
                    for (int j = 3; j > 0; j--)
                    {
                        Label lbl1 = LabelAt(i , j);
                        Label lbl2 = LabelAt(i, j - 1);
                        if (lbl1.Text == "0" && lbl2.Text != "0")
                        {
                            lbl1.Text = lbl2.Text;
                            lbl2.Text = "0";
                            wasMove = true;
                        }
                    }

                // Collapse
                for (int j = 3; j > 0; j--)
                {
                    Label lbl1 = LabelAt(i, j);
                    Label lbl2 = LabelAt(i, j - 1);
                    if (lbl1.Text == lbl2.Text)
                    {
                        lbl1.Text = (int.Parse(lbl1.Text) * 2).ToString();
                        lbl2.Text = "0";
                        j--;
                        wasMove = true;
                    }
                }
                //Shift after collapse
                for (int j = 2; j > 0; j--)
                {
                    Label lbl1 = LabelAt(i, j);
                    Label lbl2 = LabelAt(i, j - 1);
                    if (lbl1.Text == "0" && lbl2.Text != "0")
                    {
                        lbl1.Text = lbl2.Text;
                        lbl2.Text = "0";
                        wasMove = true;
                    }
                }
            }
            return wasMove;
        }
        private bool MoveUp()
        {
            bool wasMove = false;
            //Shift all non-empty cells to left
            for (int j = 0; j < 4; j++) // columns
            {
                for (int k = 0; k < 3; k++)
                    for (int i = 0; i < 3; ++i)
                    {
                        Label lbl1 = LabelAt(i, j);
                        Label lbl2 = LabelAt(i + 1, j);
                        if (lbl1.Text == "0" && lbl2.Text != "0")
                        {
                            lbl1.Text = lbl2.Text;
                            lbl2.Text = "0";
                            wasMove = true;
                        }
                    }
                // Collapse
                for (int i = 0; i < 3; ++i)
                {
                    Label lbl1 = LabelAt(i, j);
                    Label lbl2 = LabelAt(i + 1, j);
                    if (lbl1.Text == lbl2.Text && lbl1.Text != "0")
                    {
                        lbl1.Text = (int.Parse(lbl1.Text) * 2).ToString();
                        lbl2.Text = "0";
                        i++;
                        wasMove = true;
                    }
                }
                //Shift after collapse
                for (int i = 1; i < 3; ++i)
                {
                    Label lbl1 = LabelAt(i, j);
                    Label lbl2 = LabelAt(i + 1 ,j);
                    if (lbl1.Text == "0" && lbl2.Text != "0")
                    {
                        lbl1.Text = lbl2.Text;
                        lbl2.Text = "0";
                        wasMove = true;
                    }
                }
            }
            return wasMove;
        }
        private bool MoveDown()
        {
            bool wasMove = false;
            // Shift all non-empty cells to up
            for (int j = 0; j < 4; j++) // columns
            {
                for (int k = 0; k < 3; k++)
                    for (int i = 3; i > 0; --i)
                    {
                        Label lbl1 = LabelAt(i, j);
                        Label lbl2 = LabelAt(i - 1, j);
                        if (lbl1.Text == "0" && lbl2.Text != "0")
                        {
                            lbl1.Text = lbl2.Text;
                            lbl2.Text = "0";
                            wasMove = true;
                        }
                    }
                // Collapse
                for (int i = 3; i > 0; --i)
                {
                    Label lbl1 = LabelAt(i, j);
                    Label lbl2 = LabelAt(i - 1, j);
                    if (lbl1.Text == lbl2.Text && lbl2.Text != "0")
                    {
                        lbl1.Text = (int.Parse(lbl1.Text) * 2).ToString();
                        lbl2.Text = "0";
                        i--;
                        wasMove = true;
                    }
                }
            }
            return wasMove;
        }

        private void MakeMove(MoveDirection direction)
        {
            switch(direction)
            {
                case MoveDirection.Left:
                    if (MoveLeft()) { AddCell(); ColorCells(); return; } 
                    break;

                case MoveDirection.Right:
                    if (MoveRight()) { AddCell(); ColorCells(); return; }
                    break;


                case MoveDirection.Up:
                    if (MoveUp()) { AddCell(); ColorCells(); return; }
                    break;

                case MoveDirection.Down:
                    if (MoveDown()) { AddCell(); ColorCells(); return; }
                    break;

                    
            }
        }





        private Label LabelAt(int i, int j)
        {
            return (Label)panelGameField.Controls.Find("cell" + i + j, false)[0];
        }



        #region Sensor

        private Point DownPoint, UpPoint;
        private void panelSensor_MouseUp(object sender, MouseEventArgs e)
        {
            DownPoint.X = e.X;
            DownPoint.Y = e.Y;
        }

        private void panelSensor_MouseDown(object sender, MouseEventArgs e)
        {
            UpPoint.X = e.X;
            UpPoint.Y = e.Y;
            SensorMove();
        }

        private void SensorMove()
        {
            if(Math.Abs(UpPoint.X - DownPoint.X) <
                Math.Abs(UpPoint.Y - DownPoint.Y) ) // dx < dy - vertical
            {
                if(UpPoint.Y < DownPoint.Y)
                {
                    
                }

                else
                {

                }
            }
            else // horizontal 
            {
                if(UpPoint.X < DownPoint.X) // left
                {

                }
                else // right
                {

                }


            }
        }

        #endregion


        enum MoveDirection
        {
        Left,
        Right,
        Up,
        Down

        }


    }
}


/*  События клавиатуры
 * KeyDown - нажатие клавиши
 * KeyUp - отпускание клавиши
 * 
 * KeyPress -- синтетическое событие , последство Down+Up посылается только для текстовых клавиш
 * 
 * PreviewKeyDown / UP - для клавиш , посылающих системное уведомление ( функциональные )
 * !! иногда в них попадают стрелки
 * 
 * В отличие от других событий в обработчики приходят аргументы типа KeyEventArgs 
 * содержащий информацию о клавише 
 * При зажатии клавиши посылается серия сообщений ( в зависимости от системных настроек ) Если нужно контроллировать однократное нажатие , то следует 
 * 
 */


/*
 * События мыши
 * MouseDown - нажатие кнопки одно для всех кнопок. Узнать какая кнопка - по аргументам события e.Button
 * MouseUp - отпускание кнопки
 * MouseMove - движение мыши
 * 
 */