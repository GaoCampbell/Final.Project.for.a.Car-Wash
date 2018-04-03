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
    public partial class frmMantenimineto : Form
    {
        List<EMantenimineto> Listamantenimiento;
        public frmMantenimineto()
        {
            InitializeComponent();
        }

        private void frmMantenimineto_Load(object sender, EventArgs e)
        {
            actualizargrid();
        }
        private void actualizargrid()
        {
            try
            {
                NMantenimiento listaman = new NMantenimiento();
                Listamantenimiento = listaman.selectRow();

                var lista = (from man in Listamantenimiento
                             select new
                             {
                                 Servicio = man.idservicioVehiculo.idServicioMantenimiento.servicioMantenimiento,
                                 Vehiculo = man.idservicioVehiculo.idVehiculoMantenimiento.vehiculoMantenimiento,
                                 Lavadores = man.idgrupo.grupoTrabajadores,
                                 Placa = man.placa,
                                 Fecha = man.fecha,
                                
                                 man.idMantenimiento,
                                 Total=man.total,
                                 man.usuario.usuario,
                                 Empleado = (man.usuario.Empleado.nombres + ' ' + man.usuario.Empleado.apellidos),
                                 man.idgrupo.idGrupo,
                                 man.idservicioVehiculo.idServicioVehiculo,
                                 man.idservicioVehiculo.idServicioMantenimiento.idServicioMantenimiento,
                                 man.idservicioVehiculo.idVehiculoMantenimiento.idVehiculoMantenimiento,
                        
                             }).ToList();
                dgvman.DataSource = lista;
                dgvman.Columns["idServicioMantenimiento"].Visible = false;
                dgvman.Columns["idVehiculoMantenimiento"].Visible = false;
                dgvman.Columns["idMantenimiento"].Visible = false;
                dgvman.Columns["usuario"].Visible = false;
                dgvman.Columns["idServicioVehiculo"].Visible = false;
                dgvman.Columns["idgrupo"].Visible = false;

                ActualizarServicioV();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ActualizarServicioV()
        {
            NMantenimiento gestionarman = new NMantenimiento();
            Listamantenimiento = gestionarman.selectRow();

        }
    }
}
