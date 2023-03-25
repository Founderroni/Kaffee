using System.IO;

namespace KaffeeUtility.Utils
{
    internal class Minecraft
    {
        public static string GetMPUsername()
        {
            if (!File.Exists(Globals.OptionsFile))
                return "N/A";

            string[] lines = File.ReadAllLines(Globals.OptionsFile);
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("mp_username"))
                {
                    string[] parts = lines[i].Split(':');
                    return parts[1];
                }
            }

            return "N/A";
        }

        public static string GetCID()
        {
            if (!File.Exists(Globals.McpeDirectory + "clientId.txt"))
                return "N/A";

            return File.ReadAllLines(Globals.McpeDirectory + "clientId.txt")[0];
        }
    }
}
