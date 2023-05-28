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
                return new ConfigurationBuilder<ConfigData>().UseJsonFile(Globals.ConfigFile).Build();
            } catch (IOException)
            {
                Logging.Log("IOException occured in GetConfig");
                return null;
            }
        }

        public static void ResetConfig()
        {

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

        public static InjectConfig GetInjectConfig()
        {
            try
            {
                return new ConfigurationBuilder<InjectConfig>().UseJsonFile(InjectConfigFile).Build();
            }
            catch (IOException)
            {
                Logging.Log("IOException occured in GetInjectConfig");
                return null;
            }
        }

        public static SpooferConfig GetSpooferConfig()
        {
            try
            {
                return new ConfigurationBuilder<SpooferConfig>().UseJsonFile(SpooferConfigFile).Build();
            }
            catch (IOException)
            {
                Logging.Log("IOException occured in GetSpooferConfig");
                return null;
            }
        }

        public static DiscordConfig GetDiscordConfig()
        {
            try
            {
                return new ConfigurationBuilder<DiscordConfig>().UseJsonFile(DiscordConfigFile).Build();
            }
            catch (IOException)
            {
                Logging.Log("IOException occured in GetDiscordConfig");
                return null;
            }
        }
    }
}
