namespace WinForms.Forms
{
    partial class ProgressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxStyle = new System.Windows.Forms.ListBox();
            this.buttonRollback = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(88, 32);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(371, 45);
            this.progressBar1.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(88, 95);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(384, 95);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "BarStyle";
            // 
            // listBoxStyle
            // 
            this.listBoxStyle.FormattingEnabled = true;
            this.listBoxStyle.ItemHeight = 15;
            this.listBoxStyle.Location = new System.Drawing.Point(131, 223);
            this.listBoxStyle.Name = "listBoxStyle";
            this.listBoxStyle.Size = new System.Drawing.Size(120, 94);
            this.listBoxStyle.TabIndex = 4;
            this.listBoxStyle.SelectedIndexChanged += new System.EventHandler(this.listBoxStyle_SelectedIndexChanged);
            // 
            // buttonRollback
            // 
            this.buttonRollback.Location = new System.Drawing.Point(286, 95);
            this.buttonRollback.Name = "buttonRollback";
            this.buttonRollback.Size = new System.Drawing.Size(75, 23);
            this.buttonRollback.TabIndex = 2;
            this.buttonRollback.Text = "Rollback";
            this.buttonRollback.UseVisualStyleBackColor = true;
            this.buttonRollback.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.Location = new System.Drawing.Point(187, 95);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(75, 23);
            this.buttonContinue.TabIndex = 2;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(502, 239);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(37, 22);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(534, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Bar time";
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(372, 181);
            this.comboBoxTime.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(132, 23);
            this.comboBoxTime.TabIndex = 10;
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxStyle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.buttonRollback);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.progressBar1);
            this.Name = "ProgressForm";
            this.Text = "ProgressForm";
            this.Load += new System.EventHandler(this.ProgressForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProgressBar progressBar1;
        private Button buttonStart;
        private Button buttonStop;
        private Label label1;
        private ListBox listBoxStyle;
        private Button buttonRollback;
        private Button buttonContinue;
        private Button buttonAdd;
        private Label label2;
        private ComboBox comboBoxTime;
    }
}