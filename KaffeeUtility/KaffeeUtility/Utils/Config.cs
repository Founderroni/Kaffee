using Config.Net;
using KaffeeUtility.Models;
using System.IO;

namespace KaffeeUtility.Utils
{
    internal static class Config
    {
        public static readonly string AppConfigFile = Path.Combine(Globals.DataDir, "AppConfig.json");
        public static readonly string StatsFile = Path.Combine(Globals.DataDir, "Stats.json");

        public static ConfigData GetConfig()
        {
            try
            {
                return new ConfigurationBuilder<ConfigData>().UseJsonFile(Globals.ConfigFile).Build();
            } catch (IOException)
            {
                Logging.Log("IOException occured in GetConfig");
                return null;
            }
        }

        public static AppConfig GetAppConfig()
        {
            try
            {
                return new ConfigurationBuilder<AppConfig>().UseJsonFile(AppConfigFile).Build();
            }
            catch (IOException)
            {
                Logging.Log("IOException occured in GetAppConfig");
                return null;
            }
        }

        public static Stats GetStats()
        {
            try
            {
                return new ConfigurationBuilder<Stats>().UseJsonFile(StatsFile).Build();
            }
            catch (IOException)
            {
                Logging.Log("IOException occured in GetStats");
                return null;
            }
        }
    }
}
