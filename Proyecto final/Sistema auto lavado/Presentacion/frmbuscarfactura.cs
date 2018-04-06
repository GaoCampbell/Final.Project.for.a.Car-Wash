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
    public partial class frmbuscarfactura : Form
    {

        List<Eventa> listaventas;
        public frmbuscarfactura()
        {
            InitializeComponent();
        }
        private void ActualizarLista()
        {
            Nventa listam = new Nventa();
            listaventas = listam.obtenerlistventa();

            var lista = (from venta in listaventas
                         select new
                         {
                            Numventa = venta.Num_venta,
                             venta.Cliente.idCliente,
                             venta.Usuario.idUsuario,
                             venta.FechaFactura,                           
                             venta.Tipopago,
                             venta.Estado,
                             venta.Descuento,
                             venta.Subtotal,
                             venta.TotalCordobas,
                             venta.TotalDolares
                         }

                    ).ToList();
            dataGridView1.DataSource = lista;
         



        }
        private void frmbuscarfactura_Load(object sender, EventArgs e)
        {
            ActualizarLista();
        }
       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmDevolucion d = new frmDevolucion();
                d.Numventa = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Numventa"].ToString());
                d.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
