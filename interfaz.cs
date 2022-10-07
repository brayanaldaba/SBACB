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
    public partial class interfaz : Form
    {
        public interfaz()
        {
            InitializeComponent();
   
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void interfaz_Load(object sender, EventArgs e)
        {

        }

        private void bottoncerrarinterfaz(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonatrasinterf_Click(object sender, EventArgs e)
        {
            Form inicio = new inicio();
            inicio.Show();
            this.Hide();
        }

        private void reseña_Click(object sender, EventArgs e)
        {

        }

        private void botoninfpanel_Click(object sender, EventArgs e)
        {
            informacion ventana = new informacion();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btonperfiles_Click(object sender, EventArgs e)
        {
            perfiles ventana = new perfiles();
            ventana.Show();
            this.Hide();
        }

        private void registrocompras_Click(object sender, EventArgs e)
        {

        }

        private void registroventas_Click(object sender, EventArgs e)
        {

        }

        private void button2perfiles_Click(object sender, EventArgs e)
        {
            perfiles ventana = new perfiles();
            ventana.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
