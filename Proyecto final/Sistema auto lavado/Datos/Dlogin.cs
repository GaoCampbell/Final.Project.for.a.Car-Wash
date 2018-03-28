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
    public class Dlogin
    {
        public Entidades.EUsuario login(string usuario, string password)
        {
            try {
                SqlConnection conex = new SqlConnection(Properties.Settings.Default.cadenaConexion);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Ingenieria..sp_Usuarios";
                cmd.Parameters.Add("@i_operacion",SqlDbType.Char,1).Value = "V";
                cmd.Parameters.AddWithValue("@V_usuario",usuario);
                cmd.Parameters.AddWithValue("@V_password",password);
                cmd.Connection = conex;
                conex.Open();
                SqlDataReader leer = cmd.ExecuteReader();
                EUsuario validarUsuario = new EUsuario();
                while (leer.Read()) {
                    validarUsuario.Empleado.nombres = leer.GetString(0);
                    validarUsuario.Empleado.cargo = leer.GetString(1);
                    validarUsuario.usuario = leer.GetString(2);
                    validarUsuario.estado = leer.GetString(4);
                    validarUsuario.Permiso.venta = leer.GetBoolean(5);
                    validarUsuario.Permiso.mantenimiento = leer.GetBoolean(6);
                    validarUsuario.Permiso.lavado = leer.GetBoolean(7);
                    validarUsuario.Permiso.compra = leer.GetBoolean(8);
                    validarUsuario.Permiso.empleado = leer.GetBoolean(9);
                    validarUsuario.Permiso.Tusuario = leer.GetBoolean(10);
                    validarUsuario.Permiso.producto = leer.GetBoolean(11);
                    validarUsuario.Permiso.proveedor = leer.GetBoolean(12);
                }
                return validarUsuario;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
    }
}
