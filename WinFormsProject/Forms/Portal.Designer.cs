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
            this.Intro = new System.Windows.Forms.LinkLabel();
            this.Calculator = new System.Windows.Forms.LinkLabel();
            this.linkLabelProgress = new System.Windows.Forms.LinkLabel();
            this.linkLabel2048 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // Intro
            // 
            this.Intro.AutoSize = true;
            this.Intro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Intro.Location = new System.Drawing.Point(25, 29);
            this.Intro.Name = "Intro";
            this.Intro.Size = new System.Drawing.Size(54, 25);
            this.Intro.TabIndex = 1;
            this.Intro.TabStop = true;
            this.Intro.Text = "Intro";
            this.Intro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Intro_LinkClicked);
            // 
            // Calculator
            // 
            this.Calculator.AutoSize = true;
            this.Calculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculator.Location = new System.Drawing.Point(23, 91);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(109, 25);
            this.Calculator.TabIndex = 2;
            this.Calculator.TabStop = true;
            this.Calculator.Text = "Calculator";
            this.Calculator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Calculator_LinkClicked);
            // 
            // linkLabelProgress
            // 
            this.linkLabelProgress.AutoSize = true;
            this.linkLabelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelProgress.Location = new System.Drawing.Point(23, 162);
            this.linkLabelProgress.Name = "linkLabelProgress";
            this.linkLabelProgress.Size = new System.Drawing.Size(121, 25);
            this.linkLabelProgress.TabIndex = 2;
            this.linkLabelProgress.TabStop = true;
            this.linkLabelProgress.Text = "Индикация";
            this.linkLabelProgress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelProgress_LinkClicked);
            // 
            // linkLabel2048
            // 
            this.linkLabel2048.AutoSize = true;
            this.linkLabel2048.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel2048.Location = new System.Drawing.Point(23, 231);
            this.linkLabel2048.Name = "linkLabel2048";
            this.linkLabel2048.Size = new System.Drawing.Size(357, 25);
            this.linkLabel2048.TabIndex = 2;
            this.linkLabel2048.TabStop = true;
            this.linkLabel2048.Text = "Событие и взаимодействие (2048)";
            this.linkLabel2048.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2048_LinkClicked);
            // 
            // Portal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel2048);
            this.Controls.Add(this.linkLabelProgress);
            this.Controls.Add(this.Calculator);
            this.Controls.Add(this.Intro);
            this.Name = "Portal";
            this.Text = "Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel Intro;
        private LinkLabel Calculator;
        private LinkLabel linkLabelProgress;
        private LinkLabel linkLabel2048;
    }
}