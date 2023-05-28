using System.Reflection;
using System;
using System.Collections.Generic;
using KaffeeUtility.Models;
using System.IO;

namespace KaffeeUtility
{
    public static class Globals
    {
        public static readonly float Version = 0.5F;
        public static string LatestVersion = "0"; // This should change
        public readonly static string McpeDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), @"Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang\minecraftpe\");
        public static string OptionsFile = Path.Combine(McpeDirectory, "options.txt");
        public static string RootDataDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FadedSolutions");
        public static readonly string DataDir = Path.Combine(RootDataDir, "Kaffee");
        public static readonly string AppDir = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string AppPath = Assembly.GetExecutingAssembly().Location;
        public static readonly string LogFile = Path.Combine(DataDir, "Log.txt");
        public static readonly string ConfigFile = Path.Combine(DataDir, "Config.json");

        public static List<ClientListStruct> ClientList = new List<ClientListStruct>();
        public static List<SpoofPointersStruct> SpoofList = new List<SpoofPointersStruct>();
    }
}
