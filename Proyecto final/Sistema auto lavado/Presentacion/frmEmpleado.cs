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
    public partial class frmEmpleado : Form
    {
        List<EEmpleado> listaEmpleado;
        bool modificar;
        public frmEmpleado()
        {
            InitializeComponent();
            Deshabilitar();
        }
        private void Deshabilitar()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtcedula.Enabled = false;
            txtcelular.Enabled = false;
            txtdireccion.Enabled = false;
            txtFechaNac.Enabled = false;
            txtSalario.Enabled = false;
            cmbcargo.Enabled = false;
            cmbEstado.Enabled = false;
            btnguardar.Enabled = false;
            btnModificar.Enabled = false;
            btnCancelar.Enabled = false;
        }
        private void Habilitar()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtcedula.Enabled = true;
            txtcelular.Enabled = true;
            txtdireccion.Enabled = true;
            txtFechaNac.Enabled = true;
            txtSalario.Enabled = true;
            cmbcargo.Enabled = true;
            cmbEstado.Enabled = true;
        }
        private void Limpiar()
        {
            txtNombre.Text ="";
            txtApellido.Text = "";
            txtcedula.Text = "";
            txtcelular.Text = "";
            txtdireccion.Text = "";
            txtFechaNac.Text = "";
            txtSalario.Text = "";
            cmbcargo.Text = "";
            cmbEstado.Text = "";
            txtArea.Text = "";
            txtGrupo.Text = "";
        }
        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            txtArea.Enabled = false;
            txtGrupo.Enabled = false;
            try {
                actualizarGrid();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void actualizarGrid()
        {
            NEmpleado gestioEmpleado = new NEmpleado();
           listaEmpleado = gestioEmpleado.listaEmpleado();

            var lista = (from empleado in listaEmpleado
                         select new
                         {
                             empleado.idEmpleado,
                             empleado.GrupoTrabajadores.idGrupo,
                             empleado.Area.idArea,
                             empleado.nombres,
                             empleado.apellidos,
                             empleado.fechaNacimiento,
                             empleado.cedula,
                             empleado.direccion,
                             empleado.celular,
                             empleado.salario,
                             empleado.cargo,
                             empleado.estado,
                             empleado.Area.area,
                             empleado.GrupoTrabajadores.grupoTrabajadores,
                         }).ToList();
            dgvEmpleado.DataSource = lista;
            dgvEmpleado.Columns["idEmpleado"].Visible = false;
            dgvEmpleado.Columns["idGrupo"].Visible = false;
            dgvEmpleado.Columns["idArea"].Visible = false;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try {
                if (modificar)
                {
                    EEmpleado UEmpleado = new EEmpleado();
                    UEmpleado.idEmpleado = Convert.ToInt32(txtNombre.Tag);
                    UEmpleado.apellidos = txtApellido.Text;
                    UEmpleado.cedula = txtcedula.Text;
                    UEmpleado.celular = Convert.ToInt32(txtcelular.Text);
                    UEmpleado.direccion = txtdireccion.Text;
                    UEmpleado.estado = cmbEstado.Text;
                    UEmpleado.fechaNacimiento = Convert.ToDateTime(txtFechaNac.Text);
                    UEmpleado.salario = Convert.ToDecimal(txtSalario.Text);
                    UEmpleado.nombres = txtNombre.Text;
                    UEmpleado.cargo = cmbcargo.Text;
                    UEmpleado.GrupoTrabajadores.idGrupo = Convert.ToInt32(txtGrupo.Text);
                    UEmpleado.Area.idArea = Convert.ToInt32(txtArea.Text);
                    NEmpleado Update = new NEmpleado();
                    Update.UpdateRow(UEmpleado);
                    MessageBox.Show("Se modifico sastifactoriamente", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                        EEmpleado IEmpleado = new EEmpleado();
                        IEmpleado.apellidos = txtApellido.Text;
                        IEmpleado.cedula = txtcedula.Text;
                        IEmpleado.celular = Convert.ToInt32(txtcelular.Text);
                        IEmpleado.direccion = txtdireccion.Text;
                        IEmpleado.estado = cmbEstado.Text;
                        IEmpleado.fechaNacimiento = Convert.ToDateTime(txtFechaNac.Text);
                        IEmpleado.salario = Convert.ToDecimal(txtSalario.Text);
                        IEmpleado.nombres = txtNombre.Text;
                        IEmpleado.cargo = cmbcargo.Text;
                        IEmpleado.GrupoTrabajadores.idGrupo = Convert.ToInt32(txtGrupo.Text);
                        IEmpleado.Area.idArea = Convert.ToInt32(txtArea.Text);
                        NEmpleado Insert = new NEmpleado();
                        Insert.InserRow(IEmpleado);
                        MessageBox.Show("Se guardo sastifactoriamente", "Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                actualizarGrid();
                Limpiar();
                Deshabilitar();
                btnCancelar.Enabled = false;
                btnguardar.Enabled = false;
                btnModificar.Enabled = false;
                btnNuevo.Enabled = true;
                modificar = false;
                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
            frmInicio inicio = new frmInicio();
            inicio.Show();
           
        }

        private void dgvEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                txtNombre.Text = dgvEmpleado.Rows[e.RowIndex].Cells["nombres"].Value.ToString();
                txtApellido.Text = dgvEmpleado.Rows[e.RowIndex].Cells["apellidos"].Value.ToString();
                txtArea.Text = dgvEmpleado.Rows[e.RowIndex].Cells["idArea"].Value.ToString();
                txtcedula.Text = dgvEmpleado.Rows[e.RowIndex].Cells["cedula"].Value.ToString();
                txtcelular.Text = dgvEmpleado.Rows[e.RowIndex].Cells["celular"].Value.ToString();
                txtdireccion.Text = dgvEmpleado.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                txtFechaNac.Text = dgvEmpleado.Rows[e.RowIndex].Cells["fechaNacimiento"].Value.ToString();
                txtGrupo.Text = dgvEmpleado.Rows[e.RowIndex].Cells["idGrupo"].Value.ToString();
                txtSalario.Text = dgvEmpleado.Rows[e.RowIndex].Cells["salario"].Value.ToString();
                txtNombre.Tag = dgvEmpleado.Rows[e.RowIndex].Cells["idEmpleado"].Value.ToString(); 
                cmbEstado.Text = dgvEmpleado.Rows[e.RowIndex].Cells["estado"].Value.ToString();
                cmbcargo.Text = dgvEmpleado.Rows[e.RowIndex].Cells["cargo"].Value.ToString();
                btnCancelar.Enabled = true;
                btnguardar.Enabled = false;
                btnModificar.Enabled = true;
                btnNuevo.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Habilitar();
            btnCancelar.Enabled = true;
            btnguardar.Enabled = true;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
            txtArea.Enabled = false;
            txtGrupo.Enabled = false;
            modificar = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();
            btnCancelar.Enabled = true;
            btnguardar.Enabled = true;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
            txtArea.Enabled = false;
            txtGrupo.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Deshabilitar();
            btnCancelar.Enabled = false;
            btnguardar.Enabled = false;
            btnModificar.Enabled = false;
            btnNuevo.Enabled = true;
            txtArea.Enabled = false;
            txtGrupo.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
