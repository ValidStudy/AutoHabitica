namespace AutoHabitica
{
    internal static class Program
    {
        /// <summary>
        /// Global Api Helper. Won't be null after the MainWindow load.
        /// </summary>
        public static ApiHelper apiHelper;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            bool isLogin = false;
            if (args[0] =="login")
            {
                isLogin = true;
            }
            Application.Run(new MainWindow(isLogin));
        }
    }
}
