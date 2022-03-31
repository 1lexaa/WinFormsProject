namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonDemo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.GetNotifications = new System.Windows.Forms.Label();
            this.Notifications = new System.Windows.Forms.CheckBox();
            this.Input = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ListBoxDemo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe Print", 25.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(26, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(731, 62);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Знамоство с элементами управления";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кнопка(Button):";
            // 
            // ButtonDemo
            // 
            this.ButtonDemo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonDemo.Location = new System.Drawing.Point(148, 89);
            this.ButtonDemo.Name = "ButtonDemo";
            this.ButtonDemo.Size = new System.Drawing.Size(75, 23);
            this.ButtonDemo.TabIndex = 4;
            this.ButtonDemo.Text = "Нажать";
            this.ButtonDemo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Метка (label)";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text.Location = new System.Drawing.Point(129, 145);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(127, 20);
            this.text.TabIndex = 6;
            this.text.Text = "Текст(textbox)";
            // 
            // GetNotifications
            // 
            this.GetNotifications.AutoSize = true;
            this.GetNotifications.Location = new System.Drawing.Point(26, 207);
            this.GetNotifications.Name = "GetNotifications";
            this.GetNotifications.Size = new System.Drawing.Size(41, 15);
            this.GetNotifications.TabIndex = 7;
            this.GetNotifications.Text = "Метка";
            // 
            // Notifications
            // 
            this.Notifications.AutoSize = true;
            this.Notifications.Location = new System.Drawing.Point(97, 203);
            this.Notifications.Name = "Notifications";
            this.Notifications.Size = new System.Drawing.Size(72, 19);
            this.Notifications.TabIndex = 8;
            this.Notifications.Text = "Чекбокс";
            this.Notifications.UseVisualStyleBackColor = true;
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(32, 276);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(35, 15);
            this.Input.TabIndex = 10;
            this.Input.Text = "Input";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 273);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 23);
            this.textBox1.TabIndex = 11;
            // 
            // ListBoxDemo
            // 
            this.ListBoxDemo.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListBoxDemo.FormattingEnabled = true;
            this.ListBoxDemo.ItemHeight = 20;
            this.ListBoxDemo.Location = new System.Drawing.Point(363, 74);
            this.ListBoxDemo.Name = "ListBoxDemo";
            this.ListBoxDemo.Size = new System.Drawing.Size(371, 364);
            this.ListBoxDemo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBoxDemo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Notifications);
            this.Controls.Add(this.GetNotifications);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonDemo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private Label label1;
        private Button ButtonDemo;
        private Label label2;
        private Label text;
        private Label GetNotifications;
        private CheckBox Notifications;
        private Label Input;
        private TextBox textBox1;
        private ListBox ListBoxDemo;
    }
}