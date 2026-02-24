using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetalleVenta
    {
        public int ID_detalle_venta { get; set; }
        public int ID_venta { get; set; }
        public int ID_producto { get; set; }
        public string Nombre_Producto { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Subtotal { get; set; }
    }
}
