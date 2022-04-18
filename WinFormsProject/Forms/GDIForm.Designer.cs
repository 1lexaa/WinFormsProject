namespace WinForms.Forms
{
    partial class GDIForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBalls = new System.Windows.Forms.Label();
            this.labelMissed = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelClock = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.labelBalls);
            this.panel1.Controls.Add(this.labelMissed);
            this.panel1.Controls.Add(this.labelScore);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelClock);
            this.panel1.Location = new System.Drawing.Point(6, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 28);
            this.panel1.TabIndex = 1;
            // 
            // labelBalls
            // 
            this.labelBalls.AutoSize = true;
            this.labelBalls.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBalls.Location = new System.Drawing.Point(324, 4);
            this.labelBalls.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBalls.Name = "labelBalls";
            this.labelBalls.Size = new System.Drawing.Size(19, 21);
            this.labelBalls.TabIndex = 2;
            this.labelBalls.Text = "0";
            this.labelBalls.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMissed
            // 
            this.labelMissed.AutoSize = true;
            this.labelMissed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMissed.Location = new System.Drawing.Point(244, 4);
            this.labelMissed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMissed.Name = "labelMissed";
            this.labelMissed.Size = new System.Drawing.Size(19, 21);
            this.labelMissed.TabIndex = 2;
            this.labelMissed.Text = "0";
            this.labelMissed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelScore.Location = new System.Drawing.Point(136, 4);
            this.labelScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(19, 21);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(272, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Balls:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(172, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Missed:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClock.Location = new System.Drawing.Point(2, 4);
            this.labelClock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(70, 21);
            this.labelClock.TabIndex = 0;
            this.labelClock.Text = "00:00:00";
            this.labelClock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 235);
            this.Controls.Add(this.panel1);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "GDIForm";
            this.Text = "GDIForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GDIForm_FormClosing);
            this.Load += new System.EventHandler(this.GDIForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GDIForm_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GDIForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GDIForm_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Label labelBalls;
        private Label labelMissed;
        private Label labelScore;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label labelClock;
    }
}