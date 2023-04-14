namespace KaffeeUtility.Tabs
{
    partial class Injector
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
            this.VersionSupport = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ClientList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.DisableVersionCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.InjectDelayLabel = new System.Windows.Forms.Label();
            this.InjectDelay = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.InjectSettings = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.DllPath = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CustomDll = new System.Windows.Forms.Label();
            this.SelectDll = new Guna.UI2.WinForms.Guna2Button();
            this.InjectDll = new Guna.UI2.WinForms.Guna2Button();
            this.Inject = new Guna.UI2.WinForms.Guna2Button();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.InjectLabel = new System.Windows.Forms.Label();
            this.ClientPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InjectDelay)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientPanel
            // 
            this.ClientPanel.BackColor = System.Drawing.Color.Transparent;
            this.ClientPanel.Controls.Add(this.VersionSupport);
            this.ClientPanel.Controls.Add(this.Inject);
            this.ClientPanel.Controls.Add(this.ClientList);
            this.ClientPanel.Controls.Add(this.ClientLabel);
            this.ClientPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientPanel.Location = new System.Drawing.Point(255, 23);
            this.ClientPanel.Name = "ClientPanel";
            this.ClientPanel.ShadowDecoration.Depth = 0;
            this.ClientPanel.Size = new System.Drawing.Size(301, 141);
            this.ClientPanel.TabIndex = 7;
            this.ClientPanel.UseTransparentBackground = true;
            // 
            // VersionSupport
            // 
            this.VersionSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.VersionSupport.AutoSize = false;
            this.VersionSupport.BackColor = System.Drawing.Color.Transparent;
            this.VersionSupport.ForeColor = System.Drawing.Color.LightGray;
            this.VersionSupport.Location = new System.Drawing.Point(3, 106);
            this.VersionSupport.Name = "VersionSupport";
            this.VersionSupport.Size = new System.Drawing.Size(295, 17);
            this.VersionSupport.TabIndex = 5;
            this.VersionSupport.Text = "Supported Version: <b>N/A</b>";
            this.VersionSupport.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientList
            // 
            this.ClientList.BackColor = System.Drawing.Color.Transparent;
            this.ClientList.BorderColor = System.Drawing.Color.Transparent;
            this.ClientList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ClientList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(35)))), ((int)(((byte)(217)))));
            this.ClientList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(35)))), ((int)(((byte)(217)))));
            this.ClientList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientList.ForeColor = System.Drawing.Color.White;
            this.ClientList.ItemHeight = 30;
            this.ClientList.Location = new System.Drawing.Point(40, 42);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(179, 36);
            this.ClientList.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ClientList.TabIndex = 3;
            this.ClientList.SelectedIndexChanged += new System.EventHandler(this.ClientList_SelectedIndexChanged);
            // 
            // ClientLabel
            // 
            this.ClientLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.ForeColor = System.Drawing.Color.Gray;
            this.ClientLabel.Location = new System.Drawing.Point(127, 0);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(46, 15);
            this.ClientLabel.TabIndex = 2;
            this.ClientLabel.Text = "Clients";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.DisableVersionCheck);
            this.guna2Panel1.Controls.Add(this.InjectDelayLabel);
            this.guna2Panel1.Controls.Add(this.InjectDelay);
            this.guna2Panel1.Controls.Add(this.InjectSettings);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.guna2Panel1.Location = new System.Drawing.Point(264, 365);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Depth = 0;
            this.guna2Panel1.Size = new System.Drawing.Size(282, 161);
            this.guna2Panel1.TabIndex = 8;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // DisableVersionCheck
            // 
            this.DisableVersionCheck.Animated = true;
            this.DisableVersionCheck.AutoSize = true;
            this.DisableVersionCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(35)))), ((int)(((byte)(217)))));
            this.DisableVersionCheck.CheckedState.BorderRadius = 0;
            this.DisableVersionCheck.CheckedState.BorderThickness = 0;
            this.DisableVersionCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(35)))), ((int)(((byte)(217)))));
            this.DisableVersionCheck.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisableVersionCheck.Location = new System.Drawing.Point(58, 105);
            this.DisableVersionCheck.Name = "DisableVersionCheck";
            this.DisableVersionCheck.Size = new System.Drawing.Size(153, 19);
            this.DisableVersionCheck.TabIndex = 5;
            this.DisableVersionCheck.Text = "Disable Version Check";
            this.DisableVersionCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DisableVersionCheck.UncheckedState.BorderRadius = 0;
            this.DisableVersionCheck.UncheckedState.BorderThickness = 0;
            this.DisableVersionCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DisableVersionCheck.CheckedChanged += new System.EventHandler(this.DisableVersionCheck_CheckedChanged);
            // 
            // InjectDelayLabel
            // 
            this.InjectDelayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.InjectDelayLabel.AutoSize = true;
            this.InjectDelayLabel.ForeColor = System.Drawing.Color.Gray;
            this.InjectDelayLabel.Location = new System.Drawing.Point(55, 37);
            this.InjectDelayLabel.Name = "InjectDelayLabel";
            this.InjectDelayLabel.Size = new System.Drawing.Size(70, 15);
            this.InjectDelayLabel.TabIndex = 4;
            this.InjectDelayLabel.Text = "Inject Delay";
            // 
            // InjectDelay
            // 
            this.InjectDelay.BackColor = System.Drawing.Color.Transparent;
            this.InjectDelay.BorderColor = System.Drawing.Color.Transparent;
            this.InjectDelay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InjectDelay.CustomizableEdges.TopLeft = false;
            this.InjectDelay.CustomizableEdges.TopRight = false;
            this.InjectDelay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.InjectDelay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(35)))), ((int)(((byte)(217)))));
            this.InjectDelay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InjectDelay.ForeColor = System.Drawing.Color.LightGray;
            this.InjectDelay.Location = new System.Drawing.Point(57, 55);
            this.InjectDelay.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.InjectDelay.Name = "InjectDelay";
            this.InjectDelay.Size = new System.Drawing.Size(170, 36);
            this.InjectDelay.TabIndex = 3;
            this.InjectDelay.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.InjectDelay.UseTransparentBackground = true;
            this.InjectDelay.ValueChanged += new System.EventHandler(this.InjectDelay_ValueChanged);
            // 
            // InjectSettings
            // 
            this.InjectSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.InjectSettings.AutoSize = true;
            this.InjectSettings.ForeColor = System.Drawing.Color.Gray;
            this.InjectSettings.Location = new System.Drawing.Point(99, 0);
            this.InjectSettings.Name = "InjectSettings";
            this.InjectSettings.Size = new System.Drawing.Size(84, 15);
            this.InjectSettings.TabIndex = 2;
            this.InjectSettings.Text = "Inject Settings";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.InjectLabel);
            this.guna2Panel2.Controls.Add(this.SelectLabel);
            this.guna2Panel2.Controls.Add(this.SelectDll);
            this.guna2Panel2.Controls.Add(this.DllPath);
            this.guna2Panel2.Controls.Add(this.InjectDll);
            this.guna2Panel2.Controls.Add(this.CustomDll);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.guna2Panel2.Location = new System.Drawing.Point(164, 194);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Depth = 0;
            this.guna2Panel2.Size = new System.Drawing.Size(483, 141);
            this.guna2Panel2.TabIndex = 9;
            this.guna2Panel2.UseTransparentBackground = true;
            // 
            // DllPath
            // 
            this.DllPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DllPath.AutoSize = false;
            this.DllPath.BackColor = System.Drawing.Color.Transparent;
            this.DllPath.ForeColor = System.Drawing.Color.LightGray;
            this.DllPath.Location = new System.Drawing.Point(3, 106);
            this.DllPath.Name = "DllPath";
            this.DllPath.Size = new System.Drawing.Size(477, 17);
            this.DllPath.TabIndex = 5;
            this.DllPath.Text = "Path: <b>N/A</b>";
            this.DllPath.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomDll
            // 
            this.CustomDll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.CustomDll.AutoSize = true;
            this.CustomDll.ForeColor = System.Drawing.Color.Gray;
            this.CustomDll.Location = new System.Drawing.Point(203, 0);
            this.CustomDll.Name = "CustomDll";
            this.CustomDll.Size = new System.Drawing.Size(77, 15);
            this.CustomDll.TabIndex = 2;
            this.CustomDll.Text = "Custom DLL";
            // 
            // SelectDll
            // 
            this.SelectDll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SelectDll.Animated = true;
            this.SelectDll.AutoRoundedCorners = true;
            this.SelectDll.BorderRadius = 17;
            this.SelectDll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SelectDll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SelectDll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SelectDll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectDll.FillColor = System.Drawing.Color.Transparent;
            this.SelectDll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectDll.ForeColor = System.Drawing.Color.White;
            this.SelectDll.Image = global::KaffeeUtility.Properties.Resources.input_48px;
            this.SelectDll.ImageSize = new System.Drawing.Size(24, 24);
            this.SelectDll.Location = new System.Drawing.Point(190, 61);
            this.SelectDll.Name = "SelectDll";
            this.SelectDll.Size = new System.Drawing.Size(36, 36);
            this.SelectDll.TabIndex = 6;
            this.SelectDll.UseTransparentBackground = true;
            this.SelectDll.Click += new System.EventHandler(this.SelectDll_Click);
            // 
            // InjectDll
            // 
            this.InjectDll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.InjectDll.Animated = true;
            this.InjectDll.AutoRoundedCorners = true;
            this.InjectDll.BorderRadius = 17;
            this.InjectDll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.InjectDll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.InjectDll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.InjectDll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.InjectDll.FillColor = System.Drawing.Color.Transparent;
            this.InjectDll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InjectDll.ForeColor = System.Drawing.Color.White;
            this.InjectDll.Image = global::KaffeeUtility.Properties.Resources.syringe_48px;
            this.InjectDll.ImageSize = new System.Drawing.Size(24, 24);
            this.InjectDll.Location = new System.Drawing.Point(259, 61);
            this.InjectDll.Name = "InjectDll";
            this.InjectDll.Size = new System.Drawing.Size(36, 36);
            this.InjectDll.TabIndex = 4;
            this.InjectDll.UseTransparentBackground = true;
            this.InjectDll.Click += new System.EventHandler(this.InjectDll_Click);
            // 
            // Inject
            // 
            this.Inject.Animated = true;
            this.Inject.AutoRoundedCorners = true;
            this.Inject.BorderRadius = 17;
            this.Inject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Inject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Inject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Inject.FillColor = System.Drawing.Color.Transparent;
            this.Inject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Inject.ForeColor = System.Drawing.Color.White;
            this.Inject.Image = global::KaffeeUtility.Properties.Resources.syringe_48px;
            this.Inject.ImageSize = new System.Drawing.Size(24, 24);
            this.Inject.Location = new System.Drawing.Point(225, 42);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(36, 36);
            this.Inject.TabIndex = 4;
            this.Inject.UseTransparentBackground = true;
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // SelectLabel
            // 
            this.SelectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.ForeColor = System.Drawing.Color.Gray;
            this.SelectLabel.Location = new System.Drawing.Point(188, 43);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(41, 15);
            this.SelectLabel.TabIndex = 7;
            this.SelectLabel.Text = "Select";
            // 
            // InjectLabel
            // 
            this.InjectLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.InjectLabel.AutoSize = true;
            this.InjectLabel.ForeColor = System.Drawing.Color.Gray;
            this.InjectLabel.Location = new System.Drawing.Point(259, 43);
            this.InjectLabel.Name = "InjectLabel";
            this.InjectLabel.Size = new System.Drawing.Size(36, 15);
            this.InjectLabel.TabIndex = 8;
            this.InjectLabel.Text = "Inject";
            // 
            // Injector
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ClientPanel);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "Injector";
            this.Size = new System.Drawing.Size(811, 548);
            this.Load += new System.EventHandler(this.Injector_Load);
            this.ClientPanel.ResumeLayout(false);
            this.ClientPanel.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InjectDelay)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ClientPanel;
        private System.Windows.Forms.Label ClientLabel;
        private Guna.UI2.WinForms.Guna2ComboBox ClientList;
        private Guna.UI2.WinForms.Guna2Button Inject;
        private Guna.UI2.WinForms.Guna2HtmlLabel VersionSupport;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label InjectSettings;
        private Guna.UI2.WinForms.Guna2NumericUpDown InjectDelay;
        private System.Windows.Forms.Label InjectDelayLabel;
        private Guna.UI2.WinForms.Guna2CheckBox DisableVersionCheck;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel DllPath;
        private Guna.UI2.WinForms.Guna2Button InjectDll;
        private System.Windows.Forms.Label CustomDll;
        private Guna.UI2.WinForms.Guna2Button SelectDll;
        private System.Windows.Forms.Label InjectLabel;
        private System.Windows.Forms.Label SelectLabel;
    }
}
