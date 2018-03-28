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
    public partial class frmUsuario : Form
    {
        public List<EUsuario> listarUsua;
        bool modificar;
        public void actualizarGrid() {
            NUsuario gestioUsuario = new NUsuario();
            listarUsua = gestioUsuario.SelectRow();
            var lista = (from usuario in listarUsua
                         select new
                         {

                             usuario.Empleado.nombres,
                             usuario.Empleado.cargo,
                             usuario.usuario,
                             usuario.password,
                             usuario.estado,
                             usuario.Permiso.venta,
                             usuario.Permiso.mantenimiento,
                             usuario.Permiso.lavado,
                             usuario.Permiso.compra,
                             usuario.Permiso.empleado,
                             usuario.Permiso.Tusuario,
                             usuario.Permiso.producto,
                             usuario.Permiso.proveedor,
                             usuario.idUsuario,
                             usuario.Permiso.PidUsuario,
                             usuario.Empleado.idEmpleado,
                         }).ToList();
            dgvUsuarios.DataSource = lista;
            dgvUsuarios.Columns["idUsuario"].Visible = false;
            dgvUsuarios.Columns["PidUsuario"].Visible = false;
            dgvUsuarios.Columns["idEmpleado"].Visible = false;
        }
        public frmUsuario()
        {
            InitializeComponent();
            Deshabilitar();
            btnCancelar.Enabled = false;
        }
        private void Deshabilitar()
        {
            txtContraseña.Enabled = false;
            txtEmpleado.Enabled = false;
            txtNombreUsuario.Enabled = false;
            cmbEstado.Enabled = false;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            
        }
        private void Habilitar()
        {
            txtContraseña.Enabled = true;
            txtEmpleado.Enabled = true;
            txtNombreUsuario.Enabled = true;
            cmbEstado.Enabled = true;
        }

        private void Limpiar()
        {

            txtContraseña.Text = "";
            txtEmpleado.Text = "";
            txtNombreUsuario.Text = "";
            cmbEstado.Text = "";
            chkVenta.Checked = false;
            chkMantenimiento.Checked = false;
            chkLavado.Checked = false;
            chkCompra.Checked = false;
            chkEmpleado.Checked = false;
            chkUsuario.Checked = false;
            chkProducto.Checked = false;
            chkProveedor.Checked = false;
           

        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            try {
                actualizarGrid();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try {
                if (modificar)
                {
                    EUsuario Uusuario = new EUsuario();
                    Uusuario.Permiso.PidUsuario = Convert.ToInt32( txtEmpleado.Tag);
                    Uusuario.idUsuario = Convert.ToInt32(txtNombreUsuario.Tag);
                    Uusuario.usuario = txtNombreUsuario.Text;
                    Uusuario.password = txtContraseña.Text;
                    Uusuario.Empleado.idEmpleado = Convert.ToInt32(txtEmpleado.Text);
                    Uusuario.estado = cmbEstado.Text;
                    Uusuario.Permiso.venta = chkVenta.Checked;
                    Uusuario.Permiso.mantenimiento = chkMantenimiento.Checked;
                    Uusuario.Permiso.lavado = chkLavado.Checked;
                    Uusuario.Permiso.compra = chkCompra.Checked;
                    Uusuario.Permiso.empleado = chkEmpleado.Checked;
                    Uusuario.Permiso.Tusuario = chkUsuario.Checked;
                    Uusuario.Permiso.producto = chkProducto.Checked;
                    Uusuario.Permiso.proveedor = chkProveedor.Checked;

                    NUsuario UpRow = new NUsuario();
                    UpRow.UpdateRow(Uusuario);
                    MessageBox.Show("Se modifico sastifactoriamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else {
                    EUsuario Iusuario = new EUsuario();
                    Iusuario.usuario = txtNombreUsuario.Text;
                    Iusuario.password = txtContraseña.Text;
                    Iusuario.Empleado.idEmpleado = Convert.ToInt32(txtEmpleado.Text);
                    Iusuario.estado = cmbEstado.Text;
                    Iusuario.Permiso.venta = chkVenta.Checked;
                    Iusuario.Permiso.mantenimiento = chkMantenimiento.Checked;
                    Iusuario.Permiso.lavado = chkLavado.Checked;
                    Iusuario.Permiso.compra = chkCompra.Checked;
                    Iusuario.Permiso.empleado = chkEmpleado.Checked;
                    Iusuario.Permiso.Tusuario = chkUsuario.Checked;
                    Iusuario.Permiso.producto = chkProducto.Checked;
                    Iusuario.Permiso.proveedor = chkProveedor.Checked;

                    NUsuario InsertRow = new NUsuario();
                    InsertRow.InsertRow(Iusuario);
                    MessageBox.Show("Se guardo sastifactoriamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                actualizarGrid();
                modificar = false;
            }
            catch ( Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Habilitar();
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
            modificar = true;
        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtEmpleado.Text = dgvUsuarios.Rows[e.RowIndex].Cells["idEmpleado"].Value.ToString();
                txtNombreUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells["usuario"].Value.ToString();
                txtContraseña.Text = dgvUsuarios.Rows[e.RowIndex].Cells["password"].Value.ToString();
                cmbEstado.Text = dgvUsuarios.Rows[e.RowIndex].Cells["estado"].Value.ToString();
                chkVenta.Checked = Convert.ToBoolean(dgvUsuarios.Rows[e.RowIndex].Cells["venta"].Value.ToString());
                chkMantenimiento.Checked = Convert.ToBoolean(dgvUsuarios.Rows[e.RowIndex].Cells["mantenimiento"].Value.ToString());
                chkLavado.Checked = Convert.ToBoolean(dgvUsuarios.Rows[e.RowIndex].Cells["lavado"].Value.ToString());
                chkCompra.Checked = Convert.ToBoolean(dgvUsuarios.Rows[e.RowIndex].Cells["compra"].Value.ToString());
                chkEmpleado.Checked = Convert.ToBoolean(dgvUsuarios.Rows[e.RowIndex].Cells["empleado"].Value.ToString());
                chkUsuario.Checked = Convert.ToBoolean(dgvUsuarios.Rows[e.RowIndex].Cells["Tusuario"].Value.ToString());
                chkProducto.Checked = Convert.ToBoolean(dgvUsuarios.Rows[e.RowIndex].Cells["producto"].Value.ToString());
                chkProveedor.Checked = Convert.ToBoolean(dgvUsuarios.Rows[e.RowIndex].Cells["proveedor"].Value.ToString());
                txtEmpleado.Tag = dgvUsuarios.Rows[e.RowIndex].Cells["idUsuario"].Value.ToString();
                txtNombreUsuario.Tag = dgvUsuarios.Rows[e.RowIndex].Cells["PidUsuario"].Value.ToString();

                btnModificar.Enabled = true;
                btnCancelar.Enabled = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = false;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();
            txtNombreUsuario.Focus();
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Deshabilitar();
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            frmInicio inicio = new frmInicio();
            inicio.Show();
            this.Close();
        }
    }
}
