using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
   public class NMantenimiento
    {
        public List<EMantenimineto> selectRow()
        {
            DMantenimineto listar = new DMantenimineto();
            return listar.SelectRow();
        }
    }
}
