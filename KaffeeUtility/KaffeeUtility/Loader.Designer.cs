namespace KaffeeUtility
{
    partial class Loader
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
            this.ModifyForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.Exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ProgressCircle = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.VerboseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ModifyForm
            // 
            this.ModifyForm.BorderRadius = 16;
            this.ModifyForm.ContainerControl = this;
            this.ModifyForm.DockIndicatorTransparencyValue = 0.6D;
            this.ModifyForm.TransparentWhileDrag = true;
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Animated = true;
            this.Exit.BackColor = System.Drawing.Color.Transparent;
            this.Exit.BorderRadius = 16;
            this.Exit.FillColor = System.Drawing.Color.Transparent;
            this.Exit.IconColor = System.Drawing.Color.Silver;
            this.Exit.Location = new System.Drawing.Point(418, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(29, 29);
            this.Exit.TabIndex = 0;
            this.Exit.UseTransparentBackground = true;
            // 
            // ProgressCircle
            // 
            this.ProgressCircle.Animated = true;
            this.ProgressCircle.BackColor = System.Drawing.Color.Transparent;
            this.ProgressCircle.FillColor = System.Drawing.Color.Gray;
            this.ProgressCircle.FillThickness = 14;
            this.ProgressCircle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProgressCircle.ForeColor = System.Drawing.Color.White;
            this.ProgressCircle.Location = new System.Drawing.Point(97, 86);
            this.ProgressCircle.Maximum = 7;
            this.ProgressCircle.Minimum = 0;
            this.ProgressCircle.Name = "ProgressCircle";
            this.ProgressCircle.ProgressColor = System.Drawing.Color.MediumPurple;
            this.ProgressCircle.ProgressColor2 = System.Drawing.Color.DarkViolet;
            this.ProgressCircle.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ProgressCircle.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.ProgressCircle.ProgressThickness = 14;
            this.ProgressCircle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressCircle.ShowText = true;
            this.ProgressCircle.Size = new System.Drawing.Size(265, 265);
            this.ProgressCircle.TabIndex = 1;
            this.ProgressCircle.UseTransparentBackground = true;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.LightGray;
            this.StatusLabel.Location = new System.Drawing.Point(12, 354);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(435, 20);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Starting";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VerboseLabel
            // 
            this.VerboseLabel.BackColor = System.Drawing.Color.Transparent;
            this.VerboseLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerboseLabel.ForeColor = System.Drawing.Color.Gray;
            this.VerboseLabel.Location = new System.Drawing.Point(12, 374);
            this.VerboseLabel.Name = "VerboseLabel";
            this.VerboseLabel.Size = new System.Drawing.Size(435, 20);
            this.VerboseLabel.TabIndex = 3;
            this.VerboseLabel.Text = "Nothing";
            this.VerboseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Loader
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(459, 436);
            this.Controls.Add(this.VerboseLabel);
            this.Controls.Add(this.ProgressCircle);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.StatusLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kaffee Loader";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm ModifyForm;
        private Guna.UI2.WinForms.Guna2ControlBox Exit;
        public Guna.UI2.WinForms.Guna2CircleProgressBar ProgressCircle;
        public System.Windows.Forms.Label StatusLabel;
        public System.Windows.Forms.Label VerboseLabel;
    }
}

