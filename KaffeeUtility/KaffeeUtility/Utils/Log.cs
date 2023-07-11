using KaffeeUtility.Models;
using System;
using System.IO;
using static KaffeeUtility.Globals;

namespace KaffeeUtility.Utils
{
    internal static class Logging
    {
        public static void Log(string message, LogAction action = LogAction.Write)
        {
            try
            {
                if (!File.Exists(LogFile)) return;
                if (!Config.GetConfig().Logging) return;

                if (action == LogAction.Write)
                    File.AppendAllText(LogFile, $"[Kaffee @ {DateTime.Now}]: {message}\n");
                if (action == LogAction.Clear)
                    File.WriteAllText(LogFile, $"[Kaffee @ {DateTime.Now}]: **Log Cleared**\n");
            } catch (Exception) { }
        }

        public static void Clear()
        {
            try
            {
                if (!Directory.Exists(RootDataDir)) return;
                if (!File.Exists(LogFile)) return;
                if (!Config.GetConfig().Logging) return;

                File.WriteAllText(LogFile, $"[Kaffee @ {DateTime.Now}]: **Log Cleared**\n");
            }
            catch (Exception e)
            {
                Misc.Notify(e.Message, "Logging Error");
            }
        }
    }
}
