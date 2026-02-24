using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class VentasDAL
    {
        public List<Ventas> ListarVentas()
        {
            List<Ventas> lista = new List<Ventas>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Listar_Ventas", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Ventas
                    {
                        ID_venta = (int)dr["Id_Venta"],
                        Fecha_venta = (DateTime)dr["Fecha_Venta"],
                        ID_cliente = (int)dr["Id_Cliente"],
                        Total_general = (decimal)dr["Total_General"],
                        Estado = (bool)dr["Estado"]
                    });
                }
            }

            return lista;
        }



        public int InsertarVenta(Ventas venta)
        {
            int idVenta;

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Insertar_Venta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Fecha_Venta", venta.Fecha_venta);
                cmd.Parameters.AddWithValue("@Id_Cliente", venta.ID_cliente);

                cmd.Parameters.AddWithValue(
                    "@Total_General",
                    (object)venta.Total_general ?? DBNull.Value
                );

                cn.Open();
                idVenta = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return idVenta;
        }



        public void ActualizarVenta(Ventas venta)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Actualizar_Venta", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Venta", venta.ID_venta);
                cmd.Parameters.AddWithValue("@Fecha_Venta", venta.Fecha_venta);
                cmd.Parameters.AddWithValue("@Id_Cliente", venta.ID_cliente);
                cmd.Parameters.AddWithValue("@Total_General", venta.Total_general);


                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
