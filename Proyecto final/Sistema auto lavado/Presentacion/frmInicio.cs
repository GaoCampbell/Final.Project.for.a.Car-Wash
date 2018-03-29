﻿using System;
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
            this.Hide();
            frmUsuario _frmUsuario = new frmUsuario();
            _frmUsuario.Show();
            //this.Hide();
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
           
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void eMPLEADOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           this.Hide();
            frmEmpleado empleado = new frmEmpleado();
            empleado.Show();
            
        }

        private void aREAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmArea area = new frmArea();
            area.Show();
            
        }

        private void gRUPOTRABAJADORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGrupoTrabajadores gt = new frmGrupoTrabajadores();
            gt.Show();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void sERVICIOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmServicioMantenimiento sm = new frmServicioMantenimiento();
            sm.Show();
        }

        private void mANTENIMIENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vEHICULOMANTENIMINETOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVehiculoMan VM = new frmVehiculoMan();
            VM.Show();
        }

        private void pROVEEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProveedor pro = new frmProveedor();
            pro.Show();
        }
    }
}
