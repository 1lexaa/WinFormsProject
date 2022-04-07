namespace WinForms.Forms
{
    partial class Calculator
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
            this.richTextBox = new System.Windows.Forms.TextBox();
            this.History = new System.Windows.Forms.Label();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonClearDisp = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonClearLast = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonMul = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.Black;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox.Location = new System.Drawing.Point(10, 78);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(324, 61);
            this.richTextBox.TabIndex = 25;
            this.richTextBox.Text = "0";
            this.richTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // History
            // 
            this.History.AutoSize = true;
            this.History.BackColor = System.Drawing.Color.DimGray;
            this.History.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.History.Location = new System.Drawing.Point(188, 20);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(0, 39);
            this.History.TabIndex = 24;
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonEquals.FlatAppearance.BorderSize = 0;
            this.buttonEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEquals.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEquals.Location = new System.Drawing.Point(259, 489);
            this.buttonEquals.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(75, 75);
            this.buttonEquals.TabIndex = 22;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.BackColor = System.Drawing.Color.DarkRed;
            this.buttonClearAll.FlatAppearance.BorderSize = 0;
            this.buttonClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClearAll.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClearAll.Location = new System.Drawing.Point(178, 168);
            this.buttonClearAll.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(156, 75);
            this.buttonClearAll.TabIndex = 21;
            this.buttonClearAll.Text = "C";
            this.buttonClearAll.UseVisualStyleBackColor = false;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonClearDisp
            // 
            this.buttonClearDisp.BackColor = System.Drawing.Color.Gray;
            this.buttonClearDisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearDisp.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClearDisp.Location = new System.Drawing.Point(97, 168);
            this.buttonClearDisp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearDisp.Name = "buttonClearDisp";
            this.buttonClearDisp.Size = new System.Drawing.Size(75, 75);
            this.buttonClearDisp.TabIndex = 20;
            this.buttonClearDisp.Text = "CE";
            this.buttonClearDisp.UseVisualStyleBackColor = false;
            this.buttonClearDisp.Click += new System.EventHandler(this.buttonClearDisp_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.BackColor = System.Drawing.Color.Gray;
            this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDot.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDot.Location = new System.Drawing.Point(16, 490);
            this.buttonDot.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(75, 75);
            this.buttonDot.TabIndex = 19;
            this.buttonDot.Text = "+/-";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(97, 490);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 18;
            this.button4.Text = "0";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonClearLast
            // 
            this.buttonClearLast.BackColor = System.Drawing.Color.Gray;
            this.buttonClearLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearLast.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonClearLast.Location = new System.Drawing.Point(16, 168);
            this.buttonClearLast.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearLast.Name = "buttonClearLast";
            this.buttonClearLast.Size = new System.Drawing.Size(75, 75);
            this.buttonClearLast.TabIndex = 17;
            this.buttonClearLast.Text = "<-";
            this.buttonClearLast.UseVisualStyleBackColor = false;
            this.buttonClearLast.Click += new System.EventHandler(this.buttonClearLast_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSub.FlatAppearance.BorderSize = 0;
            this.buttonSub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSub.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSub.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSub.Location = new System.Drawing.Point(178, 489);
            this.buttonSub.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(75, 75);
            this.buttonSub.TabIndex = 16;
            this.buttonSub.Text = "-";
            this.buttonSub.UseVisualStyleBackColor = false;
            this.buttonSub.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAdd.Location = new System.Drawing.Point(259, 409);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 75);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(178, 409);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(97, 409);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 13;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(16, 409);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 12;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDiv.FlatAppearance.BorderSize = 0;
            this.buttonDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiv.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDiv.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDiv.Location = new System.Drawing.Point(259, 328);
            this.buttonDiv.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(75, 75);
            this.buttonDiv.TabIndex = 11;
            this.buttonDiv.Text = "÷";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSix.FlatAppearance.BorderSize = 0;
            this.buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSix.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSix.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSix.Location = new System.Drawing.Point(178, 328);
            this.buttonSix.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(75, 75);
            this.buttonSix.TabIndex = 10;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFive.FlatAppearance.BorderSize = 0;
            this.buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFive.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFive.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFive.Location = new System.Drawing.Point(97, 328);
            this.buttonFive.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(75, 75);
            this.buttonFive.TabIndex = 9;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFour.FlatAppearance.BorderSize = 0;
            this.buttonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFour.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFour.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonFour.Location = new System.Drawing.Point(16, 328);
            this.buttonFour.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(75, 75);
            this.buttonFour.TabIndex = 8;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonMul
            // 
            this.buttonMul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonMul.FlatAppearance.BorderSize = 0;
            this.buttonMul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMul.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMul.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonMul.Location = new System.Drawing.Point(260, 249);
            this.buttonMul.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMul.Name = "buttonMul";
            this.buttonMul.Size = new System.Drawing.Size(75, 75);
            this.buttonMul.TabIndex = 7;
            this.buttonMul.Text = "x";
            this.buttonMul.UseVisualStyleBackColor = false;
            this.buttonMul.Click += new System.EventHandler(this.buttonOperation_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNine.FlatAppearance.BorderSize = 0;
            this.buttonNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNine.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNine.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonNine.Location = new System.Drawing.Point(178, 249);
            this.buttonNine.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(75, 75);
            this.buttonNine.TabIndex = 6;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEight.FlatAppearance.BorderSize = 0;
            this.buttonEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEight.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEight.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonEight.Location = new System.Drawing.Point(97, 249);
            this.buttonEight.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(75, 75);
            this.buttonEight.TabIndex = 14;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSeven.FlatAppearance.BorderSize = 0;
            this.buttonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeven.Font = new System.Drawing.Font("Microsoft YaHei UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSeven.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSeven.Location = new System.Drawing.Point(16, 249);
            this.buttonSeven.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(75, 75);
            this.buttonSeven.TabIndex = 15;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(343, 583);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.History);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonClearDisp);
            this.Controls.Add(this.buttonDot);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonClearLast);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonMul);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonSeven);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox richTextBox;
        private Label History;
        private Button buttonEquals;
        private Button buttonClearAll;
        private Button buttonClearDisp;
        private Button buttonDot;
        private Button button4;
        private Button buttonClearLast;
        private Button buttonSub;
        private Button buttonAdd;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonDiv;
        private Button buttonSix;
        private Button buttonFive;
        private Button buttonFour;
        private Button buttonMul;
        private Button buttonNine;
        private Button buttonEight;
        private Button buttonSeven;
    }
}