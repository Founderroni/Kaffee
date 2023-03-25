namespace KaffeeUtility.Tabs
{
    partial class Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LauncherPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Logging = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FastLaunch = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Animations = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LauncherStats = new System.Windows.Forms.Label();
            this.Version = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Launches = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.InjectPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.FailedInjects = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.InjectDelay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.InjectStats = new System.Windows.Forms.Label();
            this.Injections = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Username = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SpoofStats = new System.Windows.Forms.Label();
            this.Spoofs = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LauncherPanel.SuspendLayout();
            this.InjectPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LauncherPanel
            // 
            this.LauncherPanel.BackColor = System.Drawing.Color.Transparent;
            this.LauncherPanel.Controls.Add(this.Logging);
            this.LauncherPanel.Controls.Add(this.FastLaunch);
            this.LauncherPanel.Controls.Add(this.Animations);
            this.LauncherPanel.Controls.Add(this.LauncherStats);
            this.LauncherPanel.Controls.Add(this.Version);
            this.LauncherPanel.Controls.Add(this.Launches);
            this.LauncherPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LauncherPanel.Location = new System.Drawing.Point(200, 35);
            this.LauncherPanel.Name = "LauncherPanel";
            this.LauncherPanel.ShadowDecoration.Depth = 0;
            this.LauncherPanel.Size = new System.Drawing.Size(190, 151);
            this.LauncherPanel.TabIndex = 0;
            this.LauncherPanel.UseTransparentBackground = true;
            // 
            // Logging
            // 
            this.Logging.BackColor = System.Drawing.Color.Transparent;
            this.Logging.ForeColor = System.Drawing.Color.LightGray;
            this.Logging.Location = new System.Drawing.Point(3, 118);
            this.Logging.Name = "Logging";
            this.Logging.Size = new System.Drawing.Size(93, 15);
            this.Logging.TabIndex = 5;
            this.Logging.Text = "Debug Logs: <b><span style=\"color:green;\">True</span></b>";
            // 
            // FastLaunch
            // 
            this.FastLaunch.BackColor = System.Drawing.Color.Transparent;
            this.FastLaunch.ForeColor = System.Drawing.Color.LightGray;
            this.FastLaunch.Location = new System.Drawing.Point(3, 95);
            this.FastLaunch.Name = "FastLaunch";
            this.FastLaunch.Size = new System.Drawing.Size(95, 15);
            this.FastLaunch.TabIndex = 4;
            this.FastLaunch.Text = "FastLaunch: <b><span style=\"color:red;\">False</span></b>";
            // 
            // Animations
            // 
            this.Animations.BackColor = System.Drawing.Color.Transparent;
            this.Animations.ForeColor = System.Drawing.Color.LightGray;
            this.Animations.Location = new System.Drawing.Point(3, 72);
            this.Animations.Name = "Animations";
            this.Animations.Size = new System.Drawing.Size(86, 15);
            this.Animations.TabIndex = 3;
            this.Animations.Text = "Animations: <b><span style=\"color:green;\">True</span></b>";
            // 
            // LauncherStats
            // 
            this.LauncherStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LauncherStats.AutoSize = true;
            this.LauncherStats.ForeColor = System.Drawing.Color.Gray;
            this.LauncherStats.Location = new System.Drawing.Point(50, 0);
            this.LauncherStats.Name = "LauncherStats";
            this.LauncherStats.Size = new System.Drawing.Size(90, 15);
            this.LauncherStats.TabIndex = 2;
            this.LauncherStats.Text = "Launcher Stats";
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.ForeColor = System.Drawing.Color.LightGray;
            this.Version.Location = new System.Drawing.Point(3, 49);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(81, 15);
            this.Version.TabIndex = 1;
            this.Version.Text = "File Version: <b><span>1.0</span></b>";
            // 
            // Launches
            // 
            this.Launches.BackColor = System.Drawing.Color.Transparent;
            this.Launches.ForeColor = System.Drawing.Color.LightGray;
            this.Launches.Location = new System.Drawing.Point(3, 26);
            this.Launches.Name = "Launches";
            this.Launches.Size = new System.Drawing.Size(63, 15);
            this.Launches.TabIndex = 0;
            this.Launches.Text = "Launches: <b><span>0</span></b>";
            // 
            // InjectPanel
            // 
            this.InjectPanel.BackColor = System.Drawing.Color.Transparent;
            this.InjectPanel.Controls.Add(this.FailedInjects);
            this.InjectPanel.Controls.Add(this.InjectDelay);
            this.InjectPanel.Controls.Add(this.InjectStats);
            this.InjectPanel.Controls.Add(this.Injections);
            this.InjectPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.InjectPanel.Location = new System.Drawing.Point(420, 35);
            this.InjectPanel.Name = "InjectPanel";
            this.InjectPanel.ShadowDecoration.Depth = 0;
            this.InjectPanel.Size = new System.Drawing.Size(190, 151);
            this.InjectPanel.TabIndex = 6;
            this.InjectPanel.UseTransparentBackground = true;
            // 
            // FailedInjects
            // 
            this.FailedInjects.BackColor = System.Drawing.Color.Transparent;
            this.FailedInjects.ForeColor = System.Drawing.Color.LightGray;
            this.FailedInjects.Location = new System.Drawing.Point(3, 47);
            this.FailedInjects.Name = "FailedInjects";
            this.FailedInjects.Size = new System.Drawing.Size(92, 15);
            this.FailedInjects.TabIndex = 4;
            this.FailedInjects.Text = "Failed Injections: <b><span>0</span></b>";
            // 
            // InjectDelay
            // 
            this.InjectDelay.BackColor = System.Drawing.Color.Transparent;
            this.InjectDelay.ForeColor = System.Drawing.Color.LightGray;
            this.InjectDelay.Location = new System.Drawing.Point(3, 68);
            this.InjectDelay.Name = "InjectDelay";
            this.InjectDelay.Size = new System.Drawing.Size(72, 15);
            this.InjectDelay.TabIndex = 3;
            this.InjectDelay.Text = "Inject Delay: <b><span>0</span></b>";
            // 
            // InjectStats
            // 
            this.InjectStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.InjectStats.AutoSize = true;
            this.InjectStats.ForeColor = System.Drawing.Color.Gray;
            this.InjectStats.Location = new System.Drawing.Point(62, 0);
            this.InjectStats.Name = "InjectStats";
            this.InjectStats.Size = new System.Drawing.Size(67, 15);
            this.InjectStats.TabIndex = 2;
            this.InjectStats.Text = "Inject Stats";
            // 
            // Injections
            // 
            this.Injections.BackColor = System.Drawing.Color.Transparent;
            this.Injections.ForeColor = System.Drawing.Color.LightGray;
            this.Injections.Location = new System.Drawing.Point(3, 26);
            this.Injections.Name = "Injections";
            this.Injections.Size = new System.Drawing.Size(61, 15);
            this.Injections.TabIndex = 0;
            this.Injections.Text = "Injections: <b><span>0</span></b>";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.Username);
            this.guna2Panel1.Controls.Add(this.CID);
            this.guna2Panel1.Controls.Add(this.SpoofStats);
            this.guna2Panel1.Controls.Add(this.Spoofs);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.guna2Panel1.Location = new System.Drawing.Point(310, 216);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Depth = 0;
            this.guna2Panel1.Size = new System.Drawing.Size(190, 151);
            this.guna2Panel1.TabIndex = 7;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.ForeColor = System.Drawing.Color.LightGray;
            this.Username.Location = new System.Drawing.Point(3, 47);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(108, 17);
            this.Username.TabIndex = 4;
            this.Username.Text = "MP_Username <b><span>N/A</span></b>";
            // 
            // CID
            // 
            this.CID.BackColor = System.Drawing.Color.Transparent;
            this.CID.ForeColor = System.Drawing.Color.LightGray;
            this.CID.Location = new System.Drawing.Point(3, 68);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(49, 17);
            this.CID.TabIndex = 3;
            this.CID.Text = "CID: <b><span>N/A</span></b>";
            // 
            // SpoofStats
            // 
            this.SpoofStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SpoofStats.AutoSize = true;
            this.SpoofStats.ForeColor = System.Drawing.Color.Gray;
            this.SpoofStats.Location = new System.Drawing.Point(62, 0);
            this.SpoofStats.Name = "SpoofStats";
            this.SpoofStats.Size = new System.Drawing.Size(70, 15);
            this.SpoofStats.TabIndex = 2;
            this.SpoofStats.Text = "Spoof Stats";
            // 
            // Spoofs
            // 
            this.Spoofs.BackColor = System.Drawing.Color.Transparent;
            this.Spoofs.ForeColor = System.Drawing.Color.LightGray;
            this.Spoofs.Location = new System.Drawing.Point(3, 26);
            this.Spoofs.Name = "Spoofs";
            this.Spoofs.Size = new System.Drawing.Size(55, 17);
            this.Spoofs.TabIndex = 0;
            this.Spoofs.Text = "Spoofs: <b><span>0</span></b>";
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.InjectPanel);
            this.Controls.Add(this.LauncherPanel);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "Home";
            this.Size = new System.Drawing.Size(811, 548);
            this.Load += new System.EventHandler(this.Home_Load);
            this.LauncherPanel.ResumeLayout(false);
            this.LauncherPanel.PerformLayout();
            this.InjectPanel.ResumeLayout(false);
            this.InjectPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel LauncherPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel Version;
        private Guna.UI2.WinForms.Guna2HtmlLabel Launches;
        private System.Windows.Forms.Label LauncherStats;
        private Guna.UI2.WinForms.Guna2HtmlLabel Animations;
        private Guna.UI2.WinForms.Guna2HtmlLabel FastLaunch;
        private Guna.UI2.WinForms.Guna2HtmlLabel Logging;
        private Guna.UI2.WinForms.Guna2Panel InjectPanel;
        private System.Windows.Forms.Label InjectStats;
        private Guna.UI2.WinForms.Guna2HtmlLabel Injections;
        private Guna.UI2.WinForms.Guna2HtmlLabel InjectDelay;
        private Guna.UI2.WinForms.Guna2HtmlLabel FailedInjects;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Username;
        private Guna.UI2.WinForms.Guna2HtmlLabel CID;
        private System.Windows.Forms.Label SpoofStats;
        private Guna.UI2.WinForms.Guna2HtmlLabel Spoofs;
    }
}
