using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UsuarioDTO
    {
            public int id_usuario { get; set; }
            public string nombre { get; set; }
            public string username { get; set; }
            public int id_rol { get; set; }
            public string nombre_rol { get; set; }
    }
}
