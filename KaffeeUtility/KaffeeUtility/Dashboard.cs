using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaffeeUtility
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            interstitialAd.ShowInterstitialAd("ydeziejgr7ko");
        }

        #region Dashboard Functions
        private async void AnimateControls()
        {
            await Task.Run(() =>
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

        private async void OpenTab(UserControl tab = null)
        {
            if (tab is null)
            {
                TabContainer.Controls.Clear();
                return;
            }

            if (!TabContainer.Controls.ContainsKey(tab.Name))
            {
                TabContainer.Controls.Clear();
                TabContainer.Controls.Add(tab);
                if (Utils.Config.GetConfig().UseAnimations)
                {
                    /*
                    foreach (Control ctrl in tab.Controls)
                    {
                        ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y - 10);
                        Handlers.Animator.Linear(ctrl, "Top", ctrl.Location.Y + 10, 500);
                    }

                    await Task.Delay(300);

                    foreach (Guna.UI2.WinForms.Guna2Panel panel in tab.Controls)
                    {
                        panel.ShadowDecoration.Enabled = true;
                        Handlers.Animator.Linear(panel.ShadowDecoration, "Depth", 30, 300);
                    }
                    */

                    tab.Location = new Point(tab.Location.X, tab.Location.Y - 10);
                    Handlers.Animator.Linear(tab, "Top", tab.Location.Y + 10, 500);

                    await Task.Run(() =>
                    {
                        foreach (Guna.UI2.WinForms.Guna2Panel panel in tab.Controls)
                        {
                            panel.ShadowDecoration.Enabled = true;
                            Handlers.Animator.Linear(panel.ShadowDecoration, "Depth", 30, 500);
                        }
                    });
                }
                else
                {
                    await Task.Run(() =>
                    {
                        foreach (Guna.UI2.WinForms.Guna2Panel panel in tab.Controls)
                        {
                            panel.ShadowDecoration.Enabled = true;
                            panel.ShadowDecoration.Depth = 30;
                        }
                    });

                }
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
            Handlers.Discord.ClearRpc(false);
            Dispose();
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e) =>
            WindowState = FormWindowState.Minimized;

        private void HomeBtn_Click(object sender, EventArgs e) =>
            OpenTab(new Tabs.Home());

        private void Injector_Click(object sender, EventArgs e) =>
            OpenTab(new Tabs.Injector());

        private void Spoofer_Click(object sender, EventArgs e) =>
            OpenTab(new Tabs.Spoofer());

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
