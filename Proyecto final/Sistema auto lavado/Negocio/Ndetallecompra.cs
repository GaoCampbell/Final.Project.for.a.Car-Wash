using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;


namespace Negocio
{
    public class Ndetallecompra
    {
        public List<EdetalleCompra> obtenerlistdetallecompra()
        {

            try
            {

                Ddetallecompra datosdetalle = new Ddetallecompra();
                return datosdetalle.obtenerlistadetalle();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
