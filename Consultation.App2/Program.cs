using Consultation.App2;
using Consultation.App2.View;

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
            ReadStudents readStudents = new ReadStudents();
            Application.Run(readStudents);
        }
    }
}