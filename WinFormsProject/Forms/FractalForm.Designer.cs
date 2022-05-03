namespace WinForms.Forms
{
    partial class FractalForm
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
            this.panelPicture = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxReC = new System.Windows.Forms.TextBox();
            this.textBoxImC = new System.Windows.Forms.TextBox();
            this.labelIm = new System.Windows.Forms.Label();
            this.labelRe = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPicture
            // 
            this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicture.Location = new System.Drawing.Point(234, 39);
            this.panelPicture.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(243, 212);
            this.panelPicture.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonExit);
            this.groupBox2.Controls.Add(this.buttonStop);
            this.groupBox2.Controls.Add(this.buttonStart);
            this.groupBox2.Location = new System.Drawing.Point(21, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Size = new System.Drawing.Size(140, 115);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(27, 87);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(81, 22);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(27, 51);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(81, 22);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(27, 18);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(81, 22);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxReC);
            this.groupBox1.Controls.Add(this.textBoxImC);
            this.groupBox1.Controls.Add(this.labelIm);
            this.groupBox1.Controls.Add(this.labelRe);
            this.groupBox1.Location = new System.Drawing.Point(21, 39);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(140, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Constant";
            // 
            // textBoxReC
            // 
            this.textBoxReC.Location = new System.Drawing.Point(48, 22);
            this.textBoxReC.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxReC.Name = "textBoxReC";
            this.textBoxReC.Size = new System.Drawing.Size(74, 23);
            this.textBoxReC.TabIndex = 3;
            this.textBoxReC.Text = "0,311";
            // 
            // textBoxImC
            // 
            this.textBoxImC.Location = new System.Drawing.Point(48, 57);
            this.textBoxImC.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxImC.Name = "textBoxImC";
            this.textBoxImC.Size = new System.Drawing.Size(74, 23);
            this.textBoxImC.TabIndex = 2;
            this.textBoxImC.Text = "0,495";
            // 
            // labelIm
            // 
            this.labelIm.AutoSize = true;
            this.labelIm.Location = new System.Drawing.Point(5, 55);
            this.labelIm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIm.Name = "labelIm";
            this.labelIm.Size = new System.Drawing.Size(35, 15);
            this.labelIm.TabIndex = 1;
            this.labelIm.Text = "Im = ";
            // 
            // labelRe
            // 
            this.labelRe.AutoSize = true;
            this.labelRe.Location = new System.Drawing.Point(6, 22);
            this.labelRe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRe.Name = "labelRe";
            this.labelRe.Size = new System.Drawing.Size(34, 15);
            this.labelRe.TabIndex = 0;
            this.labelRe.Text = "Re = ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitMenuItem.Text = "Exit";
            // 
            // FractalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPicture);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FractalForm";
            this.Text = "FractalForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelPicture;
        private GroupBox groupBox2;
        private Button buttonExit;
        private Button buttonStop;
        private Button buttonStart;
        private GroupBox groupBox1;
        private TextBox textBoxReC;
        private TextBox textBoxImC;
        private Label labelIm;
        private Label labelRe;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitMenuItem;
    }
}