using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace AutoHabitica
{
    internal static class FileHelper
    {
        /// <summary>
        /// The base folder of application data.
        /// </summary>
        readonly static string basePath =
            Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData) + "\\AutoHabitica";
        /// <summary>
        /// Path to credential
        /// </summary>
        readonly static string credentialPath = basePath + "\\credential.ah";
        readonly static string tasksPath = basePath + "\\tasks.ah";
        /// <summary>
        /// Must be called each time when you access the file system.
        /// </summary>
        private static void CheckBaseFolder()
        {
            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }
        }
        public static void SaveCredential(string id, string apiKey)
        {
            CheckBaseFolder();
            StreamWriter sw = new(credentialPath);
            sw.WriteLine(Convert.ToBase64String(
               Encoding.UTF8.GetBytes(id)));
            sw.WriteLine(Convert.ToBase64String(
               Encoding.UTF8.GetBytes(apiKey)));
            sw.Close();
        }
        public static string[]? GetCredential()
        {
            CheckBaseFolder();
            if (File.Exists(credentialPath))
            {
                StreamReader sr = new StreamReader(credentialPath);
                string id = sr.ReadLine();
                string apiKey = sr.ReadLine();
                id = Encoding.UTF8.GetString(
                    Convert.FromBase64String(id));
                apiKey = Encoding.UTF8.GetString(
                    Convert.FromBase64String(apiKey));
                sr.Close();
                return new string[] { id, apiKey };
            }
            return null;
        }
        /// <summary>
        /// Save task objects to the file system.
        /// </summary>
        /// <param name="tasks">The tasks to be saved</param>
        public static void SaveTasks(Task[] tasks)
        {
            CheckBaseFolder();
            string json = JsonSerializer.Serialize(tasks);
            StreamWriter sw = new StreamWriter(tasksPath);
            sw.Write(json);
            sw.Close();
        }
        /// <summary>
        /// Read tasks from file.
        /// </summary>
        /// <returns>The task list. Can be null if the file doesn't exist.</returns>
        public static Task[]? GetTasks()
        {
            CheckBaseFolder();
            if (File.Exists(tasksPath))
            {
                StreamReader sr = new StreamReader(tasksPath);
                string json = sr.ReadLine();
                sr.Close();
                return JsonSerializer.Deserialize<Task[]>(json);
            }
            return null;
        }
    }
}
