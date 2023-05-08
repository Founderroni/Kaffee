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
            this.components = new System.ComponentModel.Container();
            this.ClientPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.VersionSupport = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ClientList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DllPath = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Injection = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.UseCustomDll = new Guna.UI2.WinForms.Guna2CheckBox();
            this.DisableVersionCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.InjectDelayLabel = new System.Windows.Forms.Label();
            this.InjectDelay = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.InjectSettings = new System.Windows.Forms.Label();
            this.PathToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Kill = new Guna.UI2.WinForms.Guna2Button();
            this.Inject = new Guna.UI2.WinForms.Guna2Button();
            this.SelectDll = new Guna.UI2.WinForms.Guna2Button();
            this.KillAllInstances = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ClientPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InjectDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientPanel
            // 
            this.ClientPanel.BackColor = System.Drawing.Color.Transparent;
            this.ClientPanel.Controls.Add(this.Kill);
            this.ClientPanel.Controls.Add(this.VersionSupport);
            this.ClientPanel.Controls.Add(this.Inject);
            this.ClientPanel.Controls.Add(this.SelectDll);
            this.ClientPanel.Controls.Add(this.ClientList);
            this.ClientPanel.Controls.Add(this.DllPath);
            this.ClientPanel.Controls.Add(this.Injection);
            this.ClientPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientPanel.Location = new System.Drawing.Point(164, 101);
            this.ClientPanel.Name = "ClientPanel";
            this.ClientPanel.ShadowDecoration.Depth = 0;
            this.ClientPanel.Size = new System.Drawing.Size(483, 141);
            this.ClientPanel.TabIndex = 7;
            this.ClientPanel.UseTransparentBackground = true;
            // 
            // VersionSupport
            // 
            this.VersionSupport.AutoSize = false;
            this.VersionSupport.BackColor = System.Drawing.Color.Transparent;
            this.VersionSupport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.VersionSupport.ForeColor = System.Drawing.Color.LightGray;
            this.VersionSupport.Location = new System.Drawing.Point(0, 111);
            this.VersionSupport.Name = "VersionSupport";
            this.VersionSupport.Size = new System.Drawing.Size(483, 15);
            this.VersionSupport.TabIndex = 5;
            this.VersionSupport.Text = "Supported Version: <b>N/A</b>";
            this.VersionSupport.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientList
            // 
            this.ClientList.BackColor = System.Drawing.Color.Transparent;
            this.ClientList.BorderColor = System.Drawing.Color.Transparent;
            this.ClientList.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.ClientList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientList.DisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.ClientList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ClientList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(35)))), ((int)(((byte)(217)))));
            this.ClientList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(35)))), ((int)(((byte)(217)))));
            this.ClientList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientList.ForeColor = System.Drawing.Color.White;
            this.ClientList.ItemHeight = 30;
            this.ClientList.Location = new System.Drawing.Point(89, 42);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(179, 36);
            this.ClientList.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ClientList.TabIndex = 3;
            this.ClientList.SelectedIndexChanged += new System.EventHandler(this.ClientList_SelectedIndexChanged);
            // 
            // DllPath
            // 
            this.DllPath.AutoSize = false;
            this.DllPath.BackColor = System.Drawing.Color.Transparent;
            this.DllPath.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DllPath.ForeColor = System.Drawing.Color.LightGray;
            this.DllPath.Location = new System.Drawing.Point(0, 126);
            this.DllPath.Name = "DllPath";
            this.DllPath.Size = new System.Drawing.Size(483, 15);
            this.DllPath.TabIndex = 5;
            this.DllPath.Text = "Path: <b>N/A</b>";
            this.DllPath.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.DllPath.MouseHover += new System.EventHandler(this.DllPath_OnMouseHover);
            // 
            // Injection
            // 
            this.Injection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Injection.AutoSize = true;
            this.Injection.ForeColor = System.Drawing.Color.Gray;
            this.Injection.Location = new System.Drawing.Point(215, 0);
            this.Injection.Name = "Injection";
            this.Injection.Size = new System.Drawing.Size(53, 15);
            this.Injection.TabIndex = 2;
            this.Injection.Text = "Injection";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.KillAllInstances);
            this.guna2Panel1.Controls.Add(this.UseCustomDll);
            this.guna2Panel1.Controls.Add(this.DisableVersionCheck);
            this.guna2Panel1.Controls.Add(this.InjectDelayLabel);
            this.guna2Panel1.Controls.Add(this.InjectDelay);
            this.guna2Panel1.Controls.Add(this.InjectSettings);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.guna2Panel1.Location = new System.Drawing.Point(264, 272);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Depth = 0;
            this.guna2Panel1.Size = new System.Drawing.Size(282, 210);
            this.guna2Panel1.TabIndex = 8;
            this.guna2Panel1.UseTransparentBackground = true;
            // 
            // UseCustomDll
            // 
            this.UseCustomDll.Animated = true;
            this.UseCustomDll.AutoSize = true;
            this.UseCustomDll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(35)))), ((int)(((byte)(217)))));
            this.UseCustomDll.CheckedState.BorderRadius = 0;
            this.UseCustomDll.CheckedState.BorderThickness = 0;
            this.UseCustomDll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(35)))), ((int)(((byte)(217)))));
            this.UseCustomDll.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseCustomDll.Location = new System.Drawing.Point(57, 130);
            this.UseCustomDll.Name = "UseCustomDll";
            this.UseCustomDll.Size = new System.Drawing.Size(129, 19);
            this.UseCustomDll.TabIndex = 6;
            this.UseCustomDll.Text = "Inject Custom DLL";
            this.UseCustomDll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.UseCustomDll.UncheckedState.BorderRadius = 0;
            this.UseCustomDll.UncheckedState.BorderThickness = 0;
            this.UseCustomDll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.UseCustomDll.CheckedChanged += new System.EventHandler(this.UseCustomDll_CheckedChanged);
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
            this.DisableVersionCheck.Location = new System.Drawing.Point(58, 97);
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
            this.InjectDelayLabel.Location = new System.Drawing.Point(55, 29);
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
            this.InjectDelay.Location = new System.Drawing.Point(57, 47);
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
            // PathToolTip
            // 
            this.PathToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PathToolTip.ForeColor = System.Drawing.Color.LightGray;
            // 
            // Kill
            // 
            this.Kill.Animated = true;
            this.Kill.AutoRoundedCorners = true;
            this.Kill.BorderRadius = 17;
            this.Kill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Kill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Kill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Kill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Kill.FillColor = System.Drawing.Color.Transparent;
            this.Kill.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Kill.ForeColor = System.Drawing.Color.White;
            this.Kill.Image = global::KaffeeUtility.Properties.Resources.horror_48px;
            this.Kill.ImageSize = new System.Drawing.Size(24, 24);
            this.Kill.Location = new System.Drawing.Point(358, 42);
            this.Kill.Name = "Kill";
            this.Kill.Size = new System.Drawing.Size(36, 36);
            this.Kill.TabIndex = 7;
            this.Kill.UseTransparentBackground = true;
            this.Kill.Click += new System.EventHandler(this.Kill_Click);
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
            this.Inject.Location = new System.Drawing.Point(316, 42);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(36, 36);
            this.Inject.TabIndex = 4;
            this.Inject.UseTransparentBackground = true;
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // SelectDll
            // 
            this.SelectDll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SelectDll.Animated = true;
            this.SelectDll.AutoRoundedCorners = true;
            this.SelectDll.BorderRadius = 17;
            this.SelectDll.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.SelectDll.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.SelectDll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.SelectDll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SelectDll.FillColor = System.Drawing.Color.Transparent;
            this.SelectDll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SelectDll.ForeColor = System.Drawing.Color.White;
            this.SelectDll.Image = global::KaffeeUtility.Properties.Resources.input_48px;
            this.SelectDll.ImageSize = new System.Drawing.Size(24, 24);
            this.SelectDll.Location = new System.Drawing.Point(274, 42);
            this.SelectDll.Name = "SelectDll";
            this.SelectDll.Size = new System.Drawing.Size(36, 36);
            this.SelectDll.TabIndex = 6;
            this.SelectDll.UseTransparentBackground = true;
            this.SelectDll.Click += new System.EventHandler(this.SelectDll_Click);
            // 
            // KillAllInstances
            // 
            this.KillAllInstances.Animated = true;
            this.KillAllInstances.AutoSize = true;
            this.KillAllInstances.Checked = true;
            this.KillAllInstances.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(35)))), ((int)(((byte)(217)))));
            this.KillAllInstances.CheckedState.BorderRadius = 0;
            this.KillAllInstances.CheckedState.BorderThickness = 0;
            this.KillAllInstances.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(35)))), ((int)(((byte)(217)))));
            this.KillAllInstances.CheckState = System.Windows.Forms.CheckState.Checked;
            this.KillAllInstances.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KillAllInstances.Location = new System.Drawing.Point(57, 163);
            this.KillAllInstances.Name = "KillAllInstances";
            this.KillAllInstances.Size = new System.Drawing.Size(119, 19);
            this.KillAllInstances.TabIndex = 7;
            this.KillAllInstances.Text = "Kill All Instances";
            this.KillAllInstances.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.KillAllInstances.UncheckedState.BorderRadius = 0;
            this.KillAllInstances.UncheckedState.BorderThickness = 0;
            this.KillAllInstances.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // Injector
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
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
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ClientPanel;
        private System.Windows.Forms.Label Injection;
        private Guna.UI2.WinForms.Guna2ComboBox ClientList;
        private Guna.UI2.WinForms.Guna2Button Inject;
        private Guna.UI2.WinForms.Guna2HtmlLabel VersionSupport;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label InjectSettings;
        private Guna.UI2.WinForms.Guna2NumericUpDown InjectDelay;
        private System.Windows.Forms.Label InjectDelayLabel;
        private Guna.UI2.WinForms.Guna2CheckBox DisableVersionCheck;
        private Guna.UI2.WinForms.Guna2HtmlLabel DllPath;
        private Guna.UI2.WinForms.Guna2Button SelectDll;
        private Guna.UI2.WinForms.Guna2CheckBox UseCustomDll;
        private System.Windows.Forms.ToolTip PathToolTip;
        private Guna.UI2.WinForms.Guna2Button Kill;
        private Guna.UI2.WinForms.Guna2CheckBox KillAllInstances;
    }
}
