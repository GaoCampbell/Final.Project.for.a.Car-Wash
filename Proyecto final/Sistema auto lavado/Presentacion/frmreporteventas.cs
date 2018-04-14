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
    public partial class frmreporteventas : Form
    {
        public frmreporteventas()
        {
            InitializeComponent();
        }

        public int Idventa { get; set; }

        public int Numventa { get; set; }

        private void frmreporteventas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.reporteventa' Puede moverla o quitarla según sea necesario.
            this.reporteventaTableAdapter.Fill(this.DataSet1.reporteventa,Idventa);
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.getdetalleventa' Puede moverla o quitarla según sea necesario.
            this.getdetalleventaTableAdapter.Fill(this.DataSet1.getdetalleventa,Numventa);

            this.reportViewer1.RefreshReport();
        }
    }
}
