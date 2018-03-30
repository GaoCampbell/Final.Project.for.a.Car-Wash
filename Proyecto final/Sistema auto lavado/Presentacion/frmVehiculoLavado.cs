using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class frmVehiculoLavado : Form
    {
        public List<EVehiculoLavado> listaVehiculo;
        bool modificar;
        public frmVehiculoLavado()
        {
            InitializeComponent();
            Deshabilitar();
        }
        private void Deshabilitar()
        {
            txtvehiculo.Enabled = false;
            
        }

        private void Habilitar()
        {
            txtvehiculo.Enabled = true;
            
        }

        private void Limpiar()
        {

            txtvehiculo.Text = "";
        }
        public void actualizarGrid() {
            NVehiculoLavado listar = new NVehiculoLavado();
            listaVehiculo = listar.SelectRow();
        }
        private void frmVehiculoLavado_Load(object sender, EventArgs e)
        {
            try {
                actualizarGrid();
                dgvVehiculoLavado.DataSource = listaVehiculo;

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvVehiculoLavado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Habilitar();
            btncancelar.Enabled = true;
            btnguardar.Enabled = true;
            btnmodificar.Enabled = false;
            btnnuevo.Enabled = false;
            modificar = true;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try {
                if (modificar) {
                    EVehiculoLavado UpdateVL = new EVehiculoLavado();
                    UpdateVL.vehiculoLavado = txtvehiculo.Text;
                    UpdateVL.idVehiculoLavado = Convert.ToInt32(txtvehiculo.Tag);
                    NVehiculoLavado update = new NVehiculoLavado();
                    update.UpdaetRow(UpdateVL);
                    MessageBox.Show("Modificado","Vehiculo Lavado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else {
                    EVehiculoLavado InsertVL = new EVehiculoLavado();
                    InsertVL.vehiculoLavado = txtvehiculo.Text;
                    NVehiculoLavado Insert = new NVehiculoLavado();
                    Insert.InsertRow(InsertVL);
                    MessageBox.Show("Guardado", "Vehiculo Lavado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                actualizarGrid();
                dgvVehiculoLavado.DataSource = listaVehiculo;
                Limpiar();
                Deshabilitar();
                btncancelar.Enabled = false;
                btnguardar.Enabled = false;
                btnmodificar.Enabled = false;
                btnnuevo.Enabled = true;
                modificar = false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvVehiculoLavado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                txtvehiculo.Text = dgvVehiculoLavado.Rows[e.RowIndex].Cells["vehiculoLavado"].Value.ToString();
                txtvehiculo.Tag = dgvVehiculoLavado.Rows[e.RowIndex].Cells["idVehiculoLavado"].Value.ToString();
                btnmodificar.Enabled = true;
                btncancelar.Enabled = true;
                btnguardar.Enabled = false;
                btnnuevo.Enabled = false;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();
            txtvehiculo.Focus();
            btncancelar.Enabled = true;
            btnguardar.Enabled = true;
            btnmodificar.Enabled = false;
            btnnuevo.Enabled = false;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Deshabilitar();
            btnnuevo.Enabled = true;
            btnguardar.Enabled = false;
            btnmodificar.Enabled = false;
            btncancelar.Enabled = false;
        }
    }
}
