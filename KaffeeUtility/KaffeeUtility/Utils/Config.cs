using Config.Net;
using KaffeeUtility.Models;
using System.IO;

namespace KaffeeUtility.Utils
{
    internal static class Config
    {
        public static readonly string AppConfigFile = Path.Combine(Globals.DataDir, "ApplicationConfig.json");
        public static readonly string StatsFile = Path.Combine(Globals.DataDir, "Statistics.json");
        public static readonly string InjectConfigFile = Path.Combine(Globals.DataDir, "InjectionConfig.json");
        public static readonly string SpooferConfigFile = Path.Combine(Globals.DataDir, "SpooferConfig.json");
        public static readonly string DiscordConfigFile = Path.Combine(Globals.DataDir, "DiscordConfig.json");

        public static ConfigData GetConfig()
        {
            try
            {
                if (Globals.CachedConfig == null)
                    return new ConfigurationBuilder<ConfigData>().UseJsonFile(Globals.ConfigFile).Build();
                else
                    return Globals.CachedConfig;
            } catch (IOException)
            {
                Logging.Log("IOException occured in GetConfig");
                return null;
            }
        }

        public static void ResetConfigs()
        {

        }
    }
}
