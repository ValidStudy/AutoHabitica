namespace AutoHabitica
{
    partial class PasswordWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordWindow));
            label1 = new Label();
            habiticaLinkLabel = new LinkLabel();
            userIdTextBox = new TextBox();
            apiKeyTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            okButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(63, 42);
            label1.Name = "label1";
            label1.Size = new Size(442, 27);
            label1.TabIndex = 0;
            label1.Text = "Please enter your habitica id and ApiKey first.";
            // 
            // habiticaLinkLabel
            // 
            habiticaLinkLabel.AutoSize = true;
            habiticaLinkLabel.Location = new Point(363, 83);
            habiticaLinkLabel.Name = "habiticaLinkLabel";
            habiticaLinkLabel.Size = new Size(142, 17);
            habiticaLinkLabel.TabIndex = 1;
            habiticaLinkLabel.TabStop = true;
            habiticaLinkLabel.Text = "Get them from habitica";
            habiticaLinkLabel.LinkClicked += HabiticaLinkLabel_LinkClicked;
            // 
            // userIdTextBox
            // 
            userIdTextBox.Location = new Point(98, 145);
            userIdTextBox.Name = "userIdTextBox";
            userIdTextBox.Size = new Size(375, 23);
            userIdTextBox.TabIndex = 2;
            // 
            // apiKeyTextBox
            // 
            apiKeyTextBox.Location = new Point(98, 194);
            apiKeyTextBox.Name = "apiKeyTextBox";
            apiKeyTextBox.PasswordChar = '*';
            apiKeyTextBox.Size = new Size(375, 23);
            apiKeyTextBox.TabIndex = 3;
            apiKeyTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 148);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 4;
            label2.Text = "User ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 197);
            label3.Name = "label3";
            label3.Size = new Size(52, 17);
            label3.TabIndex = 5;
            label3.Text = "Api Key";
            // 
            // okButton
            // 
            okButton.Location = new Point(239, 233);
            okButton.Name = "okButton";
            okButton.Size = new Size(95, 34);
            okButton.TabIndex = 6;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += OkButton_Click;
            // 
            // PasswordWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 281);
            Controls.Add(okButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(apiKeyTextBox);
            Controls.Add(userIdTextBox);
            Controls.Add(habiticaLinkLabel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PasswordWindow";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "PasswordWindow";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel habiticaLinkLabel;
        private TextBox userIdTextBox;
        private TextBox apiKeyTextBox;
        private Label label2;
        private Label label3;
        private Button okButton;
    }
}