using Config.Net;
using KaffeeUtility.Models;

namespace KaffeeUtility.Utils
{
    internal static class Config
    {
        public static ConfigData GetConfig() => new ConfigurationBuilder<ConfigData>().UseJsonFile(Globals.ConfigFile).Build();
    }
}
