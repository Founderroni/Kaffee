﻿using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KaffeeUtility.Utils.Config;

namespace KaffeeUtility.Tabs
{
    public partial class Home : UserControl
    {
        #region Variables
        private static readonly string animsTrue = "Animations: <b><span style=\"color:green;\">True</span></b>";
        private static readonly string animsFalse = "Animations: <b><span style=\"color:red;\">False</span></b>";
        private static readonly string fastlaunchFalse = "FastLaunch: <b><span style=\"color:red;\">False</span></b>";
        private static readonly string fastlaunchTrue = "FastLaunch: <b><span style=\"color:green;\">True</span></b>";
        private static readonly string loggingTrue = "Debug Logs: <b><span style=\"color:green;\">True</span></b>";
        private static readonly string loggingFalse = "Debug Logs: <b><span style=\"color:red;\">False</span></b>";
        #endregion

        public Home() =>
            InitializeComponent();

        private void Home_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (GetConfig().UseAnimations)
                {
                    foreach (Control ctrl in Controls)
                    {
                        ctrl.Location = new Point(ctrl.Location.X, ctrl.Location.Y - 10);
                        Handlers.Animator.Linear(ctrl, "Top", ctrl.Location.Y + 10, 500);
                    }

                    Task.Delay(500).ContinueWith(t =>
                    {
                        foreach (Guna.UI2.WinForms.Guna2Panel panel in Controls)
                        {
                            panel.ShadowDecoration.Enabled = true;
                            Handlers.Animator.Linear(panel.ShadowDecoration, "Depth", 30, 300);
                        }
                    });
                } else
                {
                    foreach (Guna.UI2.WinForms.Guna2Panel panel in Controls)
                    {
                        panel.ShadowDecoration.Enabled = true;
                        panel.ShadowDecoration.Depth = 30;
                    }
                }

                #region Launcher Stats
                Launches.Text = $"Launches: <b>{GetConfig().Launches}</b>";
                Version.Text = $"File Version: <b>{Globals.Version}</b>";
                Animations.Text = GetConfig().UseAnimations ? animsTrue : animsFalse;
                FastLaunch.Text = GetConfig().FastLaunch ? fastlaunchTrue : fastlaunchFalse;
                Logging.Text = GetConfig().Logging ? loggingTrue : loggingFalse;
                #endregion

                #region Inject Stats
                Injections.Text = $"Injections: <b>{GetConfig().Injections}</b>";
                #endregion
            });
        }
    }
}
