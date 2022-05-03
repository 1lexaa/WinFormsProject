namespace WinForms.Forms
{
    partial class Portal
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
            this.linkLabelHasher = new System.Windows.Forms.LinkLabel();
            this.linkLabel2Async = new System.Windows.Forms.LinkLabel();
            this.linkLabelAsync1 = new System.Windows.Forms.LinkLabel();
            this.linkLabelHooks = new System.Windows.Forms.LinkLabel();
            this.linkLabelPatterns = new System.Windows.Forms.LinkLabel();
            this.linkProcess = new System.Windows.Forms.LinkLabel();
            this.linkGdi = new System.Windows.Forms.LinkLabel();
            this.linkLabel2048 = new System.Windows.Forms.LinkLabel();
            this.progressLink = new System.Windows.Forms.LinkLabel();
            this.Calculator = new System.Windows.Forms.LinkLabel();
            this.Intro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabelHasher
            // 
            this.linkLabelHasher.AutoSize = true;
            this.linkLabelHasher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelHasher.Location = new System.Drawing.Point(8, 351);
            this.linkLabelHasher.Name = "linkLabelHasher";
            this.linkLabelHasher.Size = new System.Drawing.Size(355, 25);
            this.linkLabelHasher.TabIndex = 1;
            this.linkLabelHasher.TabStop = true;
            this.linkLabelHasher.Text = "Библиотеки класса (шифрование)";
            this.linkLabelHasher.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHasher_LinkClicked);
            // 
            // linkLabel2Async
            // 
            this.linkLabel2Async.AutoSize = true;
            this.linkLabel2Async.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2Async.Location = new System.Drawing.Point(8, 320);
            this.linkLabel2Async.Name = "linkLabel2Async";
            this.linkLabel2Async.Size = new System.Drawing.Size(483, 25);
            this.linkLabel2Async.TabIndex = 2;
            this.linkLabel2Async.TabStop = true;
            this.linkLabel2Async.Text = "Асинхронное программирование 2 (Фракталы)";
            this.linkLabel2Async.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2Async_LinkClicked);
            // 
            // linkLabelAsync1
            // 
            this.linkLabelAsync1.AutoSize = true;
            this.linkLabelAsync1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelAsync1.Location = new System.Drawing.Point(8, 288);
            this.linkLabelAsync1.Name = "linkLabelAsync1";
            this.linkLabelAsync1.Size = new System.Drawing.Size(486, 25);
            this.linkLabelAsync1.TabIndex = 3;
            this.linkLabelAsync1.TabStop = true;
            this.linkLabelAsync1.Text = "Асинхронное программирование 1 (Шифратор)";
            this.linkLabelAsync1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAsync1_LinkClicked);
            // 
            // linkLabelHooks
            // 
            this.linkLabelHooks.AutoSize = true;
            this.linkLabelHooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelHooks.Location = new System.Drawing.Point(8, 257);
            this.linkLabelHooks.Name = "linkLabelHooks";
            this.linkLabelHooks.Size = new System.Drawing.Size(291, 25);
            this.linkLabelHooks.TabIndex = 4;
            this.linkLabelHooks.TabStop = true;
            this.linkLabelHooks.Text = "Унаследованный код (Хуки)";
            this.linkLabelHooks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelHooks_LinkClicked);
            // 
            // linkLabelPatterns
            // 
            this.linkLabelPatterns.AutoSize = true;
            this.linkLabelPatterns.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelPatterns.Location = new System.Drawing.Point(8, 226);
            this.linkLabelPatterns.Name = "linkLabelPatterns";
            this.linkLabelPatterns.Size = new System.Drawing.Size(279, 25);
            this.linkLabelPatterns.TabIndex = 5;
            this.linkLabelPatterns.TabStop = true;
            this.linkLabelPatterns.Text = "Паттерны проектирования";
            this.linkLabelPatterns.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPatterns_LinkClicked);
            // 
            // linkProcess
            // 
            this.linkProcess.AutoSize = true;
            this.linkProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkProcess.Location = new System.Drawing.Point(11, 198);
            this.linkProcess.Name = "linkProcess";
            this.linkProcess.Size = new System.Drawing.Size(112, 25);
            this.linkProcess.TabIndex = 6;
            this.linkProcess.TabStop = true;
            this.linkProcess.Text = "Процессы";
            this.linkProcess.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProcess_LinkClicked);
            // 
            // linkGdi
            // 
            this.linkGdi.AutoSize = true;
            this.linkGdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkGdi.Location = new System.Drawing.Point(12, 165);
            this.linkGdi.Name = "linkGdi";
            this.linkGdi.Size = new System.Drawing.Size(353, 25);
            this.linkGdi.TabIndex = 7;
            this.linkGdi.TabStop = true;
            this.linkGdi.Text = "Графические возможности (GDI+)";
            this.linkGdi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGdi_LinkClicked);
            // 
            // linkLabel2048
            // 
            this.linkLabel2048.AutoSize = true;
            this.linkLabel2048.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2048.Location = new System.Drawing.Point(12, 132);
            this.linkLabel2048.Name = "linkLabel2048";
            this.linkLabel2048.Size = new System.Drawing.Size(355, 25);
            this.linkLabel2048.TabIndex = 8;
            this.linkLabel2048.TabStop = true;
            this.linkLabel2048.Text = "Cобытия и взаимодействия (2048)";
            this.linkLabel2048.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2048_LinkClicked);
            // 
            // progressLink
            // 
            this.progressLink.AutoSize = true;
            this.progressLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.progressLink.Location = new System.Drawing.Point(12, 97);
            this.progressLink.Name = "progressLink";
            this.progressLink.Size = new System.Drawing.Size(98, 25);
            this.progressLink.TabIndex = 9;
            this.progressLink.TabStop = true;
            this.progressLink.Text = "Progress";
            this.progressLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Progress_LinkClicked);
            // 
            // Calculator
            // 
            this.Calculator.AutoSize = true;
            this.Calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculator.Location = new System.Drawing.Point(12, 59);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(109, 25);
            this.Calculator.TabIndex = 10;
            this.Calculator.TabStop = true;
            this.Calculator.Text = "Calculator";
            this.Calculator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Calculator_LinkClicked);
            // 
            // Intro
            // 
            this.Intro.AutoSize = true;
            this.Intro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Intro.Location = new System.Drawing.Point(12, 18);
            this.Intro.Name = "Intro";
            this.Intro.Size = new System.Drawing.Size(54, 25);
            this.Intro.TabIndex = 11;
            this.Intro.TabStop = true;
            this.Intro.Text = "Intro";
            this.Intro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Intro_LinkClicked);
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelHasher);
            this.Controls.Add(this.linkLabel2Async);
            this.Controls.Add(this.linkLabelAsync1);
            this.Controls.Add(this.linkLabelHooks);
            this.Controls.Add(this.linkLabelPatterns);
            this.Controls.Add(this.linkProcess);
            this.Controls.Add(this.linkGdi);
            this.Controls.Add(this.linkLabel2048);
            this.Controls.Add(this.progressLink);
            this.Controls.Add(this.Calculator);
            this.Controls.Add(this.Intro);
            this.Name = "Portal";
            this.Text = "Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkLabelHasher;
        private LinkLabel linkLabel2Async;
        private LinkLabel linkLabelAsync1;
        private LinkLabel linkLabelHooks;
        private LinkLabel linkLabelPatterns;
        private LinkLabel linkProcess;
        private LinkLabel linkGdi;
        private LinkLabel linkLabel2048;
        private LinkLabel progressLink;
        private LinkLabel Calculator;
        private LinkLabel Intro;
    }
}