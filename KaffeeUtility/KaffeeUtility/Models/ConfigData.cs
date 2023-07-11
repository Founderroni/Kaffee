using Config.Net;

namespace KaffeeUtility.Models
{
    public interface ConfigData
    {
        #region Application
        [Option(DefaultValue = "null")]
        string RootDirectory { get; set; }

        [Option(DefaultValue = true)]
        bool Logging { get; set; }

        [Option(DefaultValue = false)]
        bool FastLaunch { get; set; }

        [Option(DefaultValue = false)]
        bool SkipUpdateCheck { get; set; }

        [Option(DefaultValue = true)]
        bool UseAnimations { get; set; }

        [Option(DefaultValue = false)]
        bool GithubBlocked { get; set; }

        [Option(DefaultValue = false)]
        bool DownloadInParallel { get; set; }

        [Option(DefaultValue = true)]
        bool ShowAds { get; set; }
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

        [Option(DefaultValue = false)]
        bool UseCustomDll { get; set; }

        [Option(DefaultValue = true)]
        bool KillAllInstances { get; set; }

        [Option(DefaultValue = true)]
        bool InjectToAll { get; set; }
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

    public interface AppConfig
    {
        [Option(DefaultValue = "null")]
        string RootDirectory { get; set; }

        [Option(DefaultValue = true)]
        bool Logging { get; set; }

        [Option(DefaultValue = false)]
        bool FastLaunch { get; set; }

        [Option(DefaultValue = false)]
        bool SkipUpdateCheck { get; set; }

        [Option(DefaultValue = true)]
        bool UseAnimations { get; set; }

        [Option(DefaultValue = false)]
        bool GithubBlocked { get; set; }

        [Option(DefaultValue = true)]
        bool DownloadInParallel { get; set; }
    }

    public interface Stats
    {
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
    }

    public interface InjectConfig
    {
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

        [Option(DefaultValue = false)]
        bool UseCustomDll { get; set; }

        [Option(DefaultValue = true)]
        bool KillAllInstances { get; set; }

        [Option(DefaultValue = true)]
        bool InjectToAll { get; set; }
    }

    public interface SpooferConfig
    {
        [Option(DefaultValue = "")]
        string CustomDid { get; set; }
    }

    public interface DiscordConfig
    {
        [Option(DefaultValue = "")]
        string RpcDetail { get; set; }

        [Option(DefaultValue = "")]
        string RpcState { get; set; }

        [Option(DefaultValue = true)]
        bool RpcEnabled { get; set; }
    }
}
