using KaffeeUtility.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaffeeUtility.Tabs
{
    public partial class Injector : UserControl
    {
        private static string FilePath;

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

        public Injector() =>
            InitializeComponent();

        private async void Injector_Load(object sender, EventArgs e)
        {
            DisableVersionCheck.Checked = Utils.Config.GetConfig().DisableVersionCheck;
            await Task.Run(() =>
            {
                foreach (ClientListStruct Instance in Globals.ClientList)
                {
                    ClientList.Items.Add(Instance.displayName);
                    Utils.Logging.Log("Added " + Instance.displayName + " to Client List");
                }
                ClientList.StartIndex = 0;
                InjectDelay.Value = Utils.Config.GetConfig().InjectDelay;
                ClientList.SelectedIndex = Utils.Config.GetConfig().ClientIndex;
                if (!string.IsNullOrEmpty(Utils.Config.GetConfig().CustomDllPath))
                {
                    DllPath.Text = $"Path: <b>{Utils.Config.GetConfig().CustomDllPath}</b>";
                    FilePath = Utils.Config.GetConfig().CustomDllPath;
                }
            });
        }

        private async void ClientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                Utils.Config.GetConfig().ClientIndex = ClientList.SelectedIndex;
                UpdateVersionLabel(DisableVersionCheck.Checked);
            });
        }

        private async void Inject_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                Handlers.Injection.InjectClient(ClientList.Text, (int)InjectDelay.Value, DisableVersionCheck.Checked);
            });
        }

        private void InjectDelay_ValueChanged(object sender, EventArgs e) =>
                Utils.Config.GetConfig().InjectDelay = (int)InjectDelay.Value;

        private async void DisableVersionCheck_CheckedChanged(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                Utils.Config.GetConfig().DisableVersionCheck = DisableVersionCheck.Checked;
                UpdateVersionLabel(DisableVersionCheck.Checked);
            });
        }

        private void SelectDll_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileIn = new OpenFileDialog();
            FileIn.Filter = "dll |*.dll";
            if (FileIn.ShowDialog() == DialogResult.OK)
            {
                if (FileIn.SafeFileName.ToLower().EndsWith(".dll"))
                {
                    FilePath = FileIn.FileName;
                    DllPath.Text = $"Path: <b>{FilePath}</b>";
                    Utils.Config.GetConfig().CustomDllPath = FilePath;
                }
                else
                {
                    Utils.Misc.Notify("You did not specify a DLL", "Custom DLL");
                }
            }
        }

        private async void InjectDll_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilePath)) return;

            await Task.Run(() =>
            {
                Handlers.Injection.InjectDLL(FilePath);
            });
        }
    }
}
