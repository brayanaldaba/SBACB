
namespace WindowsFormsApp1
{
    partial class inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inicio));
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.Button();
            this.bottoncerrar = new System.Windows.Forms.Button();
            this.buttonminimizar = new System.Windows.Forms.Button();
            this.buttonRegitrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.White;
            this.txtuser.Location = new System.Drawing.Point(454, 229);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(178, 24);
            this.txtuser.TabIndex = 0;
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.Color.White;
            this.txtpass.Location = new System.Drawing.Point(454, 324);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(178, 24);
            this.txtpass.TabIndex = 1;
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpass.TextChanged += new System.EventHandler(this.txtpass_TextChanged);
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.ForeColor = System.Drawing.Color.White;
            this.usuario.Location = new System.Drawing.Point(313, 233);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(116, 20);
            this.usuario.TabIndex = 2;
            this.usuario.Text = "USUARIO       :";
            this.usuario.Click += new System.EventHandler(this.usuariotx);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(298, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "CONTRASEÑA  :";
            this.label1.Click += new System.EventHandler(this.contraseñatx);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(425, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 47);
            this.label2.TabIndex = 4;
            this.label2.Text = "LOGIN";
            this.label2.Click += new System.EventHandler(this.label2_Click_2);
            // 
            // txtlogin
            // 
            this.txtlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtlogin.FlatAppearance.BorderSize = 0;
            this.txtlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlogin.ForeColor = System.Drawing.Color.White;
            this.txtlogin.Location = new System.Drawing.Point(366, 421);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(257, 58);
            this.txtlogin.TabIndex = 3;
            this.txtlogin.Text = "ACCEDER";
            this.txtlogin.UseVisualStyleBackColor = false;
            this.txtlogin.Click += new System.EventHandler(this.acceder);
            // 
            // bottoncerrar
            // 
            this.bottoncerrar.BackColor = System.Drawing.Color.Transparent;
            this.bottoncerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottoncerrar.BackgroundImage")));
            this.bottoncerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bottoncerrar.FlatAppearance.BorderSize = 0;
            this.bottoncerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.bottoncerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.bottoncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottoncerrar.Location = new System.Drawing.Point(638, 23);
            this.bottoncerrar.Name = "bottoncerrar";
            this.bottoncerrar.Size = new System.Drawing.Size(39, 33);
            this.bottoncerrar.TabIndex = 0;
            this.bottoncerrar.UseVisualStyleBackColor = false;
            this.bottoncerrar.Click += new System.EventHandler(this.buttocerrarlogin);
            this.bottoncerrar.Enter += new System.EventHandler(this.bottoncerrar_Enter);
            this.bottoncerrar.Leave += new System.EventHandler(this.bottoncerrar_Leave);
            // 
            // buttonminimizar
            // 
            this.buttonminimizar.BackColor = System.Drawing.Color.Transparent;
            this.buttonminimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonminimizar.BackgroundImage")));
            this.buttonminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonminimizar.FlatAppearance.BorderSize = 0;
            this.buttonminimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.buttonminimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.buttonminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonminimizar.Location = new System.Drawing.Point(593, 27);
            this.buttonminimizar.Name = "buttonminimizar";
            this.buttonminimizar.Size = new System.Drawing.Size(39, 24);
            this.buttonminimizar.TabIndex = 6;
            this.buttonminimizar.UseVisualStyleBackColor = false;
            this.buttonminimizar.Click += new System.EventHandler(this.bottonminilogin);
            // 
            // buttonRegitrar
            // 
            this.buttonRegitrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonRegitrar.FlatAppearance.BorderSize = 0;
            this.buttonRegitrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonRegitrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRegitrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegitrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegitrar.ForeColor = System.Drawing.Color.White;
            this.buttonRegitrar.Location = new System.Drawing.Point(435, 530);
            this.buttonRegitrar.Name = "buttonRegitrar";
            this.buttonRegitrar.Size = new System.Drawing.Size(111, 29);
            this.buttonRegitrar.TabIndex = 7;
            this.buttonRegitrar.Text = "REGISTRARSE";
            this.buttonRegitrar.UseVisualStyleBackColor = false;
            this.buttonRegitrar.Click += new System.EventHandler(this.buttonRegitrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 653);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 438);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 215);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(699, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonminimizar);
            this.Controls.Add(this.buttonRegitrar);
            this.Controls.Add(this.bottoncerrar);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inicio";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtlogin;
        private System.Windows.Forms.Button bottoncerrar;
        private System.Windows.Forms.Button buttonminimizar;
        private System.Windows.Forms.Button buttonRegitrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

