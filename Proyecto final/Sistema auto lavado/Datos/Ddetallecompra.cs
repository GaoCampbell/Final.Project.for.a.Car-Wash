﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class Ddetallecompra
    {

        public List<EdetalleCompra> obtenerlistadetalle()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.cadenaConexion);
                SqlCommand comando = new SqlCommand();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "getdetallecompra";
                comando.Connection = conexion;
                conexion.Open();
                SqlDataReader leer = comando.ExecuteReader();
                List<EdetalleCompra> listadetalle = new List<EdetalleCompra>();
                while (leer.Read())
                {
                    EdetalleCompra nuevaFila = new EdetalleCompra();
                    //Compra
                    nuevaFila.Compra = new Ecompra();
                    nuevaFila.Compra.Idcompra = leer.GetInt32(0);
                    //---------------------------------------------

                    if (leer.IsDBNull(1))
                        nuevaFila.Cantidad = null;
                    else
                        nuevaFila.Cantidad = leer.GetInt32(1);


                    if (leer.IsDBNull(2))
                        nuevaFila.Total = null;
                    else
                        nuevaFila.Total = leer.GetDecimal(2);
                    //PRODUCTO
                    nuevaFila.producto = new Eproductos();
                    nuevaFila.producto.Codproducto = leer.GetInt32(3);

                    if (leer.IsDBNull(4))
                        nuevaFila.producto.Producto = null;
                    else
                        nuevaFila.producto.Producto = leer.GetString(4);

                    if (leer.IsDBNull(5))
                        nuevaFila.producto.Precio = null;
                    else
                        nuevaFila.producto.Precio = leer.GetDecimal(5);



                    listadetalle.Add(nuevaFila);
                }
                conexion.Close();
                leer.Close();
                return listadetalle;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
