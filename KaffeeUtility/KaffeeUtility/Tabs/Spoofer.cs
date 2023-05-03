using KaffeeUtility.Handlers;
using KaffeeUtility.Models;
using KaffeeUtility.Utils;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaffeeUtility.Tabs
{
    public partial class Spoofer : UserControl
    {
        #region Variables
        private string DidText = "";
        private string SupportedSpoofTypes = "CID";
        #endregion

        #region Functions
        private void UpdatePlayerInfo()
        {
            try
            {
                SupportedSpoofTypes = "CID";

                Username.Text = $"MP_Username: <b>{Minecraft.GetMPUsername()}</b>";
                CID.Text = $"CID: <b>{Minecraft.GetCID()}</b>";

                Memory.CheckInject();
                MCVersion.Text = $"MC Version: <b>{Memory.GetVersion()}</b>";
                foreach (SpoofPointersStruct Instance in Globals.SpoofList)
                {
                    if (Memory.GetVersion().StartsWith(Instance.version))
                    {
                        Logging.Log($@"Version matches ({Instance.version})");
                        if (Instance.didPtr != "null")
                        {
                            SupportedSpoofTypes += ", DID";

                            long addr = Memory.GetMultiLevelPtr(Memory.GetOffset(Instance.didPtr), Memory.GetSubOffsets(Instance.didPtr));
                            string DidString = Memory.ReadMemory_str(addr, false);
                            DID.Text = $"DID: <b>{DidString}</b>";
                        }
                        if (Instance.mcidPtr != "null")
                        {
                            SupportedSpoofTypes += ", MCID";

                            long addr = Memory.GetMultiLevelPtr(Memory.GetOffset(Instance.mcidPtr), Memory.GetSubOffsets(Instance.mcidPtr));
                            string McidString = Memory.ReadMemory_str(addr, false);
                            MCID.Text = $"MCID: <b>{McidString}</b>";
                        }
                        SpoofSupport.Text = $"Supported Spoof: <b>{SupportedSpoofTypes}</b>";
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Misc.Notify("Update Player Info Error:\n" + ex.Message);
            }
        }
        #endregion
        public Spoofer() =>
            InitializeComponent();

        private async void Spoofer_Load(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                CustomDid.Text = Utils.Config.GetConfig().CustomDid;
                UpdatePlayerInfo();
            });
        }

        private async void Randomize_Click(object sender, EventArgs e)
        {
            try
            {
                await Task.Run(() =>
                {
                    Randomize.Enabled = false;
                    string NewGuid = Guid.NewGuid().ToString();
                    DidText = CustomDid.Text;
                    Utils.Config.GetConfig().CustomDid = CustomDid.Text;
                    if (string.IsNullOrEmpty(CustomDid.Text)) DidText = NewGuid;
                    if (string.IsNullOrWhiteSpace(CustomDid.Text)) DidText = NewGuid;

                    Memory.CheckInject();
                    foreach (SpoofPointersStruct Instance in Globals.SpoofList)
                    {
                        if (Memory.GetVersion().StartsWith(Instance.version))
                        {
                            Logging.Log($"Version matches ({Instance.version})");
                            Spoof.SpoofIds(DidText, Instance.didPtr, Instance.mcidPtr);
                            UpdatePlayerInfo();
                            break;
                        }
                    }
                    Randomize.Enabled = true;
                });
            } catch (Exception ex)
            {
                Misc.Notify("Spoof Error:\n" + ex.Message);
                Randomize.Enabled = true;
            }
        }

        private async void Restart_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                UpdatePlayerInfo();
            });
        }
    }
}
