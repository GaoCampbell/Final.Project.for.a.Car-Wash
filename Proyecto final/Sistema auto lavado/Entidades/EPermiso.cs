using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EPermiso
    {
        public int PidUsuario{ get; set; }
        public bool venta{ get; set; }
        public bool mantenimiento { get; set; }
        public bool lavado { get; set; }
        public bool compra { get; set; }
        public bool empleado { get; set; }
        public bool Tusuario { get; set; }
        public bool producto { get; set; }
        public bool proveedor { get; set; }
        public string usuario { get; set; }
    }
}
