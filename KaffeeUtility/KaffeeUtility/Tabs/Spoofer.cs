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
                Task.Run(() =>
                {
                    SpoofSupport.Text = "Supported Spoof: <b>CID</b>";
                    Memory.CheckInject();
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
                        }
                        else
                        {
                            Logging.Log("Minecraft version is not supported");
                            Misc.Notify("Spoofer does not support the Minecraft version you are on");
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                Misc.Notify("Restart/Re-Inject Error:\n" + ex.Message);
            }
        }
        #endregion
        public Spoofer() =>
            InitializeComponent();

        private void Spoofer_Load(object sender, EventArgs e) =>
            UpdatePlayerInfo();

        private void Randomize_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(() =>
                {
                    if (string.IsNullOrEmpty(CustomDid.Text)) DidText = new Guid().ToString().ToLower();
                    if (string.IsNullOrWhiteSpace(CustomDid.Text)) DidText = new Guid().ToString().ToLower();
                    MessageBox.Show(DidText.Length.ToString());

                    Memory.CheckInject();
                    foreach (SpoofPointersStruct Instance in Globals.SpoofList)
                    {
                        if (Memory.GetVersion().StartsWith(Instance.version))
                        {
                            Logging.Log($@"Version matches ({Instance.version})");
                            Spoof.SpoofIds(DidText, Instance.didPtr, Instance.mcidPtr);
                            Utils.Config.GetConfig().Spoofs++;
                            UpdatePlayerInfo();
                        }
                        else
                        {
                            Logging.Log("Spoof failed, Minecraft version is not supported");
                            Misc.Notify("Spoofer does not support the Minecraft version you are on");
                        }
                    }
                });
            } catch (Exception ex)
            {
                Misc.Notify("Spoof Error:\n" + ex.Message);
            }
        }

        private void Restart_Click(object sender, EventArgs e) =>
            UpdatePlayerInfo();
    }
}
