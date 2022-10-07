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
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void registro_Load(object sender, EventArgs e)
        {

        }

        private void btonretrocereguser_Click(object sender, EventArgs e)
        {
            inicio ventana = new inicio();
            ventana.Show();
            this.Hide();
        }

        private void txparanombre(object sender, EventArgs e)
        {

        }

        private void texttelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
