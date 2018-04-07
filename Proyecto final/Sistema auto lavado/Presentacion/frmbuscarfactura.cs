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
        public int idcliente, idusuario, Numventas;
        public decimal descuento, subtotal, totalcordobas, totaldolares;
        public string tipopago, estado;

        public DateTime fechafactura;
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
                Numventas = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Numventa"].Value.ToString());
                idcliente = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idCliente"].Value.ToString());
                idusuario = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idUsuario"].Value.ToString());
                fechafactura = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["FechaFactura"].Value.ToString());
                tipopago = dataGridView1.Rows[e.RowIndex].Cells["Tipopago"].Value.ToString();
                estado = dataGridView1.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
                descuento = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Descuento"].Value.ToString());
                subtotal = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Subtotal"].Value.ToString());
                totalcordobas = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["TotalCordobas"].Value.ToString());
                totaldolares = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["TotalDolares"].Value.ToString());
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
