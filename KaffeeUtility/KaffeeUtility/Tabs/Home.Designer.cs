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
            this.InjectorPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Version = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Launches = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.InjectorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InjectorPanel
            // 
            this.InjectorPanel.BackColor = System.Drawing.Color.Transparent;
            this.InjectorPanel.Controls.Add(this.Version);
            this.InjectorPanel.Controls.Add(this.Launches);
            this.InjectorPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.InjectorPanel.Location = new System.Drawing.Point(43, 35);
            this.InjectorPanel.Name = "InjectorPanel";
            this.InjectorPanel.ShadowDecoration.Depth = 0;
            this.InjectorPanel.Size = new System.Drawing.Size(190, 82);
            this.InjectorPanel.TabIndex = 0;
            this.InjectorPanel.UseTransparentBackground = true;
            // 
            // Version
            // 
            this.Version.BackColor = System.Drawing.Color.Transparent;
            this.Version.ForeColor = System.Drawing.Color.LightGray;
            this.Version.Location = new System.Drawing.Point(32, 44);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(81, 15);
            this.Version.TabIndex = 1;
            this.Version.Text = "File Version: <b>1.0</b>";
            // 
            // Launches
            // 
            this.Launches.BackColor = System.Drawing.Color.Transparent;
            this.Launches.ForeColor = System.Drawing.Color.LightGray;
            this.Launches.Location = new System.Drawing.Point(32, 21);
            this.Launches.Name = "Launches";
            this.Launches.Size = new System.Drawing.Size(63, 15);
            this.Launches.TabIndex = 0;
            this.Launches.Text = "Launches: <b>0</b>";
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.InjectorPanel);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "Home";
            this.Size = new System.Drawing.Size(811, 548);
            this.Load += new System.EventHandler(this.Home_Load);
            this.InjectorPanel.ResumeLayout(false);
            this.InjectorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel InjectorPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel Version;
        private Guna.UI2.WinForms.Guna2HtmlLabel Launches;
    }
}
