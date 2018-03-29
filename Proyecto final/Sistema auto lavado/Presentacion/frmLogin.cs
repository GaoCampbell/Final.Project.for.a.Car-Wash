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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try {
                Negocio.NUsuario gestion = new Negocio.NUsuario();
                Entidades.EUsuario usuario = gestion.login(txtUsuario.Text,txtContraseña.Text);
                if (usuario.Empleado.nombres != null)
                {
                    Global.usuarioSesion = usuario;
                    DialogResult = DialogResult.OK;
                }
                else {
                    MessageBox.Show("Usuario incorrecto");
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
