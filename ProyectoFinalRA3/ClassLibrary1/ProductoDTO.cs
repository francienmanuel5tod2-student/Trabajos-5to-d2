using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ProductoDTO
    {
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public int stock { get; set; }

        public string categoria { get; set; }
        public string usuario { get; set; }
        public string proveedor { get; set; }

        public DateTime fecha_creacion { get; set; }
    }
}
