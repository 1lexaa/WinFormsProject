namespace WinForms.Forms
{
    partial class FileSypherForm
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
            this.buttonShowPassword = new System.Windows.Forms.Button();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.progressBarCiphering = new System.Windows.Forms.ProgressBar();
            this.buttonCancelProgress = new System.Windows.Forms.Button();
            this.panelTarget = new System.Windows.Forms.Panel();
            this.buttonSelectTarget = new System.Windows.Forms.Button();
            this.textBoxTarget = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCipher = new System.Windows.Forms.Button();
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSourceFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSampleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelProgress.SuspendLayout();
            this.panelTarget.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShowPassword
            // 
            this.buttonShowPassword.Location = new System.Drawing.Point(236, 114);
            this.buttonShowPassword.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonShowPassword.Name = "buttonShowPassword";
            this.buttonShowPassword.Size = new System.Drawing.Size(40, 18);
            this.buttonShowPassword.TabIndex = 15;
            this.buttonShowPassword.Text = "🙈";
            this.buttonShowPassword.UseVisualStyleBackColor = true;
            this.buttonShowPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonShowPassword_MouseDown);
            this.buttonShowPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonShowPassword_MouseUp);
            // 
            // panelProgress
            // 
            this.panelProgress.Controls.Add(this.progressBarCiphering);
            this.panelProgress.Controls.Add(this.buttonCancelProgress);
            this.panelProgress.Location = new System.Drawing.Point(156, 190);
            this.panelProgress.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(350, 37);
            this.panelProgress.TabIndex = 13;
            // 
            // progressBarCiphering
            // 
            this.progressBarCiphering.Location = new System.Drawing.Point(0, 0);
            this.progressBarCiphering.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.progressBarCiphering.Name = "progressBarCiphering";
            this.progressBarCiphering.Size = new System.Drawing.Size(243, 37);
            this.progressBarCiphering.TabIndex = 1;
            // 
            // buttonCancelProgress
            // 
            this.buttonCancelProgress.Location = new System.Drawing.Point(252, 7);
            this.buttonCancelProgress.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonCancelProgress.Name = "buttonCancelProgress";
            this.buttonCancelProgress.Size = new System.Drawing.Size(81, 22);
            this.buttonCancelProgress.TabIndex = 0;
            this.buttonCancelProgress.Text = "Cancel";
            this.buttonCancelProgress.UseVisualStyleBackColor = true;
            this.buttonCancelProgress.Click += new System.EventHandler(this.buttonCancelProgress_Click);
            // 
            // panelTarget
            // 
            this.panelTarget.Controls.Add(this.buttonSelectTarget);
            this.panelTarget.Controls.Add(this.textBoxTarget);
            this.panelTarget.Controls.Add(this.label3);
            this.panelTarget.Location = new System.Drawing.Point(399, 39);
            this.panelTarget.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panelTarget.Name = "panelTarget";
            this.panelTarget.Size = new System.Drawing.Size(215, 54);
            this.panelTarget.TabIndex = 14;
            // 
            // buttonSelectTarget
            // 
            this.buttonSelectTarget.Location = new System.Drawing.Point(163, 23);
            this.buttonSelectTarget.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonSelectTarget.Name = "buttonSelectTarget";
            this.buttonSelectTarget.Size = new System.Drawing.Size(31, 20);
            this.buttonSelectTarget.TabIndex = 2;
            this.buttonSelectTarget.Text = "...";
            this.buttonSelectTarget.UseVisualStyleBackColor = true;
            // 
            // textBoxTarget
            // 
            this.textBoxTarget.Location = new System.Drawing.Point(52, 23);
            this.textBoxTarget.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxTarget.Name = "textBoxTarget";
            this.textBoxTarget.Size = new System.Drawing.Size(110, 23);
            this.textBoxTarget.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Target";
            // 
            // buttonCipher
            // 
            this.buttonCipher.Location = new System.Drawing.Point(56, 195);
            this.buttonCipher.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonCipher.Name = "buttonCipher";
            this.buttonCipher.Size = new System.Drawing.Size(78, 25);
            this.buttonCipher.TabIndex = 11;
            this.buttonCipher.Text = "Cipher";
            this.buttonCipher.UseVisualStyleBackColor = true;
            this.buttonCipher.Click += new System.EventHandler(this.buttonCipher_Click);
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(236, 64);
            this.buttonSelectFile.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(34, 18);
            this.buttonSelectFile.TabIndex = 12;
            this.buttonSelectFile.Text = "...";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(111, 111);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(110, 23);
            this.textBoxPassword.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter a password";
            // 
            // textBoxSourceFileName
            // 
            this.textBoxSourceFileName.Location = new System.Drawing.Point(111, 59);
            this.textBoxSourceFileName.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxSourceFileName.Name = "textBoxSourceFileName";
            this.textBoxSourceFileName.Size = new System.Drawing.Size(110, 23);
            this.textBoxSourceFileName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select a file";
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
            this.makeSampleMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // makeSampleMenuItem
            // 
            this.makeSampleMenuItem.Name = "makeSampleMenuItem";
            this.makeSampleMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeSampleMenuItem.Text = "Make sample";
            this.makeSampleMenuItem.Click += new System.EventHandler(this.makeSampleMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // FileSypherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShowPassword);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.panelTarget);
            this.Controls.Add(this.buttonCipher);
            this.Controls.Add(this.buttonSelectFile);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSourceFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FileSypherForm";
            this.Text = "FileSypherForm";
            this.Load += new System.EventHandler(this.FileSypherForm_Load);
            this.panelProgress.ResumeLayout(false);
            this.panelTarget.ResumeLayout(false);
            this.panelTarget.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonShowPassword;
        private Panel panelProgress;
        private ProgressBar progressBarCiphering;
        private Button buttonCancelProgress;
        private Panel panelTarget;
        private Button buttonSelectTarget;
        private TextBox textBoxTarget;
        private Label label3;
        private Button buttonCipher;
        private Button buttonSelectFile;
        private TextBox textBoxPassword;
        private Label label2;
        private TextBox textBoxSourceFileName;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem makeSampleMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}