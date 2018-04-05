using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmVentanaFactura : Form
    {
        public frmVentanaFactura()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmCompra c = new frmCompra();
            c.Show(); this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmCompra c = new frmCompra();
            c.Show(); this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           frmVenta c = new frmVenta();
            c.Show(); this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmVenta c = new frmVenta();
            c.Show();
            this.Close();
        }
    }
}
