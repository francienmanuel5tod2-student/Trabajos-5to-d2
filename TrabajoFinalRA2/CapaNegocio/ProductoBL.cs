using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class ProductoBL
    {
        Producto_DAL dal = new Producto_DAL();
        public List<Producto> Listar()
        {
            return dal.Listar();
        }
    }
}
