using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class DUsuario
    {
        public List<EUsuario> SelectRow() {
            try {
                SqlConnection conex = new SqlConnection(Properties.Settings.Default.cadenaConexion);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Ingenieria..sp_Usuarios";
                cmd.Parameters.Add("@i_operacion",SqlDbType.Char,1).Value = "S";
                cmd.Connection = conex;
                conex.Open();
                SqlDataReader leer = cmd.ExecuteReader();
                List<EUsuario> listaUsuario = new List<EUsuario>();
                while (leer.Read()) {
                    EUsuario entidadesUsuario = new EUsuario();
                    if (leer.IsDBNull(0))
                        entidadesUsuario.Empleado.nombres = null;
                    else
                        entidadesUsuario.Empleado.nombres = leer.GetString(0);
                    if (leer.IsDBNull(1))
                        entidadesUsuario.Empleado.cargo = null;
                    else
                        entidadesUsuario.Empleado.cargo = leer.GetString(1);
                    if (leer.IsDBNull(2))
                        entidadesUsuario.usuario = null;
                    else
                        entidadesUsuario.usuario = leer.GetString(2);
                    if (leer.IsDBNull(3))
                        entidadesUsuario.password = null;
                    else
                        entidadesUsuario.password = leer.GetString(3);
                    if (leer.IsDBNull(4))
                        entidadesUsuario.estado = null;
                    else
                        entidadesUsuario.estado = leer.GetString(4);
                    if (leer.IsDBNull(5))
                        entidadesUsuario.Permiso.venta = false;
                    else
                        entidadesUsuario.Permiso.venta = leer.GetBoolean(5);
                    if (leer.IsDBNull(6))
                        entidadesUsuario.Permiso.mantenimiento = false;
                    else
                        entidadesUsuario.Permiso.mantenimiento = leer.GetBoolean(6);
                    if (leer.IsDBNull(7))
                        entidadesUsuario.Permiso.lavado = false;
                    else
                        entidadesUsuario.Permiso.lavado = leer.GetBoolean(7);
                    if (leer.IsDBNull(8))
                        entidadesUsuario.Permiso.compra = false;
                    else
                        entidadesUsuario.Permiso.compra = leer.GetBoolean(8);
                    if (leer.IsDBNull(9))
                        entidadesUsuario.Permiso.empleado = false;
                    else
                        entidadesUsuario.Permiso.empleado = leer.GetBoolean(9);
                    if (leer.IsDBNull(10))
                        entidadesUsuario.Permiso.Tusuario = false;
                    else
                        entidadesUsuario.Permiso.Tusuario = leer.GetBoolean(10);
                    if (leer.IsDBNull(11))
                        entidadesUsuario.Permiso.producto = false;
                    else
                        entidadesUsuario.Permiso.producto = leer.GetBoolean(11);
                    if (leer.IsDBNull(12))
                        entidadesUsuario.Permiso.proveedor = false;
                    else
                        entidadesUsuario.Permiso.proveedor = leer.GetBoolean(12);

                    entidadesUsuario.idUsuario = leer.GetInt32(13);
                    entidadesUsuario.Permiso.PidUsuario = leer.GetInt32(14);
                    entidadesUsuario.Empleado.idEmpleado = leer.GetInt32(15);
                    listaUsuario.Add(entidadesUsuario);


                }
                conex.Close();
                leer.Close();
                return listaUsuario;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public void InsertRow(EUsuario Iusuario) {
            try
            {
                SqlConnection conex = new SqlConnection(Properties.Settings.Default.cadenaConexion);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Ingenieria..sp_Usuarios";
                cmd.Parameters.Add("@i_operacion",SqlDbType.Char,1).Value = "I";
                cmd.Parameters.AddWithValue("@idUsuario",Iusuario.idUsuario);
                cmd.Parameters.AddWithValue("@i_usuario",Iusuario.usuario);
                cmd.Parameters.AddWithValue("@i_password",Iusuario.password);
                cmd.Parameters.AddWithValue("@i_idEmpleado",Iusuario.Empleado.idEmpleado);
                cmd.Parameters.AddWithValue("@i_estado",Iusuario.estado);
                cmd.Parameters.AddWithValue("@i_venta",Iusuario.Permiso.venta);
                cmd.Parameters.AddWithValue("@i_mantenimiento",Iusuario.Permiso.mantenimiento);
                cmd.Parameters.AddWithValue("@i_lavado",Iusuario.Permiso.lavado);
                cmd.Parameters.AddWithValue("@i_compra",Iusuario.Permiso.compra);
                cmd.Parameters.AddWithValue("@i_empleado",Iusuario.Permiso.empleado);
                cmd.Parameters.AddWithValue("@i_Tusuario",Iusuario.Permiso.Tusuario);
                cmd.Parameters.AddWithValue("@i_producto",Iusuario.Permiso.producto);
                cmd.Parameters.AddWithValue("@i_proveedor",Iusuario.Permiso.proveedor);
                cmd.Parameters.AddWithValue("@i_Pusuario",Iusuario.usuario);
                cmd.Connection = conex;
                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
            }
            catch(Exception ex) {
                throw ex;
            }
        }

        public void UpdateRow(EUsuario Uusuario)
        {
            try
            {
                SqlConnection conex = new SqlConnection(Properties.Settings.Default.cadenaConexion);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Ingenieria..sp_Usuarios";
                cmd.Parameters.Add("@i_operacion", SqlDbType.Char, 1).Value = "U";
                 cmd.Parameters.AddWithValue("@idUsuario", Uusuario.idUsuario);
                cmd.Parameters.AddWithValue("@i_PidUsuario",Uusuario.Permiso.PidUsuario);
                cmd.Parameters.AddWithValue("@i_usuario", Uusuario.usuario);
                cmd.Parameters.AddWithValue("@i_password", Uusuario.password);
                cmd.Parameters.AddWithValue("@i_idEmpleado", Uusuario.Empleado.idEmpleado);
                cmd.Parameters.AddWithValue("@i_estado", Uusuario.estado);
                cmd.Parameters.AddWithValue("@i_venta", Uusuario.Permiso.venta);
                cmd.Parameters.AddWithValue("@i_mantenimiento", Uusuario.Permiso.mantenimiento);
                cmd.Parameters.AddWithValue("@i_lavado", Uusuario.Permiso.lavado);
                cmd.Parameters.AddWithValue("@i_compra", Uusuario.Permiso.compra);
                cmd.Parameters.AddWithValue("@i_empleado", Uusuario.Permiso.empleado);
                cmd.Parameters.AddWithValue("@i_Tusuario", Uusuario.Permiso.Tusuario);
                cmd.Parameters.AddWithValue("@i_producto", Uusuario.Permiso.producto);
                cmd.Parameters.AddWithValue("@i_proveedor", Uusuario.Permiso.proveedor);
                cmd.Parameters.AddWithValue("@i_Pusuario", Uusuario.usuario);
                cmd.Connection = conex;
                conex.Open();
                cmd.ExecuteNonQuery();
                conex.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
