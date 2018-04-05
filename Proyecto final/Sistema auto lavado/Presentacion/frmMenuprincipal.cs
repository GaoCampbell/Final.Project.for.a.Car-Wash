using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class frmMenuprincipal : Form
    {
        public frmMenuprincipal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (Menuvertical.Width == 250)
            {
                Menuvertical.Width = 70;
            }
            else

                Menuvertical.Width = 250;

        }

        private void iconocerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconomaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            iconomaximizar.Visible = false;
            iconorestaurar.Visible = true;

        }

        private void iconorestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconomaximizar.Visible = true;
            iconorestaurar.Visible = false;
        }

        private void iconominimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Barratitulo_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Menuvertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormInPanel(object FormHijo)

        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;

            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();


        }
     

        private void btnfacturar_Click(object sender, EventArgs e)
        {
         

            



        }

        private void btnpersonas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmProductos());
        }

        private void btnmantenimiento_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmMantenimineto());
        }

        private void btnusuario_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmUsuario());
        }

        private void btncerrarsecion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new frmVenta());
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void cOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
