using System.Reflection;
using System;
using System.Collections.Generic;
using KaffeeUtility.Models;

namespace KaffeeUtility
{
    public class Globals
    {
        public static readonly float Version = 0.2F;
        public readonly static string McpeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang\minecraftpe\";
        public static readonly string RootDataDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FadedSolutions";
        public static readonly string DataDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FadedSolutions\Kaffee";
        public static readonly string AppDir = Assembly.GetExecutingAssembly().Location;
        public static readonly string LogFile = $@"{DataDir}\Log.txt";
        public static readonly string ConfigFile = $@"{DataDir}\Config.json";
        public static string OptionsFile = McpeDirectory + "options.txt";

        public static List<ClientListStruct> ClientList = new List<ClientListStruct>();
        public static List<SpoofPointersStruct> SpoofList = new List<SpoofPointersStruct>();
    }
}
