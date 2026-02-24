using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class VentasBL
    {
        VentasDAL dal = new VentasDAL();
        public List<Ventas> Listar()
        {
            return dal.ListarVentas();
        }

        public int Guardar(Ventas venta)
        {
            if (venta.ID_venta == 0)
            {
                // Insertar venta nueva y retornar el Id generado
                return dal.InsertarVenta(venta);
            }
            else
            {
                // Actualizar venta existente
                dal.ActualizarVenta(venta);
                return venta.ID_venta;
            }
        }

        public void ActualizarTotal(Ventas venta)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("UPDATE Ventas SET Total_general=@Total WHERE ID_venta=@ID", cn);
                cmd.Parameters.AddWithValue("@Total", venta.Total_general);
                cmd.Parameters.AddWithValue("@ID", venta.ID_venta);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void GuardarDetalle(DetalleVenta detalle)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_crearDetalleVenta", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_venta", detalle.ID_venta);
                cmd.Parameters.AddWithValue("@ID_producto", detalle.ID_producto);
                cmd.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                cmd.Parameters.AddWithValue("@Precio", detalle.Precio);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
