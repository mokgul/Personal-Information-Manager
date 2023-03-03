namespace Personal_Information
{
    internal static class StartUp
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            AccessInformation information = new AccessInformation();
            information.Credentials.Add(new Credential("fb:", "pencho","123"));
            information.Credentials.Add(new Credential("fb:", "pencho2","123"));
            information.Credentials.Add(new Credential("fb:", "pencho3","123"));
            information.Credentials.Add(new Credential("fb:", "pencho4","123"));
            information.Credentials.Add(new Credential("fb:", "pencho5","123"));
            Application.Run(new ManagerWindow(information));


        }
    }
}