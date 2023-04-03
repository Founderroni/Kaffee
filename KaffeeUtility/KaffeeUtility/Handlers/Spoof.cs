using System.IO;

namespace KaffeeUtility.Handlers
{
    internal class Spoof
    {
        public static void SpoofIds(string customDid, string didPtr, string mcidPtr)
        {
            if (!Directory.Exists(Globals.McpeDirectory))
                Utils.Misc.Notify("Minecraft Directory not found, are you using a custom launcher or not have the game installed?", "Spoofer");
            else
            {
                if (File.Exists(Globals.McpeDirectory + "clientId.txt"))
                {
                    File.WriteAllText(Globals.McpeDirectory + "clientId.txt", Utils.Misc.RandomString(19, false, true));
                    Utils.Logging.Log("Modified clientId file");
                }

                if (File.Exists(Globals.McpeDirectory + "telemetry_info.json"))
                {
                    File.Delete(Globals.McpeDirectory + "telemetry_info.json");
                    Utils.Logging.Log("Deleted telemetry_info file");
                }

                string[] lines = File.ReadAllLines(Globals.OptionsFile);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].StartsWith("mp_username"))
                    {
                        string[] parts = lines[i].Split(':');
                        parts[1] = Utils.Misc.RandomString(Utils.Misc.RandomInt(4, 10));
                        lines[i] = string.Join(":", parts);
                        Utils.Logging.Log("Replaced mp_username with " + parts[1]);
                    }
                    if (lines[i].StartsWith("last_xuid"))
                    {
                        string[] parts = lines[i].Split(':');
                        parts[1] = Utils.Misc.RandomString(16, false, true);
                        lines[i] = string.Join(":", parts);
                        Utils.Logging.Log("Replaced last_xuid with " + parts[1]);
                    }
                    if (lines[i].StartsWith("game_skintypefull"))
                    {
                        string[] parts = lines[i].Split(':');
                        parts[1] = Utils.Misc.RandomString(Utils.Misc.RandomInt(7, 50)).ToLower();
                        lines[i] = string.Join(":", parts);
                        Utils.Logging.Log("Replaced game_skintypefull with " + parts[1]);
                    }
                    if (lines[i].StartsWith("game_lastcustomskinnew"))
                    {
                        string[] parts = lines[i].Split(':');
                        parts[1] = Utils.Misc.RandomString(Utils.Misc.RandomInt(20, 100)).ToLower();
                        lines[i] = string.Join(":", parts);
                        Utils.Logging.Log("Replaced game_lastcustomskinnew with " + parts[1]);
                    }
                    if (lines[i].StartsWith("last_minecraft_id"))
                    {
                        string[] parts = lines[i].Split(':');
                        parts[1] = Utils.Misc.RandomString();
                        lines[i] = string.Join(":", parts);
                        Utils.Logging.Log("Replaced last_minecraft_id with " + parts[1]);
                        break;
                    }
                }
                File.WriteAllLines(Globals.OptionsFile, lines);
            }

            if (didPtr  != "null")
            {
                long addr = Memory.GetMultiLevelPtr(Memory.GetOffset(didPtr), Memory.GetSubOffsets(didPtr));
                Memory.WriteMemory_str(addr, customDid, false);
            }
            if (mcidPtr != "null")
            {
                long addr = Memory.GetMultiLevelPtr(Memory.GetOffset(mcidPtr), Memory.GetSubOffsets(mcidPtr));
                Memory.WriteMemory_str(addr, Utils.Misc.RandomString(16, true, true).ToUpper(), false);
            }
        }
    }
}
