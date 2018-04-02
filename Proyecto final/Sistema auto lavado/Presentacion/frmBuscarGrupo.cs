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
    public partial class frmBuscarGrupo : Form
    {
        public int idGrupo;
        public frmBuscarGrupo()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBuscarGrupo_Load(object sender, EventArgs e)
        {
            try
            {
                NGrupoTrabajadores gestioG = new NGrupoTrabajadores();
                List<EGrupoTrabajadores> list = gestioG.obtenerLista();
                dgvBuscarGrupo.DataSource = list;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPelicula_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                idGrupo = Convert.ToInt32(dgvBuscarGrupo.Rows[e.RowIndex].Cells["idGrupo"].Value.ToString());
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
