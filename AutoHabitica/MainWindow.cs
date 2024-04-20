using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoHabitica
{
    public partial class MainWindow : Form
    {
        Task[]? tasks;
        bool isLogin;
        public MainWindow(bool isLogin)
        {
            InitializeComponent();
            //Save login state
            this.isLogin = isLogin;
            //Initialize credential and api.
            string[]? credential = FileHelper.GetCredential();
            //0 for userId, 1 for apiKey
            if (credential == null)
            {
                credential = new string[2] { "", "" };//Initialize
                PasswordWindow passwordWindow = new PasswordWindow();
                while (passwordWindow.ShowDialog() != DialogResult.OK)
                {
                    //Do nothing.
                }
                credential[0] = passwordWindow.userId;
                credential[1] = passwordWindow.apiKey;
            }
            Program.apiHelper = new(credential[0], credential[1]);
            //Load tasks
            tasks = FileHelper.GetTasks();
            //Add trigger for data save.
            SystemEvents.SessionEnding += SystemEvents_SessionEnding;
            processTimer.Start();
            //Refresh Form
            RefreshForm();
            ProcessMonitor.displayWindow.Show();
        }
        /// <summary>
        /// Save data and close form when the user log out.
        /// </summary>
        private void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            SaveSettings();
            //Release events.
            SystemEvents.SessionEnding -= SystemEvents_SessionEnding;
            Close();
        }
        #region Form
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //FetchButton_Click(sender, e);
        }
        private void MainWindow_Deactivate(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }
        private void RefreshForm()
        {
            tasksListBox.Items.Clear();
            if(tasks!=null)
            foreach (var task in tasks)
            {
                tasksListBox.Items.Add(task, task.Enabled);
            }
        }
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }
        private void MainWindow_Shown(object sender, EventArgs e)
        {
            if (isLogin)
            {
                Hide();
            }
        }
        #endregion
        #region Buttons
        private async void FetchButton_Click(object sender, EventArgs e)
        {
            fetchButton.Enabled = false;
            string? json = await Program.apiHelper.GetTasksAsync();
            ApiObject? apiObject = null;
            if (json != null)
            {
                apiObject = JsonSerializer.Deserialize<ApiObject>
                (json);
            }
            if (apiObject != null && apiObject.success)
            {
                tasks = apiObject.data;
                RefreshForm();
            }
            fetchButton.Enabled = true;
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (tasksListBox.SelectedIndex >= 0)
            {
                tasks[tasksListBox.SelectedIndex].TitleName = appTextBox.Text;
                tasks[tasksListBox.SelectedIndex].TargetTime =
                    new TimeSpan(0, (int)timeNumericUpDown.Value, 0);
            }
            SaveSettings();
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }
        #endregion
        private void SaveSettings()
        {
            if (tasks != null)
            {
                FileHelper.SaveTasks(tasks);
            }
        }
        private void ProcessTimer_Tick(object sender, EventArgs e)
        {
            ProcessMonitor.Check(tasks);
        }

        private void TasksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TasksListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            tasks[e.Index].Enabled = (e.NewValue == CheckState.Checked);
            SaveSettings();
        }

        private void AddBootButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Environment.CurrentDirectory + "\\BootHelper.exe");
        }

    }
}
