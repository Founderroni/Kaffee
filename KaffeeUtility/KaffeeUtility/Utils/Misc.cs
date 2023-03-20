using System.Diagnostics;
using System.Windows.Forms;

namespace KaffeeUtility.Utils
{
    internal class Misc
    {
        public static void OpenProcess(string process, string args = null) =>
            Process.Start(process, args);

        public static void Notify(string msg, string title = "Kaffee Utility") =>
            MessageBox.Show(msg, title);
    }
}
