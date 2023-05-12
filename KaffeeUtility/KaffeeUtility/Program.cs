using KaffeeUtility.Utils;
using System;
using System.Windows.Forms;

namespace KaffeeUtility
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(LogUnhandledException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Loader());
        }

        private static void LogUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            Logging.Log("Unhandled Exception occurred: " + ex.Message);
        }
    }
}
