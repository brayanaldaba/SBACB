using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

     

        private void bottoncerrar_Enter(object sender, EventArgs e)
        {
            if(txtuser.Text == ""){
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
    }

        private void bottoncerrar_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == ""){
                txtuser.Text = "";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if(txtpass.Text == ""){
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;

                }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if(txtpass.Text==""){
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
    }
}

        private void acceder(object sender, EventArgs e)
        {
            interfaz ventana = new interfaz();
            ventana.Show();
            this.Hide();

        }
        


        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void usuariotx(object sender, EventArgs e)
        {

        }

        private void contraseñatx(object sender, EventArgs e)
        {

        }

        private void buttonRegitrar_Click(object sender, EventArgs e)
        {
            Form inicio = new registro();
            inicio.Show();
            this.Hide();


        }

        private void buttocerrarlogin(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bottonminilogin(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }


