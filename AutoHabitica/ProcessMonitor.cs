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
            if(tasks==null) return;
            foreach (Task task in tasks)
            {
                if (task.Enabled)
                {
                    Process[] processes = Process.GetProcessesByName(task.ProcessName);
                    if (processes.Length > 0)
                    {
                        bool isForegroundWindow=false;
                        //Check handle.
                        foreach (Process process in processes)
                        {
                            if(GetForegroundWindow()==process.MainWindowHandle)
                            {
                                isForegroundWindow = true;
                            }
                        }
                        //Add time.
                        if (isForegroundWindow)
                        {
                            task.RunningTime += new TimeSpan(0, 0, 5);
                            if (task.RunningTime > task.TargetTime)
                            {
                                task.RunningTime = new TimeSpan(0, 0, 0);
                                Program.apiHelper.ScoreHabitAsync(task.id);
                            }
                        }
                    }
                }
            }
        }
    }
}
