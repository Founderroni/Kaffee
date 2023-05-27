using Config.Net;
using KaffeeUtility.Models;
using System.IO;

namespace KaffeeUtility.Utils
{
    internal static class Config
    {
        public static ConfigData GetConfig()
        {
            try
            {
                return new ConfigurationBuilder<ConfigData>().UseJsonFile(Globals.ConfigFile).Build();
            } catch (IOException)
            {
                return null;
            }
        }
    }
}
