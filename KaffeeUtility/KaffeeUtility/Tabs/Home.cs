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

        public Home() =>
            InitializeComponent();

        private void Home_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                #region Launcher Stats
                Launches.Text = $"Launches: <b>{GetConfig().Launches}</b>";
                Version.Text = $"File Version: <b>{Globals.Version}</b>";
                Animations.Text = GetConfig().UseAnimations ? animsTrue : animsFalse;
                FastLaunch.Text = GetConfig().FastLaunch ? fastlaunchTrue : fastlaunchFalse;
                Logging.Text = GetConfig().Logging ? loggingTrue : loggingFalse;
                #endregion

                #region Inject Stats
                Injections.Text = $"Injections: <b>{GetConfig().Injections}</b>";
                InjectDelay.Text = $"Inject Delay: <b><span>{GetConfig().InjectDelay}</span></b>";
                #endregion
            });
        }
    }
}
