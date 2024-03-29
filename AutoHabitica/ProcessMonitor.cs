using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoHabitica
{
    internal static class ProcessMonitor
    {
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
