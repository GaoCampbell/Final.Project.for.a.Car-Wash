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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
           
        }
        
        private void uSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario _frmUsuario = new frmUsuario();
            _frmUsuario.Show();
            this.Hide();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = Global.usuarioSesion.usuario;
            vENTAToolStripMenuItem1.Enabled = Global.usuarioSesion.Permiso.venta;
            mANTENIMIENTOToolStripMenuItem.Enabled = Global.usuarioSesion.Permiso.mantenimiento;
            lAVADOToolStripMenuItem1.Enabled = Global.usuarioSesion.Permiso.lavado;
            cOMPRAToolStripMenuItem.Enabled = Global.usuarioSesion.Permiso.compra;
            eMPLEADOToolStripMenuItem1.Enabled = Global.usuarioSesion.Permiso.empleado;
            uSUARIOToolStripMenuItem.Enabled = Global.usuarioSesion.Permiso.Tusuario;
            pRODUCTOToolStripMenuItem1.Enabled = Global.usuarioSesion.Permiso.producto;
            pROVEEDORToolStripMenuItem.Enabled = Global.usuarioSesion.Permiso.proveedor;
            DateTime hoy = DateTime.Today;
            time.Text = hoy.ToString();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void eMPLEADOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEmpleado empleado = new frmEmpleado();
            empleado.Show();
            this.Hide();
        }

        private void aREAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArea area = new frmArea();
            area.Show();
            this.Hide();
        }

        private void gRUPOTRABAJADORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrupoTrabajadores gt = new frmGrupoTrabajadores();
            gt.Show();
            this.Hide();
        }
    }
}
