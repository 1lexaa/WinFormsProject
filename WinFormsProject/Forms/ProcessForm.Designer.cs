namespace WinForms.Forms
{
    partial class ProcessForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabelOdItStep = new System.Windows.Forms.LinkLabel();
            this.linkLabelItStep = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonBrowserStop = new System.Windows.Forms.Button();
            this.buttonBrowserStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonNotepadLog = new System.Windows.Forms.Button();
            this.buttonNotepadStop = new System.Windows.Forms.Button();
            this.buttonNotepadStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.treeViewProcesses = new System.Windows.Forms.TreeView();
            this.timerRefresher = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabelOdItStep);
            this.groupBox1.Controls.Add(this.linkLabelItStep);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(215, 300);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дочерние процессы";
            // 
            // linkLabelOdItStep
            // 
            this.linkLabelOdItStep.AutoSize = true;
            this.linkLabelOdItStep.LinkVisited = true;
            this.linkLabelOdItStep.Location = new System.Drawing.Point(28, 248);
            this.linkLabelOdItStep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelOdItStep.Name = "linkLabelOdItStep";
            this.linkLabelOdItStep.Size = new System.Drawing.Size(114, 15);
            this.linkLabelOdItStep.TabIndex = 1;
            this.linkLabelOdItStep.TabStop = true;
            this.linkLabelOdItStep.Text = "https://od.itstep.org";
            // 
            // linkLabelItStep
            // 
            this.linkLabelItStep.AutoSize = true;
            this.linkLabelItStep.LinkVisited = true;
            this.linkLabelItStep.Location = new System.Drawing.Point(28, 228);
            this.linkLabelItStep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelItStep.Name = "linkLabelItStep";
            this.linkLabelItStep.Size = new System.Drawing.Size(97, 15);
            this.linkLabelItStep.TabIndex = 1;
            this.linkLabelItStep.TabStop = true;
            this.linkLabelItStep.Text = "https://itstep.org";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(28, 207);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(141, 15);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://mystat.itstep.org/";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonBrowserStop);
            this.groupBox4.Controls.Add(this.buttonBrowserStart);
            this.groupBox4.Location = new System.Drawing.Point(52, 116);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox4.Size = new System.Drawing.Size(94, 86);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Браузер";
            // 
            // buttonBrowserStop
            // 
            this.buttonBrowserStop.Location = new System.Drawing.Point(11, 39);
            this.buttonBrowserStop.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonBrowserStop.Name = "buttonBrowserStop";
            this.buttonBrowserStop.Size = new System.Drawing.Size(68, 19);
            this.buttonBrowserStop.TabIndex = 1;
            this.buttonBrowserStop.Text = "Стоп";
            this.buttonBrowserStop.UseVisualStyleBackColor = true;
            this.buttonBrowserStop.Click += new System.EventHandler(this.buttonBrowserStop_Click);
            // 
            // buttonBrowserStart
            // 
            this.buttonBrowserStart.Location = new System.Drawing.Point(11, 18);
            this.buttonBrowserStart.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonBrowserStart.Name = "buttonBrowserStart";
            this.buttonBrowserStart.Size = new System.Drawing.Size(68, 19);
            this.buttonBrowserStart.TabIndex = 1;
            this.buttonBrowserStart.Text = "Пуск";
            this.buttonBrowserStart.UseVisualStyleBackColor = true;
            this.buttonBrowserStart.Click += new System.EventHandler(this.buttonBrowserStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonNotepadLog);
            this.groupBox2.Controls.Add(this.buttonNotepadStop);
            this.groupBox2.Controls.Add(this.buttonNotepadStart);
            this.groupBox2.Location = new System.Drawing.Point(52, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Size = new System.Drawing.Size(94, 86);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Блокнот";
            // 
            // buttonNotepadLog
            // 
            this.buttonNotepadLog.Location = new System.Drawing.Point(11, 61);
            this.buttonNotepadLog.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonNotepadLog.Name = "buttonNotepadLog";
            this.buttonNotepadLog.Size = new System.Drawing.Size(68, 19);
            this.buttonNotepadLog.TabIndex = 1;
            this.buttonNotepadLog.Text = "Журнал";
            this.buttonNotepadLog.UseVisualStyleBackColor = true;
            this.buttonNotepadLog.Click += new System.EventHandler(this.buttonNotepadLog_Click);
            // 
            // buttonNotepadStop
            // 
            this.buttonNotepadStop.Location = new System.Drawing.Point(11, 39);
            this.buttonNotepadStop.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonNotepadStop.Name = "buttonNotepadStop";
            this.buttonNotepadStop.Size = new System.Drawing.Size(68, 19);
            this.buttonNotepadStop.TabIndex = 1;
            this.buttonNotepadStop.Text = "Стоп";
            this.buttonNotepadStop.UseVisualStyleBackColor = true;
            this.buttonNotepadStop.Click += new System.EventHandler(this.buttonNotepadStop_Click);
            // 
            // buttonNotepadStart
            // 
            this.buttonNotepadStart.Location = new System.Drawing.Point(11, 18);
            this.buttonNotepadStart.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonNotepadStart.Name = "buttonNotepadStart";
            this.buttonNotepadStart.Size = new System.Drawing.Size(68, 19);
            this.buttonNotepadStart.TabIndex = 1;
            this.buttonNotepadStart.Text = "Пуск";
            this.buttonNotepadStart.UseVisualStyleBackColor = true;
            this.buttonNotepadStart.Click += new System.EventHandler(this.buttonNotepadStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelTimer);
            this.groupBox3.Controls.Add(this.buttonRefresh);
            this.groupBox3.Controls.Add(this.treeViewProcesses);
            this.groupBox3.Location = new System.Drawing.Point(245, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Size = new System.Drawing.Size(463, 294);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Системные процессы";
            // 
            // labelTimer
            // 
            this.labelTimer.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimer.Location = new System.Drawing.Point(10, 73);
            this.labelTimer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(84, 30);
            this.labelTimer.TabIndex = 2;
            this.labelTimer.Text = "00:00:00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(32, 30);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(81, 22);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // treeViewProcesses
            // 
            this.treeViewProcesses.Location = new System.Drawing.Point(133, 18);
            this.treeViewProcesses.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.treeViewProcesses.Name = "treeViewProcesses";
            this.treeViewProcesses.Size = new System.Drawing.Size(318, 265);
            this.treeViewProcesses.TabIndex = 0;
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 319);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProcessForm";
            this.Text = "ProcessForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private LinkLabel linkLabelOdItStep;
        private LinkLabel linkLabelItStep;
        private LinkLabel linkLabel1;
        private GroupBox groupBox4;
        private Button buttonBrowserStop;
        private Button buttonBrowserStart;
        private GroupBox groupBox2;
        private Button buttonNotepadLog;
        private Button buttonNotepadStop;
        private Button buttonNotepadStart;
        private GroupBox groupBox3;
        private Label labelTimer;
        private Button buttonRefresh;
        private TreeView treeViewProcesses;
        private System.Windows.Forms.Timer timerRefresher;
    }
}