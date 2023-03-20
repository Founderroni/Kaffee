using KaffeeUtility.Models;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaffeeUtility.Tabs
{
    public partial class Injector : UserControl
    {
        public Injector()
        {
            InitializeComponent();
        }

        private void Injector_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                foreach (ClientListStruct Instance in Globals.ClientList)
                {
                    ClientList.Items.Add(Instance.displayName);
                    Utils.Logging.Log("Added " + Instance.displayName + " to Client List");
                }
                ClientList.StartIndex = 0;
            });
        }
    }
}
