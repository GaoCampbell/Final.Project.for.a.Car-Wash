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
    public partial class frmReporteLavado : Form
    {
        public List<ELavado> listaLavado;
        public void actualizarGrid()
        {
            try
            {
                NLavado listar = new NLavado();
                listaLavado = listar.selectRow();
                var lista = (from lavado in listaLavado
                             select new
                             {
                                 lavado.idLavado,
                                 lavado.fecha,
                                 lavado.usuario.usuario,
                                 Atendido_por = lavado.empleado.nombres,
                                 lavado.grupoTrabajadores.idGrupo,
                                 Grupo_Asignado = lavado.grupoTrabajadores.grupoTrabajadores,
                                 lavado.vehiculoLavado.idVehiculoLavado,
                                 lavado.vehiculoLavado.vehiculoLavado,
                                 lavado.servicioLavado.idServicioLavado,
                                 lavado.servicioLavado.servicioLavado,
                                 Grupo = lavado.grupoTrabajadores.idGrupo,
                                 lavado.LavadoVehiculo.idLavadoVehiculo,
                                 lavado.LavadoVehiculo.precio,
                                 lavado.placa,
                                 lavado.total,
                             }).ToList();
                dgvLavado.DataSource = lista;
                dgvLavado.Columns["idLavado"].Visible = false;
                dgvLavado.Columns["usuario"].Visible = false;
                dgvLavado.Columns["idGrupo"].Visible = false;
                dgvLavado.Columns["idVehiculoLavado"].Visible = false;
                dgvLavado.Columns["idServicioLavado"].Visible = false;
                dgvLavado.Columns["idLavadoVehiculo"].Visible = false;
                dgvLavado.Columns["precio"].Visible = false;
                dgvLavado.Columns["Grupo"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public frmReporteLavado()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReporteLavado_Load(object sender, EventArgs e)
        {
            rbtEmpleadp.Checked = true;
            try
            {
                actualizarGrid();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
        public void Filtro() {
            if (rbtEmpleadp.Checked ) {
                var busqueda = (
                    from reporte in listaLavado where reporte.empleado.nombres.ToUpper().StartsWith(txtFiltro.Text.ToUpper())
                    select new {
                            reporte.idLavado,
                            reporte.fecha,
                            reporte.usuario.usuario,
                            Atendido_por = reporte.empleado.nombres,
                            reporte.grupoTrabajadores.idGrupo,
                            Grupo_Asignado = reporte.grupoTrabajadores.grupoTrabajadores,
                            reporte.vehiculoLavado.idVehiculoLavado,
                            reporte.vehiculoLavado.vehiculoLavado,
                            reporte.servicioLavado.idServicioLavado,
                            reporte.servicioLavado.servicioLavado,
                            Grupo = reporte.grupoTrabajadores.idGrupo,
                            reporte.LavadoVehiculo.idLavadoVehiculo,
                            reporte.LavadoVehiculo.precio,
                            reporte.placa,
                            reporte.total,
                             }).ToList();
                dgvLavado.DataSource = busqueda;
                dgvLavado.Columns["idLavado"].Visible = false;
                dgvLavado.Columns["usuario"].Visible = false;
                dgvLavado.Columns["idGrupo"].Visible = false;
                dgvLavado.Columns["idVehiculoLavado"].Visible = false;
                dgvLavado.Columns["idServicioLavado"].Visible = false;
                dgvLavado.Columns["idLavadoVehiculo"].Visible = false;
                dgvLavado.Columns["precio"].Visible = false;
                dgvLavado.Columns["Grupo"].Visible = false;
                btnFecha.Text = "Generar reporte por empleado";
                
            }
            if (rbtServicio.Checked)
            {
                var busqueda = (
                    from reporte in listaLavado
                    where reporte.servicioLavado.servicioLavado.ToUpper().StartsWith(txtFiltro.Text.ToUpper())
                    select new
                    {
                        reporte.idLavado,
                        reporte.fecha,
                        reporte.usuario.usuario,
                        Atendido_por = reporte.empleado.nombres,
                        reporte.grupoTrabajadores.idGrupo,
                        Grupo_Asignado = reporte.grupoTrabajadores.grupoTrabajadores,
                        reporte.vehiculoLavado.idVehiculoLavado,
                        reporte.vehiculoLavado.vehiculoLavado,
                        reporte.servicioLavado.idServicioLavado,
                        reporte.servicioLavado.servicioLavado,
                        Grupo = reporte.grupoTrabajadores.idGrupo,
                        reporte.LavadoVehiculo.idLavadoVehiculo,
                        reporte.LavadoVehiculo.precio,
                        reporte.placa,
                        reporte.total,
                    }).ToList();
                dgvLavado.DataSource = busqueda;
                dgvLavado.Columns["idLavado"].Visible = false;
                dgvLavado.Columns["usuario"].Visible = false;
                dgvLavado.Columns["idGrupo"].Visible = false;
                dgvLavado.Columns["idVehiculoLavado"].Visible = false;
                dgvLavado.Columns["idServicioLavado"].Visible = false;
                dgvLavado.Columns["idLavadoVehiculo"].Visible = false;
                dgvLavado.Columns["precio"].Visible = false;
                dgvLavado.Columns["Grupo"].Visible = false;
            }

            if (rbtVehiculo.Checked)
            {
                var busqueda = (
                    from reporte in listaLavado
                    where reporte.vehiculoLavado.vehiculoLavado.ToUpper().StartsWith(txtFiltro.Text.ToUpper())
                    select new
                    {
                        reporte.idLavado,
                        reporte.fecha,
                        reporte.usuario.usuario,
                        Atendido_por = reporte.empleado.nombres,
                        reporte.grupoTrabajadores.idGrupo,
                        Grupo_Asignado = reporte.grupoTrabajadores.grupoTrabajadores,
                        reporte.vehiculoLavado.idVehiculoLavado,
                        reporte.vehiculoLavado.vehiculoLavado,
                        reporte.servicioLavado.idServicioLavado,
                        reporte.servicioLavado.servicioLavado,
                        Grupo = reporte.grupoTrabajadores.idGrupo,
                        reporte.LavadoVehiculo.idLavadoVehiculo,
                        reporte.LavadoVehiculo.precio,
                        reporte.placa,
                        reporte.total,
                    }).ToList();
                dgvLavado.DataSource = busqueda;
                dgvLavado.Columns["idLavado"].Visible = false;
                dgvLavado.Columns["usuario"].Visible = false;
                dgvLavado.Columns["idGrupo"].Visible = false;
                dgvLavado.Columns["idVehiculoLavado"].Visible = false;
                dgvLavado.Columns["idServicioLavado"].Visible = false;
                dgvLavado.Columns["idLavadoVehiculo"].Visible = false;
                dgvLavado.Columns["precio"].Visible = false;
                dgvLavado.Columns["Grupo"].Visible = false;
            }
            if (rbtFecha.Checked)
            {
                var busqueda = (
                    from reporte in listaLavado
                    where reporte.fecha.ToString().StartsWith(txtFiltro.Text.ToUpper())
                    select new
                    {
                        reporte.idLavado,
                        reporte.fecha,
                        reporte.usuario.usuario,
                        Atendido_por = reporte.empleado.nombres,
                        reporte.grupoTrabajadores.idGrupo,
                        Grupo_Asignado = reporte.grupoTrabajadores.grupoTrabajadores,
                        reporte.vehiculoLavado.idVehiculoLavado,
                        reporte.vehiculoLavado.vehiculoLavado,
                        reporte.servicioLavado.idServicioLavado,
                        reporte.servicioLavado.servicioLavado,
                        Grupo = reporte.grupoTrabajadores.idGrupo,
                        reporte.LavadoVehiculo.idLavadoVehiculo,
                        reporte.LavadoVehiculo.precio,
                        reporte.placa,
                        reporte.total,
                    }).ToList();
                dgvLavado.DataSource = busqueda;
                dgvLavado.Columns["idLavado"].Visible = false;
                dgvLavado.Columns["usuario"].Visible = false;
                dgvLavado.Columns["idGrupo"].Visible = false;
                dgvLavado.Columns["idVehiculoLavado"].Visible = false;
                dgvLavado.Columns["idServicioLavado"].Visible = false;
                dgvLavado.Columns["idLavadoVehiculo"].Visible = false;
                dgvLavado.Columns["precio"].Visible = false;
                dgvLavado.Columns["Grupo"].Visible = false;
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            Filtro();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnReporteLavado_Click(object sender, EventArgs e)
        {
            try
            {
                frmMostrarReporteLavado reporteEmpledo = new frmMostrarReporteLavado();
                reporteEmpledo.fecha = Convert.ToDateTime(txtFiltro.Text);
                reporteEmpledo.ShowDialog();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
