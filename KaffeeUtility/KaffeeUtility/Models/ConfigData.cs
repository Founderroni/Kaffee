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

        [Option(DefaultValue = true)]
        bool UseAnimations { get; set; }

        [Option(DefaultValue = true)]
        bool UseTulpepNotifications { get; set; }
        #endregion

        #region Stats
        [Option(DefaultValue = 0)]
        int Launches { get; set; }

        [Option(DefaultValue = 0)]
        int Injections { get; set; }

        [Option(DefaultValue = 0)]
        int Spoofs { get; set; }
        #endregion
    }
}
