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
    public partial class frmventanaproducto : Form
    {
        public frmventanaproducto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmProductos s = new frmProductos();
            s.Show(); this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmProductos s = new frmProductos();
            s.Show(); this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmAlmacen a = new frmAlmacen();
            a.Show(); this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            frmAlmacen a = new frmAlmacen();
            a.Show(); this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmCategoria c = new frmCategoria();
            c.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmCategoria c = new frmCategoria();
            c.Show();
            this.Close();
        }
    }
}
