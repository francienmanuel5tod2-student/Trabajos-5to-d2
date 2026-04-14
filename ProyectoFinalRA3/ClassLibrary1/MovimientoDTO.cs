using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MovimientoDTO
    {
            public int id_movimiento { get; set; }       
            public string tipo_movimiento { get; set; }  
            public DateTime fecha { get; set; }       
            public int id_usuario { get; set; }
            public string usuario { get; set; }
            public List<DetalleMovimientoDTO> detalles { get; set; } 
    }

        public class DetalleMovimientoDTO
        {
            public int id_detalle { get; set; }
            public int id_producto { get; set; }
            public int cantidad { get; set; }
            public int? id_cliente { get; set; }
            public int? id_proveedor { get; set; }
    }
}
