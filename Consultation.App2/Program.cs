using Consultation.App2;
using LoginForm;
namespace Consultation.App2
{
    internal static class Program
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
            LogIn login = new LogIn();
            Application.Run(login);
        }
    }
}