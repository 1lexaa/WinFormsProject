namespace WinForms.Forms
{
    partial class Game2048
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
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelGameField = new System.Windows.Forms.Panel();
            this.cell33 = new System.Windows.Forms.Label();
            this.cell23 = new System.Windows.Forms.Label();
            this.cell13 = new System.Windows.Forms.Label();
            this.cell03 = new System.Windows.Forms.Label();
            this.cell32 = new System.Windows.Forms.Label();
            this.cell22 = new System.Windows.Forms.Label();
            this.cell31 = new System.Windows.Forms.Label();
            this.cell12 = new System.Windows.Forms.Label();
            this.cell21 = new System.Windows.Forms.Label();
            this.cell11 = new System.Windows.Forms.Label();
            this.cell30 = new System.Windows.Forms.Label();
            this.cell02 = new System.Windows.Forms.Label();
            this.cell20 = new System.Windows.Forms.Label();
            this.cell10 = new System.Windows.Forms.Label();
            this.cell01 = new System.Windows.Forms.Label();
            this.cell00 = new System.Windows.Forms.Label();
            this.panelSensor = new System.Windows.Forms.Panel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.timerAnim = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topmostMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animationGameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelDisplay.SuspendLayout();
            this.panelGameField.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDisplay
            // 
            this.panelDisplay.Controls.Add(this.labelTime);
            this.panelDisplay.Location = new System.Drawing.Point(10, 27);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(240, 100);
            this.panelDisplay.TabIndex = 0;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.Location = new System.Drawing.Point(3, 79);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(70, 21);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "00:00:00";
            // 
            // panelGameField
            // 
            this.panelGameField.Controls.Add(this.cell33);
            this.panelGameField.Controls.Add(this.cell23);
            this.panelGameField.Controls.Add(this.cell13);
            this.panelGameField.Controls.Add(this.cell03);
            this.panelGameField.Controls.Add(this.cell32);
            this.panelGameField.Controls.Add(this.cell22);
            this.panelGameField.Controls.Add(this.cell31);
            this.panelGameField.Controls.Add(this.cell12);
            this.panelGameField.Controls.Add(this.cell21);
            this.panelGameField.Controls.Add(this.cell11);
            this.panelGameField.Controls.Add(this.cell30);
            this.panelGameField.Controls.Add(this.cell02);
            this.panelGameField.Controls.Add(this.cell20);
            this.panelGameField.Controls.Add(this.cell10);
            this.panelGameField.Controls.Add(this.cell01);
            this.panelGameField.Controls.Add(this.cell00);
            this.panelGameField.Location = new System.Drawing.Point(10, 133);
            this.panelGameField.Name = "panelGameField";
            this.panelGameField.Size = new System.Drawing.Size(350, 350);
            this.panelGameField.TabIndex = 1;
            // 
            // cell33
            // 
            this.cell33.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell33.Location = new System.Drawing.Point(265, 265);
            this.cell33.Name = "cell33";
            this.cell33.Size = new System.Drawing.Size(75, 75);
            this.cell33.TabIndex = 3;
            this.cell33.Text = "0";
            this.cell33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell23
            // 
            this.cell23.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell23.Location = new System.Drawing.Point(265, 180);
            this.cell23.Name = "cell23";
            this.cell23.Size = new System.Drawing.Size(75, 75);
            this.cell23.TabIndex = 3;
            this.cell23.Text = "512";
            this.cell23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell13
            // 
            this.cell13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell13.Location = new System.Drawing.Point(265, 95);
            this.cell13.Name = "cell13";
            this.cell13.Size = new System.Drawing.Size(75, 75);
            this.cell13.TabIndex = 3;
            this.cell13.Text = "32";
            this.cell13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell03
            // 
            this.cell03.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell03.Location = new System.Drawing.Point(265, 10);
            this.cell03.Name = "cell03";
            this.cell03.Size = new System.Drawing.Size(75, 75);
            this.cell03.TabIndex = 3;
            this.cell03.Text = "4";
            this.cell03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell32
            // 
            this.cell32.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell32.Location = new System.Drawing.Point(180, 265);
            this.cell32.Name = "cell32";
            this.cell32.Size = new System.Drawing.Size(75, 75);
            this.cell32.TabIndex = 2;
            this.cell32.Text = "4096";
            this.cell32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell22
            // 
            this.cell22.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell22.Location = new System.Drawing.Point(180, 180);
            this.cell22.Name = "cell22";
            this.cell22.Size = new System.Drawing.Size(75, 75);
            this.cell22.TabIndex = 2;
            this.cell22.Text = "256";
            this.cell22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell31
            // 
            this.cell31.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell31.Location = new System.Drawing.Point(95, 265);
            this.cell31.Name = "cell31";
            this.cell31.Size = new System.Drawing.Size(75, 75);
            this.cell31.TabIndex = 1;
            this.cell31.Text = "2048";
            this.cell31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell12
            // 
            this.cell12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell12.Location = new System.Drawing.Point(180, 95);
            this.cell12.Name = "cell12";
            this.cell12.Size = new System.Drawing.Size(75, 75);
            this.cell12.TabIndex = 2;
            this.cell12.Text = "16";
            this.cell12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell21
            // 
            this.cell21.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell21.Location = new System.Drawing.Point(95, 180);
            this.cell21.Name = "cell21";
            this.cell21.Size = new System.Drawing.Size(75, 75);
            this.cell21.TabIndex = 1;
            this.cell21.Text = "128";
            this.cell21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell11
            // 
            this.cell11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell11.Location = new System.Drawing.Point(95, 95);
            this.cell11.Name = "cell11";
            this.cell11.Size = new System.Drawing.Size(75, 75);
            this.cell11.TabIndex = 1;
            this.cell11.Text = "8";
            this.cell11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell30
            // 
            this.cell30.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell30.Location = new System.Drawing.Point(10, 265);
            this.cell30.Name = "cell30";
            this.cell30.Size = new System.Drawing.Size(75, 75);
            this.cell30.TabIndex = 0;
            this.cell30.Text = "1024";
            this.cell30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell02
            // 
            this.cell02.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell02.Location = new System.Drawing.Point(180, 10);
            this.cell02.Name = "cell02";
            this.cell02.Size = new System.Drawing.Size(75, 75);
            this.cell02.TabIndex = 2;
            this.cell02.Text = "2";
            this.cell02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell20
            // 
            this.cell20.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell20.Location = new System.Drawing.Point(10, 180);
            this.cell20.Name = "cell20";
            this.cell20.Size = new System.Drawing.Size(75, 75);
            this.cell20.TabIndex = 0;
            this.cell20.Text = "64";
            this.cell20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell10
            // 
            this.cell10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell10.Location = new System.Drawing.Point(10, 95);
            this.cell10.Name = "cell10";
            this.cell10.Size = new System.Drawing.Size(75, 75);
            this.cell10.TabIndex = 0;
            this.cell10.Text = "0";
            this.cell10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell01
            // 
            this.cell01.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell01.Location = new System.Drawing.Point(95, 10);
            this.cell01.Name = "cell01";
            this.cell01.Size = new System.Drawing.Size(75, 75);
            this.cell01.TabIndex = 1;
            this.cell01.Text = "0";
            this.cell01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cell00
            // 
            this.cell00.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cell00.Location = new System.Drawing.Point(10, 10);
            this.cell00.Name = "cell00";
            this.cell00.Size = new System.Drawing.Size(75, 75);
            this.cell00.TabIndex = 0;
            this.cell00.Text = "0";
            this.cell00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSensor
            // 
            this.panelSensor.Location = new System.Drawing.Point(256, 27);
            this.panelSensor.Name = "panelSensor";
            this.panelSensor.Size = new System.Drawing.Size(118, 100);
            this.panelSensor.TabIndex = 2;
            this.panelSensor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSensor_MouseDown);
            this.panelSensor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSensor_MouseUp);
            // 
            // timerClock
            // 
            this.timerClock.Interval = 50;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // timerAnim
            // 
            this.timerAnim.Tick += new System.EventHandler(this.timerAnim_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(377, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topmostMenuItem,
            this.openFileMenuItem,
            this.saveFileMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // topmostMenuItem
            // 
            this.topmostMenuItem.CheckOnClick = true;
            this.topmostMenuItem.Name = "topmostMenuItem";
            this.topmostMenuItem.Size = new System.Drawing.Size(180, 22);
            this.topmostMenuItem.Text = "Topmost";
            this.topmostMenuItem.Click += new System.EventHandler(this.topmostMenuItem_Click);
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileMenuItem.Text = "Open";
            this.openFileMenuItem.Click += new System.EventHandler(this.openFileMenuItem_Click);
            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveFileMenuItem.Text = "Save";
            this.saveFileMenuItem.Click += new System.EventHandler(this.saveFileMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameMenuItem,
            this.undoGameMenuItem,
            this.animationGameMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 22);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameMenuItem
            // 
            this.newGameMenuItem.Name = "newGameMenuItem";
            this.newGameMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGameMenuItem.Text = "New game";
            this.newGameMenuItem.Click += new System.EventHandler(this.newGameMenuItem_Click);
            // 
            // undoGameMenuItem
            // 
            this.undoGameMenuItem.Name = "undoGameMenuItem";
            this.undoGameMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoGameMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoGameMenuItem.Text = "Undo";
            // 
            // animationGameMenuItem
            // 
            this.animationGameMenuItem.CheckOnClick = true;
            this.animationGameMenuItem.Name = "animationGameMenuItem";
            this.animationGameMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.animationGameMenuItem.Size = new System.Drawing.Size(180, 22);
            this.animationGameMenuItem.Text = "Animation";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.recordsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recordsToolStripMenuItem.Text = "Records";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Game2048
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(377, 512);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelSensor);
            this.Controls.Add(this.panelGameField);
            this.Controls.Add(this.panelDisplay);
            this.Name = "Game2048";
            this.Text = "Game2048";
            this.Load += new System.EventHandler(this.Game2048_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game2048_KeyDown);
            this.panelDisplay.ResumeLayout(false);
            this.panelDisplay.PerformLayout();
            this.panelGameField.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelDisplay;
        private Panel panelGameField;
        private Label cell23;
        private Label cell13;
        private Label cell03;
        private Label cell22;
        private Label cell12;
        private Label cell21;
        private Label cell11;
        private Label cell02;
        private Label cell20;
        private Label cell10;
        private Label cell01;
        private Label cell00;
        private Label cell33;
        private Label cell32;
        private Label cell31;
        private Label cell30;
        private Panel panelSensor;
        private Label labelTime;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Timer timerAnim;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem topmostMenuItem;
        private ToolStripMenuItem openFileMenuItem;
        private ToolStripMenuItem saveFileMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem newGameMenuItem;
        private ToolStripMenuItem undoGameMenuItem;
        private ToolStripMenuItem animationGameMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem rulesToolStripMenuItem;
        private ToolStripMenuItem recordsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}