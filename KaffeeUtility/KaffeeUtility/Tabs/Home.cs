using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KaffeeUtility.Utils.Config;

namespace KaffeeUtility.Tabs
{
    public partial class Home : UserControl
    {
        #region Variables
        private static readonly string animsTrue = "Animations: <b><span style=\"color:green;\">True</span></b>";
        private static readonly string animsFalse = "Animations: <b><span style=\"color:red;\">False</span></b>";
        private static readonly string fastlaunchFalse = "FastLaunch: <b><span style=\"color:red;\">False</span></b>";
        private static readonly string fastlaunchTrue = "FastLaunch: <b><span style=\"color:green;\">True</span></b>";
        private static readonly string loggingTrue = "Debug Logs: <b><span style=\"color:green;\">True</span></b>";
        private static readonly string loggingFalse = "Debug Logs: <b><span style=\"color:red;\">False</span></b>";
        #endregion

        #region Functions
        private void UpdateLabel(Guna.UI2.WinForms.Guna2HtmlLabel label, string text)
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
                UpdateLabel(Launches, $"Launches: <b>{GetConfig().Launches}</b>");
                UpdateLabel(Version, $"File Version: <b>{Globals.Version}</b>");
                UpdateLabel(Animations, GetConfig().UseAnimations ? animsTrue : animsFalse);
                UpdateLabel(FastLaunch, GetConfig().FastLaunch ? fastlaunchTrue : fastlaunchFalse);
                UpdateLabel(Logging, GetConfig().Logging ? loggingTrue : loggingFalse);

                // Update Inject Stats
                UpdateLabel(Injections, $"Injections: <b>{GetConfig().Injections}</b>");
                UpdateLabel(FailedInjects, $"Failed Injections: <b><span>{GetConfig().FailedInjections}</span></b>");
                UpdateLabel(InjectDelay, $"Inject Delay: <b><span>{GetConfig().InjectDelay}</span></b>");

                // Update Spoof Stats
                UpdateLabel(Spoofs, $"Spoofs: <b><span>{GetConfig().Spoofs}</span></b>");
                UpdateLabel(Username, $"MP_Username <b><span>{Utils.Minecraft.GetMPUsername()}</span></b>");
                UpdateLabel(CID, $"CID: <b><span>{Utils.Minecraft.GetCID()}</span></b>");
            });
        }
    }
}
