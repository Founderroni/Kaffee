namespace KaffeeUtility.Tabs
{
    partial class Spoofer
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
            this.ClientPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SpoofSupport = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SpoofLabel = new System.Windows.Forms.Label();
            this.CustomDid = new Guna.UI2.WinForms.Guna2TextBox();
            this.Restart = new Guna.UI2.WinForms.Guna2Button();
            this.Randomize = new Guna.UI2.WinForms.Guna2Button();
            this.InjectPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.DID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PlayerInfo = new System.Windows.Forms.Label();
            this.CID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MCID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Username = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.MCVersion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ClientPanel.SuspendLayout();
            this.InjectPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientPanel
            // 
            this.ClientPanel.BackColor = System.Drawing.Color.Transparent;
            this.ClientPanel.Controls.Add(this.Restart);
            this.ClientPanel.Controls.Add(this.CustomDid);
            this.ClientPanel.Controls.Add(this.SpoofSupport);
            this.ClientPanel.Controls.Add(this.Randomize);
            this.ClientPanel.Controls.Add(this.SpoofLabel);
            this.ClientPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientPanel.Location = new System.Drawing.Point(156, 128);
            this.ClientPanel.Name = "ClientPanel";
            this.ClientPanel.ShadowDecoration.Depth = 0;
            this.ClientPanel.Size = new System.Drawing.Size(499, 141);
            this.ClientPanel.TabIndex = 8;
            this.ClientPanel.UseTransparentBackground = true;
            // 
            // SpoofSupport
            // 
            this.SpoofSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SpoofSupport.AutoSize = false;
            this.SpoofSupport.BackColor = System.Drawing.Color.Transparent;
            this.SpoofSupport.ForeColor = System.Drawing.Color.LightGray;
            this.SpoofSupport.Location = new System.Drawing.Point(9, 106);
            this.SpoofSupport.Name = "SpoofSupport";
            this.SpoofSupport.Size = new System.Drawing.Size(480, 17);
            this.SpoofSupport.TabIndex = 5;
            this.SpoofSupport.Text = "Supported Spoof: <b>CID</b>";
            this.SpoofSupport.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpoofLabel
            // 
            this.SpoofLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SpoofLabel.AutoSize = true;
            this.SpoofLabel.ForeColor = System.Drawing.Color.Gray;
            this.SpoofLabel.Location = new System.Drawing.Point(230, 0);
            this.SpoofLabel.Name = "SpoofLabel";
            this.SpoofLabel.Size = new System.Drawing.Size(39, 15);
            this.SpoofLabel.TabIndex = 2;
            this.SpoofLabel.Text = "Spoof";
            // 
            // CustomDid
            // 
            this.CustomDid.Animated = true;
            this.CustomDid.BorderColor = System.Drawing.Color.Black;
            this.CustomDid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomDid.DefaultText = "";
            this.CustomDid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CustomDid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CustomDid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomDid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CustomDid.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CustomDid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(35)))), ((int)(((byte)(217)))));
            this.CustomDid.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.CustomDid.ForeColor = System.Drawing.Color.White;
            this.CustomDid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(35)))), ((int)(((byte)(217)))));
            this.CustomDid.Location = new System.Drawing.Point(36, 42);
            this.CustomDid.MaxLength = 36;
            this.CustomDid.Name = "CustomDid";
            this.CustomDid.PasswordChar = '\0';
            this.CustomDid.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.CustomDid.PlaceholderText = "Custom DID (leave empty for random)";
            this.CustomDid.SelectedText = "";
            this.CustomDid.Size = new System.Drawing.Size(342, 36);
            this.CustomDid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.CustomDid.TabIndex = 6;
            // 
            // Restart
            // 
            this.Restart.Animated = true;
            this.Restart.AutoRoundedCorners = true;
            this.Restart.BorderRadius = 17;
            this.Restart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Restart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Restart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Restart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Restart.FillColor = System.Drawing.Color.Transparent;
            this.Restart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Restart.ForeColor = System.Drawing.Color.White;
            this.Restart.Image = global::KaffeeUtility.Properties.Resources.restart_48px;
            this.Restart.ImageSize = new System.Drawing.Size(24, 24);
            this.Restart.Location = new System.Drawing.Point(426, 42);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(36, 36);
            this.Restart.TabIndex = 7;
            this.Restart.UseTransparentBackground = true;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // Randomize
            // 
            this.Randomize.Animated = true;
            this.Randomize.AutoRoundedCorners = true;
            this.Randomize.BorderRadius = 17;
            this.Randomize.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.Randomize.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.Randomize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Randomize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Randomize.FillColor = System.Drawing.Color.Transparent;
            this.Randomize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Randomize.ForeColor = System.Drawing.Color.White;
            this.Randomize.Image = global::KaffeeUtility.Properties.Resources.shuffle_48px;
            this.Randomize.ImageSize = new System.Drawing.Size(24, 24);
            this.Randomize.Location = new System.Drawing.Point(384, 42);
            this.Randomize.Name = "Randomize";
            this.Randomize.Size = new System.Drawing.Size(36, 36);
            this.Randomize.TabIndex = 4;
            this.Randomize.UseTransparentBackground = true;
            this.Randomize.Click += new System.EventHandler(this.Randomize_Click);
            // 
            // InjectPanel
            // 
            this.InjectPanel.BackColor = System.Drawing.Color.Transparent;
            this.InjectPanel.Controls.Add(this.MCVersion);
            this.InjectPanel.Controls.Add(this.Username);
            this.InjectPanel.Controls.Add(this.DID);
            this.InjectPanel.Controls.Add(this.MCID);
            this.InjectPanel.Controls.Add(this.PlayerInfo);
            this.InjectPanel.Controls.Add(this.CID);
            this.InjectPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.InjectPanel.Location = new System.Drawing.Point(235, 299);
            this.InjectPanel.Name = "InjectPanel";
            this.InjectPanel.ShadowDecoration.Depth = 0;
            this.InjectPanel.Size = new System.Drawing.Size(340, 146);
            this.InjectPanel.TabIndex = 9;
            this.InjectPanel.UseTransparentBackground = true;
            // 
            // DID
            // 
            this.DID.BackColor = System.Drawing.Color.Transparent;
            this.DID.ForeColor = System.Drawing.Color.LightGray;
            this.DID.Location = new System.Drawing.Point(3, 92);
            this.DID.Name = "DID";
            this.DID.Size = new System.Drawing.Size(49, 17);
            this.DID.TabIndex = 4;
            this.DID.Text = "DID: <b>N/A</b>";
            // 
            // PlayerInfo
            // 
            this.PlayerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PlayerInfo.AutoSize = true;
            this.PlayerInfo.ForeColor = System.Drawing.Color.Gray;
            this.PlayerInfo.Location = new System.Drawing.Point(138, 0);
            this.PlayerInfo.Name = "PlayerInfo";
            this.PlayerInfo.Size = new System.Drawing.Size(64, 15);
            this.PlayerInfo.TabIndex = 2;
            this.PlayerInfo.Text = "Player Info";
            // 
            // CID
            // 
            this.CID.BackColor = System.Drawing.Color.Transparent;
            this.CID.ForeColor = System.Drawing.Color.LightGray;
            this.CID.Location = new System.Drawing.Point(3, 70);
            this.CID.Name = "CID";
            this.CID.Size = new System.Drawing.Size(49, 17);
            this.CID.TabIndex = 0;
            this.CID.Text = "CID: <b>N/A</b>";
            // 
            // MCID
            // 
            this.MCID.BackColor = System.Drawing.Color.Transparent;
            this.MCID.ForeColor = System.Drawing.Color.LightGray;
            this.MCID.Location = new System.Drawing.Point(3, 114);
            this.MCID.Name = "MCID";
            this.MCID.Size = new System.Drawing.Size(58, 17);
            this.MCID.TabIndex = 3;
            this.MCID.Text = "MCID: <b>N/A</b>";
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.ForeColor = System.Drawing.Color.LightGray;
            this.Username.Location = new System.Drawing.Point(3, 26);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(111, 17);
            this.Username.TabIndex = 5;
            this.Username.Text = "MP_Username: <b>N/A</b>";
            // 
            // MCVersion
            // 
            this.MCVersion.BackColor = System.Drawing.Color.Transparent;
            this.MCVersion.ForeColor = System.Drawing.Color.LightGray;
            this.MCVersion.Location = new System.Drawing.Point(3, 48);
            this.MCVersion.Name = "MCVersion";
            this.MCVersion.Size = new System.Drawing.Size(91, 17);
            this.MCVersion.TabIndex = 6;
            this.MCVersion.Text = "MC Version: <b>N/A</b>";
            // 
            // Spoofer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.InjectPanel);
            this.Controls.Add(this.ClientPanel);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "Spoofer";
            this.Size = new System.Drawing.Size(811, 548);
            this.Load += new System.EventHandler(this.Spoofer_Load);
            this.ClientPanel.ResumeLayout(false);
            this.ClientPanel.PerformLayout();
            this.InjectPanel.ResumeLayout(false);
            this.InjectPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ClientPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel SpoofSupport;
        private Guna.UI2.WinForms.Guna2Button Randomize;
        private System.Windows.Forms.Label SpoofLabel;
        private Guna.UI2.WinForms.Guna2TextBox CustomDid;
        private Guna.UI2.WinForms.Guna2Button Restart;
        private Guna.UI2.WinForms.Guna2Panel InjectPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel DID;
        private Guna.UI2.WinForms.Guna2HtmlLabel MCID;
        private System.Windows.Forms.Label PlayerInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel CID;
        private Guna.UI2.WinForms.Guna2HtmlLabel MCVersion;
        private Guna.UI2.WinForms.Guna2HtmlLabel Username;
    }
}
