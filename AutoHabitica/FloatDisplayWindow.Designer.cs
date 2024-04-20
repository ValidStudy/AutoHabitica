namespace AutoHabitica
{
    partial class FloatDisplayWindow
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
            taskProgressBar = new ProgressBar();
            taskLabel = new Label();
            SuspendLayout();
            // 
            // taskProgressBar
            // 
            taskProgressBar.Location = new Point(61, 144);
            taskProgressBar.Name = "taskProgressBar";
            taskProgressBar.Size = new Size(176, 25);
            taskProgressBar.TabIndex = 0;
            taskProgressBar.MouseEnter += FloatDisplayWindow_MouseEnter;
            // 
            // taskLabel
            // 
            taskLabel.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            taskLabel.ForeColor = SystemColors.ActiveCaption;
            taskLabel.Location = new Point(32, 9);
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(235, 119);
            taskLabel.TabIndex = 1;
            taskLabel.Text = "Task:";
            taskLabel.TextAlign = ContentAlignment.MiddleCenter;
            taskLabel.MouseEnter += FloatDisplayWindow_MouseEnter;
            // 
            // FloatDisplayWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(300, 200);
            Controls.Add(taskLabel);
            Controls.Add(taskProgressBar);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FloatDisplayWindow";
            Opacity = 0.5D;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "FloatDisplayWindow";
            TopMost = true;
            MouseEnter += FloatDisplayWindow_MouseEnter;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar taskProgressBar;
        private Label taskLabel;
    }
}