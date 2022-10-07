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
    public partial class perfiles : Form
    {
        public perfiles()
        {
            InitializeComponent();
        }

        private void btnatrasperfiles_Click(object sender, EventArgs e)
        {
            inicio ventana = new inicio();
            ventana.Show();
            this.Hide();
        }

        private void btnregresarinterfaz_Click(object sender, EventArgs e)
        {
            interfaz ventana = new interfaz();
            ventana.Show();
                this.Hide();
        }
    }
}
