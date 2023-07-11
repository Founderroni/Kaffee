using System.IO;
using static KaffeeUtility.Globals;

namespace KaffeeUtility.Utils
{
    internal class Minecraft
    { // https://github.com/Founderroni/FoundersMinecraftUtils
        public static string GetOptionValue(string key)
        {
            if (!File.Exists(OptionsFile))
                return "N/A";

            string[] lines = File.ReadAllLines(OptionsFile);
            foreach (string line in lines)
            {
                if (line.StartsWith(key))
                {
                    string[] parts = line.Split(':');
                    return parts.Length > 1 ? parts[1] : "N/A";
                }
            }

            return "N/A";
        }

        public static string GetValueFromFile(string fileName, int line = 0)
        {
            string filePath = Path.Combine(McpeDirectory, fileName);

            if (!File.Exists(filePath))
                return "N/A";

            string[] lines = File.ReadAllLines(filePath);
            return lines.Length > line ? lines[line] : "N/A";
        }

        public static string GetMPUsername() => GetOptionValue("mp_username");

        public static string GetCID() => GetValueFromFile("clientId.txt");

        public static string GetDID() => GetValueFromFile("hs", 1);
    }
}
