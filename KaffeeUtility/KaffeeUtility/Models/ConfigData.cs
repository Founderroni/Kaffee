using Config.Net;

namespace KaffeeUtility.Models
{
    public interface ConfigData
    {
        #region Application
        [Option(DefaultValue = true)]
        bool Logging { get; set; }

        [Option(DefaultValue = false)]
        bool FastLaunch { get; set; }

        [Option(DefaultValue = false)]
        bool SkipUpdateCheck { get; set; }

        [Option(DefaultValue = true)]
        bool UseAnimations { get; set; }
        #endregion

        #region Stats
        [Option(DefaultValue = 0)]
        int Launches { get; set; }

        [Option(DefaultValue = 0)]
        int Injections { get; set; }

        [Option(DefaultValue = 0)]
        int FailedInjections { get; set; }

        [Option(DefaultValue = 0)]
        int CidSpoofs { get; set; }

        [Option(DefaultValue = 0)]
        int DidSpoofs { get; set; }

        [Option(DefaultValue = 0)]
        int McidSpoofs { get; set; }
        #endregion

        #region Injector Settings
        [Option(DefaultValue = 0)]
        int InjectDelay { get; set; }

        [Option(DefaultValue = 10)]
        int LaunchDelay { get; set; }

        [Option(DefaultValue = 0)]
        int ClientIndex { get; set; }

        [Option(DefaultValue = "")]
        string CustomDllPath { get; set; }

        [Option(DefaultValue = false)]
        bool AutoOpenMc { get; set; }

        [Option(DefaultValue = false)]
        bool DisableVersionCheck { get; set; }
        #endregion

        #region Spoofer
        [Option(DefaultValue = "")]
        string CustomDid { get; set; }
        #endregion

        #region Discord
        [Option(DefaultValue = "")]
        string RpcDetail { get; set; }

        [Option(DefaultValue = "")]
        string RpcState { get; set; }

        [Option(DefaultValue = true)]
        bool RpcEnabled { get; set; }
        #endregion
    }
}
