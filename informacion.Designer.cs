
namespace WindowsFormsApp1
{
    partial class informacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informacion));
            this.btonatrasdeinfo = new System.Windows.Forms.Button();
            this.panelinfo2 = new System.Windows.Forms.Panel();
            this.txtinfogeneral = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelinfo2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btonatrasdeinfo
            // 
            this.btonatrasdeinfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btonatrasdeinfo.BackgroundImage")));
            this.btonatrasdeinfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btonatrasdeinfo.FlatAppearance.BorderSize = 0;
            this.btonatrasdeinfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btonatrasdeinfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btonatrasdeinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btonatrasdeinfo.Location = new System.Drawing.Point(12, 11);
            this.btonatrasdeinfo.Name = "btonatrasdeinfo";
            this.btonatrasdeinfo.Size = new System.Drawing.Size(71, 51);
            this.btonatrasdeinfo.TabIndex = 2;
            this.btonatrasdeinfo.UseVisualStyleBackColor = true;
            this.btonatrasdeinfo.Click += new System.EventHandler(this.btonatrasdeinfo_Click);
            // 
            // panelinfo2
            // 
            this.panelinfo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelinfo2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelinfo2.Controls.Add(this.txtinfogeneral);
            this.panelinfo2.Location = new System.Drawing.Point(266, 586);
            this.panelinfo2.Name = "panelinfo2";
            this.panelinfo2.Size = new System.Drawing.Size(532, 58);
            this.panelinfo2.TabIndex = 1;
            // 
            // txtinfogeneral
            // 
            this.txtinfogeneral.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtinfogeneral.AutoSize = true;
            this.txtinfogeneral.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinfogeneral.ForeColor = System.Drawing.Color.White;
            this.txtinfogeneral.Location = new System.Drawing.Point(101, 24);
            this.txtinfogeneral.Name = "txtinfogeneral";
            this.txtinfogeneral.Size = new System.Drawing.Size(347, 25);
            this.txtinfogeneral.TabIndex = 2;
            this.txtinfogeneral.Text = "Mas que un software es ua solucion. . . !";
            this.txtinfogeneral.Click += new System.EventHandler(this.txtinfogeneral_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btonatrasdeinfo);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 643);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 450);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 193);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelinfo2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "informacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "informacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelinfo2.ResumeLayout(false);
            this.panelinfo2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelinfo2;
        private System.Windows.Forms.Label txtinfogeneral;
        private System.Windows.Forms.Button btonatrasdeinfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}