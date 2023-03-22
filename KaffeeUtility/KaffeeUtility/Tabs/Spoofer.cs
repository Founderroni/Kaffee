using KaffeeUtility.Handlers;
using KaffeeUtility.Models;
using KaffeeUtility.Utils;
using System;
using System.IO;
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
                    string[] lines = File.ReadAllLines(Globals.McpeDirectory + "options.txt");
                    for (int i = 0; i < lines.Length; i++)
                    {
                        if (lines[i].StartsWith("mp_username"))
                        {
                            string[] parts = lines[i].Split(':');
                            Username.Text = $"MP_Username: <b>{parts[1]}</b>";
                            continue;
                        }
                    }

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
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                Misc.Notify("Update Player Info Error:\n" + ex.Message);
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
