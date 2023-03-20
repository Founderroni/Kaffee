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
            this.ClientLabel = new System.Windows.Forms.Label();
            this.ClientList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Inject = new Guna.UI2.WinForms.Guna2Button();
            this.VersionSupport = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ClientPanel.SuspendLayout();
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
            this.ClientPanel.Location = new System.Drawing.Point(255, 91);
            this.ClientPanel.Name = "ClientPanel";
            this.ClientPanel.ShadowDecoration.Depth = 0;
            this.ClientPanel.Size = new System.Drawing.Size(301, 141);
            this.ClientPanel.TabIndex = 7;
            this.ClientPanel.UseTransparentBackground = true;
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
            // VersionSupport
            // 
            this.VersionSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.VersionSupport.AutoSize = false;
            this.VersionSupport.BackColor = System.Drawing.Color.Transparent;
            this.VersionSupport.Location = new System.Drawing.Point(3, 106);
            this.VersionSupport.Name = "VersionSupport";
            this.VersionSupport.Size = new System.Drawing.Size(295, 17);
            this.VersionSupport.TabIndex = 5;
            this.VersionSupport.Text = "Supported Version: <b>N/A</b>";
            this.VersionSupport.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Injector
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.ClientPanel);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "Injector";
            this.Size = new System.Drawing.Size(811, 548);
            this.Load += new System.EventHandler(this.Injector_Load);
            this.ClientPanel.ResumeLayout(false);
            this.ClientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ClientPanel;
        private System.Windows.Forms.Label ClientLabel;
        private Guna.UI2.WinForms.Guna2ComboBox ClientList;
        private Guna.UI2.WinForms.Guna2Button Inject;
        private Guna.UI2.WinForms.Guna2HtmlLabel VersionSupport;
    }
}
