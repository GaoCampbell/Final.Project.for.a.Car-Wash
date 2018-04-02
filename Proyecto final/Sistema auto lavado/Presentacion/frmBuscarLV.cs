using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class frmBuscarLV : Form
    {
        public int idLavadoVehiculo;
        public decimal precio;
        public frmBuscarLV()
        {
            InitializeComponent();
        }

        private void frmBuscarLV_Load(object sender, EventArgs e)
        {
            try
            {
                NLavadoVehiculos listarLV = new NLavadoVehiculos();
                List<ELavadoVehiculo> LV = listarLV.selectRow();
                var lista = (from lavadoVehiculo in LV
                             select new
                             {
                                 lavadoVehiculo.idLavadoVehiculo,
                                 lavadoVehiculo.servicioLavado.idServicioLavado,
                                 lavadoVehiculo.vehiculoLavado.idVehiculoLavado,
                                 lavadoVehiculo.vehiculoLavado.vehiculoLavado,
                                 lavadoVehiculo.servicioLavado.servicioLavado,
                                 lavadoVehiculo.precio,
                             }).ToList();
                dgvLavadoVehiculo.DataSource = lista;
                dgvLavadoVehiculo.Columns["idLavadoVehiculo"].Visible = false;
                dgvLavadoVehiculo.Columns["idServicioLavado"].Visible = false;
                dgvLavadoVehiculo.Columns["idVehiculoLavado"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvLavadoVehiculo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                idLavadoVehiculo = Convert.ToInt32( dgvLavadoVehiculo.Rows[e.RowIndex].Cells["idLavadoVehiculo"].Value.ToString());
                precio = Convert.ToDecimal(dgvLavadoVehiculo.Rows[e.RowIndex].Cells["precio"].Value.ToString());
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
