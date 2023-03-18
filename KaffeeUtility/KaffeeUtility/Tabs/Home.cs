﻿using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KaffeeUtility.Utils.Config;

namespace KaffeeUtility.Tabs
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                foreach (Control ctrl in Controls)
                {
                    ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y - 10);
                    Handlers.Animator.Linear(ctrl, "Top", ctrl.Location.Y + 10, 500);
                }

                Task.Delay(500).ContinueWith(t =>
                {
                    InjectorPanel.ShadowDecoration.Enabled = true;
                    Handlers.Animator.Linear(InjectorPanel.ShadowDecoration, "Depth", 30, 300);
                });

                Launches.Text = $"Launches: <b>{GetConfig().Launches}</b>";
                Version.Text = $"File Version: <b>{Globals.Version}</b>";
            });
        }
    }
}
