using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace AutoHabitica
{
    internal static class ProcessMonitor
    {
        public static FloatDisplayWindow displayWindow = new();
        /// <summary>
        /// Get the foreground window. From User32.dll.
        /// </summary>
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        /// <summary>
        /// Called every 5 seconds. 
        /// </summary>
        /// <param name="tasks"></param>
        public static void Check(Task[]? tasks)
        {
            if (tasks == null) return;
            bool isIdle = true;
            //Get foreground process
            Process[] processes = Process.GetProcesses();
            IntPtr intPtr = GetForegroundWindow();
            Process? currentProcess = null;
            foreach (Process process in processes)
            {
                if (process.MainWindowHandle == intPtr)
                {
                    currentProcess = process;
                    break;
                }
            }
            //Check title
            List<Task> list = tasks.ToList();
            if (currentProcess != null)
            {
                var enabled = from Task in list
                              where Task.Enabled == true
                              select Task;
                foreach (var task in enabled)
                {
                    if (!string.IsNullOrEmpty(task.TitleName))
                        if (currentProcess.MainWindowTitle.Contains(task.TitleName))
                        {
                            task.RunningTime += new TimeSpan(0, 0, 5);
                            if (task.RunningTime > task.TargetTime)
                            {
                                task.RunningTime = new TimeSpan(0, 0, 0);
                                Program.apiHelper.ScoreHabitAsync(task.id);
                                displayWindow.UpdateDisplay(
                                    "Completed " + task.text, task.RunningTime, task.TargetTime);
                            }
                            else
                            {
                                displayWindow.UpdateDisplay(
                                    task.text, task.RunningTime, task.TargetTime);
                            }
                            isIdle = false;
                        }
                }
            }

            if (isIdle)
            {
                displayWindow.UpdateDisplay("Not doing anything!",
                    new(0, 0, 0), new(0, 0, 1));//To make the progress bar 0%
            }
        }
    }
}
