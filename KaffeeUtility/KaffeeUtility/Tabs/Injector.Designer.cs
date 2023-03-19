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
            this.ClientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientPanel
            // 
            this.ClientPanel.BackColor = System.Drawing.Color.Transparent;
            this.ClientPanel.Controls.Add(this.ClientLabel);
            this.ClientPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientPanel.Location = new System.Drawing.Point(295, 79);
            this.ClientPanel.Name = "ClientPanel";
            this.ClientPanel.ShadowDecoration.Depth = 0;
            this.ClientPanel.Size = new System.Drawing.Size(190, 151);
            this.ClientPanel.TabIndex = 7;
            this.ClientPanel.UseTransparentBackground = true;
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.ForeColor = System.Drawing.Color.Gray;
            this.ClientLabel.Location = new System.Drawing.Point(72, 0);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(46, 15);
            this.ClientLabel.TabIndex = 2;
            this.ClientLabel.Text = "Clients";
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
            this.ClientPanel.ResumeLayout(false);
            this.ClientPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel ClientPanel;
        private System.Windows.Forms.Label ClientLabel;
    }
}
