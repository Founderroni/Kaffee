namespace KaffeeUtility
{
    partial class Dashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.ModifyForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SidePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Separator = new Guna.UI2.WinForms.Guna2Separator();
            this.Watermark = new System.Windows.Forms.Label();
            this.TabContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.DragSidePanel = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Spoofer = new Guna.UI2.WinForms.Guna2Button();
            this.Directory = new Guna.UI2.WinForms.Guna2Button();
            this.Settings = new Guna.UI2.WinForms.Guna2Button();
            this.Injector = new Guna.UI2.WinForms.Guna2Button();
            this.Logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.HomeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Minimize = new Guna.UI2.WinForms.Guna2Button();
            this.Exit = new Guna.UI2.WinForms.Guna2Button();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifyForm
            // 
            this.ModifyForm.BorderRadius = 16;
            this.ModifyForm.ContainerControl = this;
            this.ModifyForm.DockIndicatorTransparencyValue = 0.6D;
            this.ModifyForm.TransparentWhileDrag = true;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Transparent;
            this.SidePanel.Controls.Add(this.Spoofer);
            this.SidePanel.Controls.Add(this.Directory);
            this.SidePanel.Controls.Add(this.Settings);
            this.SidePanel.Controls.Add(this.Injector);
            this.SidePanel.Controls.Add(this.Separator);
            this.SidePanel.Controls.Add(this.Watermark);
            this.SidePanel.Controls.Add(this.Logo);
            this.SidePanel.Controls.Add(this.HomeBtn);
            this.SidePanel.Controls.Add(this.Minimize);
            this.SidePanel.Controls.Add(this.Exit);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.ShadowDecoration.Enabled = true;
            this.SidePanel.Size = new System.Drawing.Size(155, 548);
            this.SidePanel.TabIndex = 0;
            // 
            // Separator
            // 
            this.Separator.BackColor = System.Drawing.Color.Transparent;
            this.Separator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Separator.Location = new System.Drawing.Point(6, 84);
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(143, 10);
            this.Separator.TabIndex = 6;
            this.Separator.UseTransparentBackground = true;
            // 
            // Watermark
            // 
            this.Watermark.AutoSize = true;
            this.Watermark.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Watermark.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Watermark.Location = new System.Drawing.Point(69, 48);
            this.Watermark.Name = "Watermark";
            this.Watermark.Size = new System.Drawing.Size(60, 23);
            this.Watermark.TabIndex = 5;
            this.Watermark.Text = "Kaffee";
            // 
            // TabContainer
            // 
            this.TabContainer.BackColor = System.Drawing.Color.Transparent;
            this.TabContainer.FillColor = System.Drawing.Color.Transparent;
            this.TabContainer.Location = new System.Drawing.Point(161, 0);
            this.TabContainer.Name = "TabContainer";
            this.TabContainer.Size = new System.Drawing.Size(811, 548);
            this.TabContainer.TabIndex = 1;
            this.TabContainer.UseTransparentBackground = true;
            // 
            // DragSidePanel
            // 
            this.DragSidePanel.DockIndicatorTransparencyValue = 0.6D;
            this.DragSidePanel.TargetControl = this.SidePanel;
            this.DragSidePanel.UseTransparentDrag = true;
            // 
            // Spoofer
            // 
            this.Spoofer.Animated = true;
            this.Spoofer.BackColor = System.Drawing.Color.Transparent;
            this.Spoofer.BorderColor = System.Drawing.Color.Transparent;
            this.Spoofer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Spoofer.CheckedState.ForeColor = System.Drawing.Color.White;
            this.Spoofer.CheckedState.Image = global::KaffeeUtility.Properties.Resources.anonymous_mask_pressed;
            this.Spoofer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Spoofer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Spoofer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Spoofer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Spoofer.FillColor = System.Drawing.Color.Transparent;
            this.Spoofer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Spoofer.ForeColor = System.Drawing.Color.LightGray;
            this.Spoofer.Image = global::KaffeeUtility.Properties.Resources.anonymous_mask_48px;
            this.Spoofer.Location = new System.Drawing.Point(0, 176);
            this.Spoofer.Name = "Spoofer";
            this.Spoofer.Size = new System.Drawing.Size(155, 32);
            this.Spoofer.TabIndex = 10;
            this.Spoofer.Text = "Spoofer";
            this.Spoofer.UseTransparentBackground = true;
            this.Spoofer.Click += new System.EventHandler(this.Spoofer_Click);
            // 
            // Directory
            // 
            this.Directory.Animated = true;
            this.Directory.BackColor = System.Drawing.Color.Transparent;
            this.Directory.BorderColor = System.Drawing.Color.Transparent;
            this.Directory.CheckedState.ForeColor = System.Drawing.Color.White;
            this.Directory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Directory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Directory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Directory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Directory.FillColor = System.Drawing.Color.Transparent;
            this.Directory.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Directory.ForeColor = System.Drawing.Color.LightGray;
            this.Directory.Image = global::KaffeeUtility.Properties.Resources.folder_48px;
            this.Directory.ImageSize = new System.Drawing.Size(24, 24);
            this.Directory.Location = new System.Drawing.Point(43, 513);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(32, 32);
            this.Directory.TabIndex = 9;
            this.Directory.UseTransparentBackground = true;
            this.Directory.Click += new System.EventHandler(this.Directory_Click);
            // 
            // Settings
            // 
            this.Settings.Animated = true;
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.BorderColor = System.Drawing.Color.Transparent;
            this.Settings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Settings.CheckedState.ForeColor = System.Drawing.Color.White;
            this.Settings.CheckedState.Image = global::KaffeeUtility.Properties.Resources.settings_pressed;
            this.Settings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Settings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Settings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Settings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Settings.FillColor = System.Drawing.Color.Transparent;
            this.Settings.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Settings.ForeColor = System.Drawing.Color.LightGray;
            this.Settings.Image = global::KaffeeUtility.Properties.Resources.settings_48px;
            this.Settings.ImageSize = new System.Drawing.Size(24, 24);
            this.Settings.Location = new System.Drawing.Point(79, 513);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(32, 32);
            this.Settings.TabIndex = 8;
            this.Settings.UseTransparentBackground = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Injector
            // 
            this.Injector.Animated = true;
            this.Injector.BackColor = System.Drawing.Color.Transparent;
            this.Injector.BorderColor = System.Drawing.Color.Transparent;
            this.Injector.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Injector.CheckedState.ForeColor = System.Drawing.Color.White;
            this.Injector.CheckedState.Image = global::KaffeeUtility.Properties.Resources.syringe_pressed;
            this.Injector.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Injector.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Injector.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Injector.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Injector.FillColor = System.Drawing.Color.Transparent;
            this.Injector.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.Injector.ForeColor = System.Drawing.Color.LightGray;
            this.Injector.Image = global::KaffeeUtility.Properties.Resources.syringe_48px;
            this.Injector.Location = new System.Drawing.Point(0, 138);
            this.Injector.Name = "Injector";
            this.Injector.Size = new System.Drawing.Size(155, 32);
            this.Injector.TabIndex = 7;
            this.Injector.Text = "Injector";
            this.Injector.UseTransparentBackground = true;
            this.Injector.Click += new System.EventHandler(this.Injector_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.FillColor = System.Drawing.Color.Transparent;
            this.Logo.Image = global::KaffeeUtility.Properties.Resources.Kaffee;
            this.Logo.ImageRotate = 0F;
            this.Logo.Location = new System.Drawing.Point(25, 40);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(38, 38);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 4;
            this.Logo.TabStop = false;
            this.Logo.UseTransparentBackground = true;
            // 
            // HomeBtn
            // 
            this.HomeBtn.Animated = true;
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.HomeBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HomeBtn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.HomeBtn.CheckedState.Image = global::KaffeeUtility.Properties.Resources.home_pressed;
            this.HomeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.HomeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.HomeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.HomeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.HomeBtn.FillColor = System.Drawing.Color.Transparent;
            this.HomeBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.HomeBtn.ForeColor = System.Drawing.Color.LightGray;
            this.HomeBtn.Image = global::KaffeeUtility.Properties.Resources.home_48px;
            this.HomeBtn.Location = new System.Drawing.Point(0, 100);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(155, 32);
            this.HomeBtn.TabIndex = 3;
            this.HomeBtn.Text = "Home";
            this.HomeBtn.UseTransparentBackground = true;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // Minimize
            // 
            this.Minimize.Animated = true;
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Minimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Minimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Minimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Minimize.FillColor = System.Drawing.Color.Transparent;
            this.Minimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Image = global::KaffeeUtility.Properties.Resources.mc_yellw;
            this.Minimize.ImageSize = new System.Drawing.Size(12, 12);
            this.Minimize.Location = new System.Drawing.Point(32, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(14, 14);
            this.Minimize.TabIndex = 1;
            this.Minimize.UseTransparentBackground = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.Animated = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Exit.FillColor = System.Drawing.Color.Transparent;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Image = global::KaffeeUtility.Properties.Resources.mc_red;
            this.Exit.ImageSize = new System.Drawing.Size(12, 12);
            this.Exit.Location = new System.Drawing.Point(12, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(14, 14);
            this.Exit.TabIndex = 0;
            this.Exit.UseTransparentBackground = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(972, 548);
            this.Controls.Add(this.TabContainer);
            this.Controls.Add(this.SidePanel);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm ModifyForm;
        private Guna.UI2.WinForms.Guna2Panel SidePanel;
        private Guna.UI2.WinForms.Guna2Button Minimize;
        private Guna.UI2.WinForms.Guna2Button Exit;
        private Guna.UI2.WinForms.Guna2Button HomeBtn;
        private Guna.UI2.WinForms.Guna2Separator Separator;
        private Guna.UI2.WinForms.Guna2PictureBox Logo;
        private Guna.UI2.WinForms.Guna2Button Injector;
        private Guna.UI2.WinForms.Guna2Panel TabContainer;
        private Guna.UI2.WinForms.Guna2DragControl DragSidePanel;
        private System.Windows.Forms.Label Watermark;
        private Guna.UI2.WinForms.Guna2Button Settings;
        private Guna.UI2.WinForms.Guna2Button Directory;
        private Guna.UI2.WinForms.Guna2Button Spoofer;
    }
}