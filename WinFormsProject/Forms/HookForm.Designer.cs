namespace WinForms.Forms
{
    partial class HookForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxReplaces = new System.Windows.Forms.GroupBox();
            this.buttonAddReplace = new System.Windows.Forms.Button();
            this.textBoxSourceKey = new System.Windows.Forms.TextBox();
            this.textBoxTargetKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxReplaces = new System.Windows.Forms.ListBox();
            this.richTextBoxKb = new System.Windows.Forms.RichTextBox();
            this.buttonKbStop = new System.Windows.Forms.Button();
            this.buttonKbStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBoxMs = new System.Windows.Forms.ListBox();
            this.buttonMsStop = new System.Windows.Forms.Button();
            this.buttonMsStart = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxReplaces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxReplaces);
            this.tabPage1.Controls.Add(this.richTextBoxKb);
            this.tabPage1.Controls.Add(this.buttonKbStop);
            this.tabPage1.Controls.Add(this.buttonKbStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(660, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "KeyBoard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.listBoxMs);
            this.tabPage2.Controls.Add(this.buttonMsStop);
            this.tabPage2.Controls.Add(this.buttonMsStart);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(660, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mouse";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxReplaces
            // 
            this.groupBoxReplaces.Controls.Add(this.buttonAddReplace);
            this.groupBoxReplaces.Controls.Add(this.textBoxSourceKey);
            this.groupBoxReplaces.Controls.Add(this.textBoxTargetKey);
            this.groupBoxReplaces.Controls.Add(this.label1);
            this.groupBoxReplaces.Controls.Add(this.listBoxReplaces);
            this.groupBoxReplaces.Location = new System.Drawing.Point(365, 19);
            this.groupBoxReplaces.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBoxReplaces.Name = "groupBoxReplaces";
            this.groupBoxReplaces.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBoxReplaces.Size = new System.Drawing.Size(221, 168);
            this.groupBoxReplaces.TabIndex = 7;
            this.groupBoxReplaces.TabStop = false;
            this.groupBoxReplaces.Text = "Replaces";
            // 
            // buttonAddReplace
            // 
            this.buttonAddReplace.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddReplace.Location = new System.Drawing.Point(78, 136);
            this.buttonAddReplace.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonAddReplace.Name = "buttonAddReplace";
            this.buttonAddReplace.Size = new System.Drawing.Size(69, 21);
            this.buttonAddReplace.TabIndex = 3;
            this.buttonAddReplace.Text = "+";
            this.buttonAddReplace.UseVisualStyleBackColor = true;
            this.buttonAddReplace.Click += new System.EventHandler(this.buttonAddReplace_Click);
            // 
            // textBoxSourceKey
            // 
            this.textBoxSourceKey.Location = new System.Drawing.Point(6, 114);
            this.textBoxSourceKey.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxSourceKey.Multiline = true;
            this.textBoxSourceKey.Name = "textBoxSourceKey";
            this.textBoxSourceKey.Size = new System.Drawing.Size(82, 21);
            this.textBoxSourceKey.TabIndex = 2;
            // 
            // textBoxTargetKey
            // 
            this.textBoxTargetKey.Location = new System.Drawing.Point(138, 114);
            this.textBoxTargetKey.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.textBoxTargetKey.Multiline = true;
            this.textBoxTargetKey.Name = "textBoxTargetKey";
            this.textBoxTargetKey.Size = new System.Drawing.Size(82, 21);
            this.textBoxTargetKey.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "---->";
            // 
            // listBoxReplaces
            // 
            this.listBoxReplaces.FormattingEnabled = true;
            this.listBoxReplaces.ItemHeight = 15;
            this.listBoxReplaces.Location = new System.Drawing.Point(6, 16);
            this.listBoxReplaces.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listBoxReplaces.Name = "listBoxReplaces";
            this.listBoxReplaces.Size = new System.Drawing.Size(209, 64);
            this.listBoxReplaces.TabIndex = 0;
            // 
            // richTextBoxKb
            // 
            this.richTextBoxKb.Location = new System.Drawing.Point(108, 19);
            this.richTextBoxKb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.richTextBoxKb.Name = "richTextBoxKb";
            this.richTextBoxKb.ReadOnly = true;
            this.richTextBoxKb.Size = new System.Drawing.Size(243, 170);
            this.richTextBoxKb.TabIndex = 6;
            this.richTextBoxKb.Text = "";
            // 
            // buttonKbStop
            // 
            this.buttonKbStop.Location = new System.Drawing.Point(13, 98);
            this.buttonKbStop.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonKbStop.Name = "buttonKbStop";
            this.buttonKbStop.Size = new System.Drawing.Size(81, 22);
            this.buttonKbStop.TabIndex = 5;
            this.buttonKbStop.Text = "Stop";
            this.buttonKbStop.UseVisualStyleBackColor = true;
            this.buttonKbStop.Click += new System.EventHandler(this.buttonKbStop_Click);
            // 
            // buttonKbStart
            // 
            this.buttonKbStart.Location = new System.Drawing.Point(13, 62);
            this.buttonKbStart.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonKbStart.Name = "buttonKbStart";
            this.buttonKbStart.Size = new System.Drawing.Size(81, 22);
            this.buttonKbStart.TabIndex = 4;
            this.buttonKbStart.Text = "Start";
            this.buttonKbStart.UseVisualStyleBackColor = true;
            this.buttonKbStart.Click += new System.EventHandler(this.buttonKbStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(5, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // listBoxMs
            // 
            this.listBoxMs.FormattingEnabled = true;
            this.listBoxMs.ItemHeight = 15;
            this.listBoxMs.Location = new System.Drawing.Point(272, 13);
            this.listBoxMs.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.listBoxMs.Name = "listBoxMs";
            this.listBoxMs.Size = new System.Drawing.Size(367, 214);
            this.listBoxMs.TabIndex = 7;
            // 
            // buttonMsStop
            // 
            this.buttonMsStop.Location = new System.Drawing.Point(5, 49);
            this.buttonMsStop.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonMsStop.Name = "buttonMsStop";
            this.buttonMsStop.Size = new System.Drawing.Size(81, 22);
            this.buttonMsStop.TabIndex = 6;
            this.buttonMsStop.Text = "Stop";
            this.buttonMsStop.UseVisualStyleBackColor = true;
            this.buttonMsStop.Click += new System.EventHandler(this.buttonMsStop_Click);
            // 
            // buttonMsStart
            // 
            this.buttonMsStart.Location = new System.Drawing.Point(5, 13);
            this.buttonMsStart.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonMsStart.Name = "buttonMsStart";
            this.buttonMsStart.Size = new System.Drawing.Size(81, 22);
            this.buttonMsStart.TabIndex = 5;
            this.buttonMsStart.Text = "Start";
            this.buttonMsStart.UseVisualStyleBackColor = true;
            this.buttonMsStart.Click += new System.EventHandler(this.buttonMsStart_Click);
            // 
            // HookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "HookForm";
            this.Text = "HookForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBoxReplaces.ResumeLayout(false);
            this.groupBoxReplaces.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox groupBoxReplaces;
        private Button buttonAddReplace;
        private TextBox textBoxSourceKey;
        private TextBox textBoxTargetKey;
        private Label label1;
        private ListBox listBoxReplaces;
        private RichTextBox richTextBoxKb;
        private Button buttonKbStop;
        private Button buttonKbStart;
        private PictureBox pictureBox1;
        private ListBox listBoxMs;
        private Button buttonMsStop;
        private Button buttonMsStart;
    }
}