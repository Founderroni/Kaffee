using Config.Net;

namespace KaffeeUtility.Models
{
    public interface ConfigData
    {
        #region Application
        [Option(DefaultValue = true)]
        bool Logging { get; set; }

        [Option(DefaultValue = true)]
        bool UseAnimations { get; set; }

        [Option(DefaultValue = true)]
        bool UseTulpepNotifications { get; set; }
        #endregion

        #region Home Tab
        [Option(DefaultValue = 0)]
        int Injections { get; set; }

        [Option(DefaultValue = 0)]
        int Spoofs { get; set; }

        [Option(DefaultValue = 0)]
        int Launches { get; set; }
        #endregion
    }
}
