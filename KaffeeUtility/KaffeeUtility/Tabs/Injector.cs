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

        private void UpdatePathLabel()
        {
            if (UseCustomDll.Checked)
            {
                DllPath.Text = $"Path: <b>{Utils.Config.GetConfig().CustomDllPath}</b>";
                VersionSupport.Text = $"Supported Version: <b>Using Custom DLL</b>";
            } else
            {
                foreach (ClientListStruct Instance in Globals.ClientList)
                    if (Instance.displayName == ClientList.Text)
                    {
                        Handlers.Animator.Linear(DllPath, "Text", $"Path: <b>{Globals.DataDir}\\{Instance.fileName}.dll</b>", 300);
                        break;
                    }
            }
        }
        #endregion

        public Injector() =>
            InitializeComponent();

        private async void Injector_Load(object sender, EventArgs e)
        {
            DisableVersionCheck.Checked = Utils.Config.GetConfig().DisableVersionCheck;
            UseCustomDll.Checked = Utils.Config.GetConfig().UseCustomDll;
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
                if (Utils.Config.GetConfig().UseCustomDll)
                {
                    ClientList.Enabled = false;
                    SelectDll.Enabled = true;
                } else
                {
                    ClientList.Enabled = true;
                    SelectDll.Enabled = false;
                }
                UpdatePathLabel();
            });
        }

        private void DllPath_OnMouseHover(object sender, EventArgs e)
        {
            PathToolTip.ToolTipTitle = "File Path";
            PathToolTip.SetToolTip(DllPath, DllPath.Text);
        }

        private async void ClientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                Utils.Config.GetConfig().ClientIndex = ClientList.SelectedIndex;
                UpdateVersionLabel(DisableVersionCheck.Checked);
                UpdatePathLabel();
            });
        }

        private async void Inject_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (!UseCustomDll.Checked)
                    Handlers.Injection.InjectClient(ClientList.Text, (int)InjectDelay.Value, DisableVersionCheck.Checked);
                else
                    Handlers.Injection.InjectDLL(FilePath);
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
                if (!UseCustomDll.Checked)
                    Handlers.Injection.InjectDLL(FilePath);
                else
                    Handlers.Injection.InjectDLL(FilePath);
            });
        }

        private void UseCustomDll_CheckedChanged(object sender, EventArgs e)
        {
            Utils.Config.GetConfig().UseCustomDll = UseCustomDll.Checked;
            if (UseCustomDll.Checked)
            {
                ClientList.Enabled = false;
                SelectDll.Enabled = true;
            }
            else
            {
                ClientList.Enabled = true;
                SelectDll.Enabled = false;
            }
            UpdateVersionLabel(DisableVersionCheck.Checked);
            UpdatePathLabel();
        }
    }
}
