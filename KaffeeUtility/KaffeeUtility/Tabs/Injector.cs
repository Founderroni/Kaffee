using KaffeeUtility.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaffeeUtility.Tabs
{
    public partial class Injector : UserControl
    {
        public Injector() =>
            InitializeComponent();
        #region Functions
        private void UpdateVersionLabel(bool disableCheck = false) // Might remove
        {
            if (disableCheck)
            {
                Handlers.Animator.Linear(VersionSupport, "Text", "Supported Version: <b>Version Check Disabled</b>", 300);
                return;
            }
            foreach (ClientListStruct Instance in Globals.ClientList)
                if (Instance.displayName == ClientList.Text)
                {
                    Handlers.Animator.Linear(VersionSupport, "Text", $"Supported Version: <b>{Instance.versionSupported}</b>", 300);
                    break;
                }
        }
        #endregion

        private void Injector_Load(object sender, EventArgs e)
        {
            DisableVersionCheck.Checked = Utils.Config.GetConfig().DisableVersionCheck;
            Task.Run(() =>
            {
                foreach (ClientListStruct Instance in Globals.ClientList)
                {
                    ClientList.Items.Add(Instance.displayName);
                    Utils.Logging.Log("Added " + Instance.displayName + " to Client List");
                }
                ClientList.StartIndex = 0;
                InjectDelay.Value = Utils.Config.GetConfig().InjectDelay;
                ClientList.SelectedIndex = Utils.Config.GetConfig().ClientIndex;
            });
        }

        private void ClientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Utils.Config.GetConfig().ClientIndex = ClientList.SelectedIndex;
                UpdateVersionLabel(DisableVersionCheck.Checked);
            });
        }

        private void Inject_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Handlers.Injection.InjectClient(ClientList.Text, (int)InjectDelay.Value, DisableVersionCheck.Checked);
            });
        }

        private void InjectDelay_ValueChanged(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                Utils.Config.GetConfig().InjectDelay = (int)InjectDelay.Value;
            });
        }

        private void DisableVersionCheck_CheckedChanged(object sender, EventArgs e)
        {
            Utils.Config.GetConfig().DisableVersionCheck = DisableVersionCheck.Checked;
            UpdateVersionLabel(DisableVersionCheck.Checked);
        }
    }
}
