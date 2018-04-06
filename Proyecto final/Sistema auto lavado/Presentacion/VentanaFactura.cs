using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion;

namespace Presentacion
{
    public partial class VentanaFactura : Form
    {
        public VentanaFactura()
        {
            InitializeComponent();
        }


    

        private void VentanaFactura_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmMenuprincipal inicio = new frmMenuprincipal();
            inicio.Show();
            this.Close();
        }
    }
}
