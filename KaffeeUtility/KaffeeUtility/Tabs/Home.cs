using System.Windows.Forms;
using static KaffeeUtility.Utils.Config;

namespace KaffeeUtility.Tabs
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            Models.ConfigData Config = GetConfig();

            // Update Launcher Stats
            Launches.Text = Config.Launches.ToString();
            Version.Text = Globals.Version.ToString();

            // Update Spoof Stats
            CID.Text = Config.CidSpoofs.ToString();
            DID.Text = Config.DidSpoofs.ToString();
            MCID.Text = Config.McidSpoofs.ToString();

            // Update Inject Stats
            Injections.Text = Config.Injections.ToString();
            Failed.Text = Config.FailedInjections.ToString();
            InjectionDelay.Text = Config.InjectDelay.ToString();
        }
    }
}
