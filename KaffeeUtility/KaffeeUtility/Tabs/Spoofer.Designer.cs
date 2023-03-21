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
            this.Randomize = new Guna.UI2.WinForms.Guna2Button();
            this.ClientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientPanel
            // 
            this.ClientPanel.BackColor = System.Drawing.Color.Transparent;
            this.ClientPanel.Controls.Add(this.CustomDid);
            this.ClientPanel.Controls.Add(this.SpoofSupport);
            this.ClientPanel.Controls.Add(this.Randomize);
            this.ClientPanel.Controls.Add(this.SpoofLabel);
            this.ClientPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientPanel.Location = new System.Drawing.Point(162, 204);
            this.ClientPanel.Name = "ClientPanel";
            this.ClientPanel.ShadowDecoration.Depth = 0;
            this.ClientPanel.Size = new System.Drawing.Size(486, 141);
            this.ClientPanel.TabIndex = 8;
            this.ClientPanel.UseTransparentBackground = true;
            // 
            // SpoofSupport
            // 
            this.SpoofSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SpoofSupport.AutoSize = false;
            this.SpoofSupport.BackColor = System.Drawing.Color.Transparent;
            this.SpoofSupport.ForeColor = System.Drawing.Color.LightGray;
            this.SpoofSupport.Location = new System.Drawing.Point(3, 106);
            this.SpoofSupport.Name = "SpoofSupport";
            this.SpoofSupport.Size = new System.Drawing.Size(480, 17);
            this.SpoofSupport.TabIndex = 5;
            this.SpoofSupport.Text = "Supported Spoof: <b>CID, DID, MCID</b>";
            this.SpoofSupport.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpoofLabel
            // 
            this.SpoofLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SpoofLabel.AutoSize = true;
            this.SpoofLabel.ForeColor = System.Drawing.Color.Gray;
            this.SpoofLabel.Location = new System.Drawing.Point(224, 0);
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
            this.CustomDid.Location = new System.Drawing.Point(51, 42);
            this.CustomDid.Name = "CustomDid";
            this.CustomDid.PasswordChar = '\0';
            this.CustomDid.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.CustomDid.PlaceholderText = "Custom DID (leave empty for random)";
            this.CustomDid.SelectedText = "";
            this.CustomDid.Size = new System.Drawing.Size(342, 36);
            this.CustomDid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.CustomDid.TabIndex = 6;
            // 
            // Randomize
            // 
            this.Randomize.Animated = true;
            this.Randomize.AutoRoundedCorners = true;
            this.Randomize.BorderRadius = 17;
            this.Randomize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Randomize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Randomize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Randomize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Randomize.FillColor = System.Drawing.Color.Transparent;
            this.Randomize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Randomize.ForeColor = System.Drawing.Color.White;
            this.Randomize.Image = global::KaffeeUtility.Properties.Resources.shuffle_48px;
            this.Randomize.ImageSize = new System.Drawing.Size(24, 24);
            this.Randomize.Location = new System.Drawing.Point(399, 42);
            this.Randomize.Name = "Randomize";
            this.Randomize.Size = new System.Drawing.Size(36, 36);
            this.Randomize.TabIndex = 4;
            this.Randomize.UseTransparentBackground = true;
            this.Randomize.Click += new System.EventHandler(this.Randomize_Click);
            // 
            // Spoofer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.ClientPanel);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "Spoofer";
            this.Size = new System.Drawing.Size(811, 548);
            this.ClientPanel.ResumeLayout(false);
            this.ClientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ClientPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel SpoofSupport;
        private Guna.UI2.WinForms.Guna2Button Randomize;
        private System.Windows.Forms.Label SpoofLabel;
        private Guna.UI2.WinForms.Guna2TextBox CustomDid;
    }
}
