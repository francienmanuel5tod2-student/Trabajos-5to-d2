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
    public class Producto_DAL
    {
        // LISTAR
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Listar_Productos", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Producto
                        {
                            ID_producto = Convert.ToInt32(dr["ID_producto"]),
                            Nombre_producto = dr["Nombre_producto"].ToString(),
                            Precio_producto = Convert.ToDecimal(dr["Precio_producto"]),
                            Stock = Convert.ToInt32(dr["Stock"]),
                            ID_categoria = Convert.ToInt32(dr["ID_categoria"]),
                            Estado = Convert.ToBoolean(dr["Estado"]),

                            ObjCategoria = new Categoria
                            {
                                Nombre_categoria = dr["Nombre_categoria"].ToString()
                            }
                        });
                    }
                }
            }

            return lista;
        }

        // INSERTAR
        public void Insertar(Producto p)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_crearProducto", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre_producto", p.Nombre_producto);
                cmd.Parameters.AddWithValue("@Precio_producto", p.Precio_producto);
                cmd.Parameters.AddWithValue("@Stock", p.Stock);
                cmd.Parameters.AddWithValue("@ID_categoria", p.ID_categoria);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ACTUALIZAR
        public void Actualizar(Producto p)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_actualizarProducto", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_producto", p.ID_producto);
                cmd.Parameters.AddWithValue("@Nombre_producto", p.Nombre_producto);
                cmd.Parameters.AddWithValue("@Precio_producto", p.Precio_producto);
                cmd.Parameters.AddWithValue("@Stock", p.Stock);
                cmd.Parameters.AddWithValue("@ID_categoria", p.ID_categoria);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ELIMINAR LÓGICO
        public void Eliminar(int id)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_eliminarProducto", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_producto", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // BUSCAR POR NOMBRE
        public List<Producto> ListarPorCategoria(int idCategoria)
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_listarProductosPorCategoria", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_categoria", idCategoria);
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Producto
                        {
                            ID_producto = Convert.ToInt32(dr["ID_producto"]),
                            Nombre_producto = dr["Nombre_producto"].ToString(),
                            Precio_producto = Convert.ToDecimal(dr["Precio_producto"]),
                            Stock = Convert.ToInt32(dr["Stock"]),
                            ID_categoria = Convert.ToInt32(dr["ID_categoria"]),
                            Estado = Convert.ToBoolean(dr["Estado"]),

                            // 🔥 ESTO ES LO QUE FALTABA
                            ObjCategoria = new Categoria
                            {
                                Nombre_categoria = dr["Nombre_categoria"].ToString()
                            }
                        });
                    }
                }
            }

            return lista;
        }
    }
}
