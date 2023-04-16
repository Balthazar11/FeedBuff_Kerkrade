namespace FeedBuff_Kerkrade
{
    internal static class Program
    {
        internal static HomePage HomePage;
        internal static Login Login;
        public static string CurrentUser { get; set; }
        public static int CurrentUser_ID { get; set; }
        public static string CurrentUser_Role { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}