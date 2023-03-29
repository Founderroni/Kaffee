using System;
using DiscordRPC;
using KaffeeUtility.Models;

namespace KaffeeUtility.Handlers
{
    internal class Discord
    {
        private static ConfigData Config = Utils.Config.GetConfig();

        private static DiscordRpcClient client;
        public static bool IsRPCRunning { get; private set; } = false;
        public static string DefaultDetail { get; private set; } = "Using Kaffee Utility";
        public static string DefaultState { get; private set; } = "Committing Large Amounts Of Trolling";

        public static void StartRpc(string detail, string state)
        {
            try
            {
                if (string.IsNullOrEmpty(detail)) detail = $"{DefaultDetail} v{Globals.Version}";
                if (string.IsNullOrEmpty(state)) state = DefaultState;

                if (!detail.Contains(DefaultDetail))
                    Config.RpcDetail = detail;
                if (!detail.Contains(DefaultState))
                    Config.RpcState = state;

                if (!IsRPCRunning)
                {
                    client = new DiscordRpcClient("1088980885409374208");
                    client.SetPresence(new RichPresence()
                    {
                        Details = detail,
                        State = state,
                        Assets = new Assets()
                        {
                            LargeImageKey = "https://i.imgur.com/j1oJ6om.png", //Don't go above 32 characters
                            LargeImageText = "Kaffee - Founder#2998",
                            SmallImageKey = "https://i.imgur.com/vOkR3H5.png"
                        }
                    });
                    client.Initialize();
                    Config.RpcEnabled = true;
                    IsRPCRunning = true;
                    Utils.Logging.Log("Started RPC");
                }
                else
                {
                    UpdateRpc(detail, state);
                }
            }
            catch (Exception e)
            {
                Utils.Misc.Notify("RPC Start Error", e.Message);
            }
        }

        public static void UpdateRpc(string detail, string state)
        {
            try
            {
                if (string.IsNullOrEmpty(detail)) detail = $"{DefaultDetail} v{Globals.Version}";
                if (string.IsNullOrEmpty(state)) state = DefaultState;

                if (!detail.Contains(DefaultDetail))
                    Config.RpcDetail = detail;
                if (!detail.Contains(DefaultState))
                    Config.RpcState = state;

                if (IsRPCRunning)
                {
                    client.UpdateDetails(detail);
                    client.UpdateState(state);
                    client.UpdateLargeAsset("https://i.imgur.com/j1oJ6om.png");
                    client.UpdateSmallAsset("https://i.imgur.com/vOkR3H5.png");
                    Utils.Logging.Log("Updated RPC");
                }
                else
                {
                    StartRpc(detail, state);
                }
            }
            catch (Exception e)
            {
                Utils.Misc.Notify("RPC Update Error", e.Message);
            }
        }

        public static void ClearRpc(bool disableRpcInConfig = true)
        {
            try
            {
                if (IsRPCRunning)
                    client.ClearPresence();
                if (disableRpcInConfig)
                {
                    Config.RpcEnabled = false;
                    IsRPCRunning = false;
                }
                Utils.Logging.Log("Cleared RPC");
            }
            catch (Exception e)
            {
                Utils.Misc.Notify("Clear RPC Error", e.Message);
            }
        }
    }
}
