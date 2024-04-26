namespace AutoHabitica
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            fetchButton = new Button();
            tasksListBox = new CheckedListBox();
            label1 = new Label();
            timeNumericUpDown = new NumericUpDown();
            label2 = new Label();
            appTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            saveButton = new Button();
            notifyIcon = new NotifyIcon(components);
            iconContextMenuStrip = new ContextMenuStrip(components);
            exitToolStripMenuItem = new ToolStripMenuItem();
            processTimer = new System.Windows.Forms.Timer(components);
            refreshButton = new Button();
            addBootButton = new Button();
            toggleDisplayToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)timeNumericUpDown).BeginInit();
            iconContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // fetchButton
            // 
            fetchButton.Location = new Point(12, 12);
            fetchButton.Name = "fetchButton";
            fetchButton.Size = new Size(133, 64);
            fetchButton.TabIndex = 0;
            fetchButton.Text = "Fetch my tasks";
            fetchButton.UseVisualStyleBackColor = true;
            fetchButton.Click += FetchButton_Click;
            // 
            // tasksListBox
            // 
            tasksListBox.FormattingEnabled = true;
            tasksListBox.HorizontalScrollbar = true;
            tasksListBox.Location = new Point(12, 82);
            tasksListBox.Name = "tasksListBox";
            tasksListBox.Size = new Size(350, 364);
            tasksListBox.TabIndex = 2;
            tasksListBox.ItemCheck += TasksListBox_ItemCheck;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 12);
            label1.Name = "label1";
            label1.Size = new Size(284, 51);
            label1.TabIndex = 3;
            label1.Text = "Click on one of your task and then edit its time.\r\nOnly ticked items will take effect.\r\nMinimize the form to hide the Window to tray.";
            // 
            // timeNumericUpDown
            // 
            timeNumericUpDown.Location = new Point(577, 161);
            timeNumericUpDown.Maximum = new decimal(new int[] { 180, 0, 0, 0 });
            timeNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            timeNumericUpDown.Name = "timeNumericUpDown";
            timeNumericUpDown.Size = new Size(129, 23);
            timeNumericUpDown.TabIndex = 4;
            timeNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 163);
            label2.Name = "label2";
            label2.Size = new Size(107, 17);
            label2.TabIndex = 5;
            label2.Text = "Every x minutes...";
            // 
            // appTextBox
            // 
            appTextBox.Location = new Point(577, 190);
            appTextBox.Name = "appTextBox";
            appTextBox.Size = new Size(129, 23);
            appTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 196);
            label3.Name = "label3";
            label3.Size = new Size(164, 17);
            label3.TabIndex = 7;
            label3.Text = "And using app with y title...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 226);
            label4.Name = "label4";
            label4.Size = new Size(242, 17);
            label4.TabIndex = 8;
            label4.Text = "Then automatically score the habit/daily.";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(464, 261);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(242, 77);
            saveButton.TabIndex = 9;
            saveButton.Text = "Save setting for this task";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += SaveButton_Click;
            // 
            // notifyIcon
            // 
            notifyIcon.ContextMenuStrip = iconContextMenuStrip;
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "AutoHabitica";
            notifyIcon.Visible = true;
            notifyIcon.DoubleClick += NotifyIcon_DoubleClick;
            // 
            // iconContextMenuStrip
            // 
            iconContextMenuStrip.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem, toggleDisplayToolStripMenuItem });
            iconContextMenuStrip.Name = "contextMenuStrip1";
            iconContextMenuStrip.Size = new Size(181, 70);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // processTimer
            // 
            processTimer.Interval = 5000;
            processTimer.Tick += ProcessTimer_Tick;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(464, 344);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(242, 78);
            refreshButton.TabIndex = 10;
            refreshButton.Text = "Refresh List Box";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += RefreshButton_Click;
            // 
            // addBootButton
            // 
            addBootButton.Location = new Point(633, 4);
            addBootButton.Name = "addBootButton";
            addBootButton.Size = new Size(155, 59);
            addBootButton.TabIndex = 11;
            addBootButton.Text = "Boot when login";
            addBootButton.UseVisualStyleBackColor = true;
            addBootButton.Click += AddBootButton_Click;
            // 
            // toggleDisplayToolStripMenuItem
            // 
            toggleDisplayToolStripMenuItem.Name = "toggleDisplayToolStripMenuItem";
            toggleDisplayToolStripMenuItem.Size = new Size(180, 22);
            toggleDisplayToolStripMenuItem.Text = "Toggle Display";
            toggleDisplayToolStripMenuItem.Click += ToggleDisplayToolStripMenuItem_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addBootButton);
            Controls.Add(refreshButton);
            Controls.Add(saveButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(appTextBox);
            Controls.Add(label2);
            Controls.Add(timeNumericUpDown);
            Controls.Add(label1);
            Controls.Add(tasksListBox);
            Controls.Add(fetchButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "AutoHabitica";
            Deactivate += MainWindow_Deactivate;
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            Shown += MainWindow_Shown;
            ((System.ComponentModel.ISupportInitialize)timeNumericUpDown).EndInit();
            iconContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button fetchButton;
        private CheckedListBox tasksListBox;
        private Label label1;
        private NumericUpDown timeNumericUpDown;
        private Label label2;
        private TextBox appTextBox;
        private Label label3;
        private Label label4;
        private Button saveButton;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip iconContextMenuStrip;
        private ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer processTimer;
        private Button refreshButton;
        private Button addBootButton;
        private ToolStripMenuItem toggleDisplayToolStripMenuItem;
    }
}