using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaffeeUtility
{
    public partial class Dashboard : Form
    {
        public Dashboard() =>
            InitializeComponent();

        #region Dashboard Functions
        private void AnimateControls()
        {
            Task.Run(() =>
            {
                foreach (Control ctrl in SidePanel.Controls)
                {
                    if (ctrl.Name != "Separator")
                    {
                        ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y - 10);
                        Handlers.Animator.Linear(ctrl, "Top", ctrl.Location.Y + 10, 500);
                    }
                }
            });
        }

        private void OpenTab(UserControl tab = null)
        {
            if (tab == null)
            {
                TabContainer.Controls.Clear();
                return;
            }

            if (!TabContainer.Controls.ContainsKey(tab.Name))
            {
                TabContainer.Controls.Clear();
                TabContainer.Controls.Add(tab);
            }
        }
        #endregion

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (Utils.Config.GetConfig().UseAnimations)
                AnimateControls();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Dispose();
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e) =>
            WindowState = FormWindowState.Minimized;

        private void HomeBtn_Click(object sender, EventArgs e) =>
            OpenTab(new Tabs.Home());

        private void Injector_Click(object sender, EventArgs e) =>
            OpenTab();

        private void Directory_Click(object sender, EventArgs e)
        {
            try
            {
                Utils.Misc.OpenProcess(Globals.DataDir);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kaffee");
            }
        }

        private void Settings_Click(object sender, EventArgs e) =>
            OpenTab();
    }
}
