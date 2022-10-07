
namespace WindowsFormsApp1
{
    partial class perfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perfiles));
            this.btnatrasperfiles = new System.Windows.Forms.Button();
            this.userimage = new System.Windows.Forms.PictureBox();
            this.tituloperfiles = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnregresarinterfaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userimage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnatrasperfiles
            // 
            this.btnatrasperfiles.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnatrasperfiles.BackgroundImage")));
            this.btnatrasperfiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnatrasperfiles.FlatAppearance.BorderSize = 0;
            this.btnatrasperfiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnatrasperfiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnatrasperfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnatrasperfiles.Location = new System.Drawing.Point(336, 29);
            this.btnatrasperfiles.Name = "btnatrasperfiles";
            this.btnatrasperfiles.Size = new System.Drawing.Size(65, 47);
            this.btnatrasperfiles.TabIndex = 3;
            this.btnatrasperfiles.UseVisualStyleBackColor = true;
            this.btnatrasperfiles.Click += new System.EventHandler(this.btnatrasperfiles_Click);
            // 
            // userimage
            // 
            this.userimage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userimage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userimage.BackgroundImage")));
            this.userimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.userimage.Location = new System.Drawing.Point(175, 0);
            this.userimage.Name = "userimage";
            this.userimage.Size = new System.Drawing.Size(100, 48);
            this.userimage.TabIndex = 5;
            this.userimage.TabStop = false;
            // 
            // tituloperfiles
            // 
            this.tituloperfiles.AutoSize = true;
            this.tituloperfiles.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloperfiles.ForeColor = System.Drawing.Color.White;
            this.tituloperfiles.Location = new System.Drawing.Point(169, 70);
            this.tituloperfiles.Name = "tituloperfiles";
            this.tituloperfiles.Size = new System.Drawing.Size(109, 33);
            this.tituloperfiles.TabIndex = 1;
            this.tituloperfiles.Text = "PERFILES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnregresarinterfaz);
            this.panel2.Location = new System.Drawing.Point(12, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 572);
            this.panel2.TabIndex = 2;
            // 
            // btnregresarinterfaz
            // 
            this.btnregresarinterfaz.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnregresarinterfaz.FlatAppearance.BorderSize = 0;
            this.btnregresarinterfaz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnregresarinterfaz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnregresarinterfaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregresarinterfaz.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresarinterfaz.ForeColor = System.Drawing.Color.White;
            this.btnregresarinterfaz.Location = new System.Drawing.Point(95, 537);
            this.btnregresarinterfaz.Name = "btnregresarinterfaz";
            this.btnregresarinterfaz.Size = new System.Drawing.Size(225, 35);
            this.btnregresarinterfaz.TabIndex = 3;
            this.btnregresarinterfaz.Text = "Regresar a interfaz";
            this.btnregresarinterfaz.UseVisualStyleBackColor = false;
            this.btnregresarinterfaz.Click += new System.EventHandler(this.btnregresarinterfaz_Click);
            // 
            // perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(442, 701);
            this.Controls.Add(this.btnatrasperfiles);
            this.Controls.Add(this.userimage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tituloperfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "perfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "perfiles";
            ((System.ComponentModel.ISupportInitialize)(this.userimage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox userimage;
        private System.Windows.Forms.Label tituloperfiles;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnatrasperfiles;
        private System.Windows.Forms.Button btnregresarinterfaz;
    }
}