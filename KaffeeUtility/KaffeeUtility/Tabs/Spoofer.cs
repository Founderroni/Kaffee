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
        private string DidText = "";
        public Spoofer() =>
            InitializeComponent();

        private void Randomize_Click(object sender, EventArgs e)
        {
            try
            {
                Task.Run(() =>
                {
                    if (string.IsNullOrEmpty(CustomDid.Text)) DidText = new Guid().ToString();
                    if (string.IsNullOrWhiteSpace(CustomDid.Text)) DidText = new Guid().ToString();
                    MessageBox.Show(DidText.Length.ToString());

                    Memory.CheckInject();
                    foreach (SpoofPointersStruct Instance in Globals.SpoofList)
                    {
                        if (Memory.GetVersion().StartsWith(Instance.version))
                        {
                            Logging.Log($@"Version matches ({Instance.version})");
                            Spoof.SpoofIds(DidText, Instance.didPtr, Instance.mcidPtr);
                            Utils.Config.GetConfig().Spoofs++;
                        }
                        else
                        {
                            Logging.Log("Spoof failed, client version is not supported");
                            Misc.Notify("Spoofer does not support the Minecraft version you are on");
                        }
                    }
                });
            } catch (Exception ex)
            {
                Misc.Notify("Spoof Error:\n" + ex.Message);
            }
        }
    }
}
