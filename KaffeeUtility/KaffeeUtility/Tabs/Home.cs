using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KaffeeUtility.Utils.Config;

namespace KaffeeUtility.Tabs
{
    public partial class Home : UserControl
    {
        #region Functions
        private void UpdateLabel(Label label, string text)
        {
            if (label.InvokeRequired)
                label.Invoke(new Action(() => label.Text = text));
            else
                label.Text = text;
        }
        #endregion

        public Home() =>
            InitializeComponent();

        private async void Home_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                // Update Launcher Stats
                UpdateLabel(Launches, GetConfig().Launches.ToString());
                UpdateLabel(Version, Globals.Version.ToString());

                // Update Spoof Stats
                UpdateLabel(CID, GetConfig().CidSpoofs.ToString());
                UpdateLabel(DID, GetConfig().DidSpoofs.ToString());
                UpdateLabel(MCID, GetConfig().McidSpoofs.ToString());

                // Update Inject Stats
                UpdateLabel(Injections, GetConfig().Injections.ToString());
                UpdateLabel(Failed, GetConfig().FailedInjections.ToString());
                UpdateLabel(InjectionDelay, GetConfig().InjectDelay.ToString());
            });
        }
    }
}
