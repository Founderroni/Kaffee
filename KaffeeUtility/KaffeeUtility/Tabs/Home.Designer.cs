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
            this.Animations = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LauncherStats = new System.Windows.Forms.Label();
            this.Version = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Launches = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FastLaunch = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Logging = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.InjectPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.InjectStats = new System.Windows.Forms.Label();
            this.Injections = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LauncherPanel.SuspendLayout();
            this.InjectPanel.SuspendLayout();
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
            // Animations
            // 
            this.Animations.BackColor = System.Drawing.Color.Transparent;
            this.Animations.ForeColor = System.Drawing.Color.LightGray;
            this.Animations.Location = new System.Drawing.Point(3, 67);
            this.Animations.Name = "Animations";
            this.Animations.Size = new System.Drawing.Size(97, 17);
            this.Animations.TabIndex = 3;
            this.Animations.Text = "Animations: <b><span style=\"color:green;\">True</span></b>";
            // 
            // LauncherStats
            // 
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
            this.Version.Location = new System.Drawing.Point(3, 46);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(91, 17);
            this.Version.TabIndex = 1;
            this.Version.Text = "File Version: <b><span>1.0</span></b>";
            // 
            // Launches
            // 
            this.Launches.BackColor = System.Drawing.Color.Transparent;
            this.Launches.ForeColor = System.Drawing.Color.LightGray;
            this.Launches.Location = new System.Drawing.Point(3, 25);
            this.Launches.Name = "Launches";
            this.Launches.Size = new System.Drawing.Size(71, 17);
            this.Launches.TabIndex = 0;
            this.Launches.Text = "Launches: <b><span>0</span></b>";
            // 
            // FastLaunch
            // 
            this.FastLaunch.BackColor = System.Drawing.Color.Transparent;
            this.FastLaunch.ForeColor = System.Drawing.Color.LightGray;
            this.FastLaunch.Location = new System.Drawing.Point(3, 88);
            this.FastLaunch.Name = "FastLaunch";
            this.FastLaunch.Size = new System.Drawing.Size(104, 17);
            this.FastLaunch.TabIndex = 4;
            this.FastLaunch.Text = "FastLaunch: <b><span style=\"color:red;\">False</span></b>";
            // 
            // Logging
            // 
            this.Logging.BackColor = System.Drawing.Color.Transparent;
            this.Logging.ForeColor = System.Drawing.Color.LightGray;
            this.Logging.Location = new System.Drawing.Point(3, 109);
            this.Logging.Name = "Logging";
            this.Logging.Size = new System.Drawing.Size(103, 17);
            this.Logging.TabIndex = 5;
            this.Logging.Text = "Debug Logs: <b><span style=\"color:green;\">True</span></b>";
            // 
            // InjectPanel
            // 
            this.InjectPanel.BackColor = System.Drawing.Color.Transparent;
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
            // InjectStats
            // 
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
            this.Injections.Location = new System.Drawing.Point(3, 25);
            this.Injections.Name = "Injections";
            this.Injections.Size = new System.Drawing.Size(69, 17);
            this.Injections.TabIndex = 0;
            this.Injections.Text = "Injections: <b><span>0</span></b>";
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
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
    }
}
