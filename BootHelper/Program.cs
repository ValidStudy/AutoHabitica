using Microsoft.Win32;

namespace BootHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adding registry...");
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(
                "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            registryKey.SetValue("AutoHabitica", "\""
                + AppDomain.CurrentDomain.SetupInformation.ApplicationBase
                + "\\AutoHabitica.exe\" login");

            registryKey.Close();
            Console.WriteLine("Added.");
            Console.ReadKey();
        }
    }
}
