﻿using System.Reflection;
using System;
using System.Collections.Generic;
using KaffeeUtility.Models;

namespace KaffeeUtility
{
    public class Globals
    {
        public static readonly float Version = 0.4F;
        public readonly static string McpeDirectory = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Packages\Microsoft.MinecraftUWP_8wekyb3d8bbwe\LocalState\games\com.mojang\minecraftpe\";
        public static string RootDataDir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FadedSolutions";
        public static readonly string DataDir = RootDataDir + "\\Kaffee";
        public static readonly string AppDir = AppDomain.CurrentDomain.BaseDirectory;
        public static readonly string AppPath = Assembly.GetExecutingAssembly().Location;
        public static readonly string LogFile = $"{DataDir}\\Log.txt";
        public static readonly string ConfigFile = $"{DataDir}\\Config.json";
        public static string OptionsFile = McpeDirectory + "options.txt";

        public static List<ClientListStruct> ClientList = new List<ClientListStruct>();
        public static List<SpoofPointersStruct> SpoofList = new List<SpoofPointersStruct>();
    }
}
