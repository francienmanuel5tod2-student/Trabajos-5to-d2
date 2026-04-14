using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ClienteDTO
    {
        public int id_cliente { get; set; }
        public string nombre_completo { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string direccion { get; set; }
        public DateTime fecha_registro { get; set; }
    }
}
