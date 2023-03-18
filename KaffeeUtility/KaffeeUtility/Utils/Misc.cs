using System.Diagnostics;

namespace KaffeeUtility.Utils
{
    internal class Misc
    {
        public static void OpenProcess(string process, string args = null) =>
            Process.Start(process, args);
    }
}
