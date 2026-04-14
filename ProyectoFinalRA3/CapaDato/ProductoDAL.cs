using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ClassLibrary1;

namespace CapaDato
{
    public class ProductoDAL
    {
        public List<ProductoDTO> ListarPorProveedor(int idProveedor)
        {
            List<ProductoDTO> productos = new List<ProductoDTO>();

            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_ListarProductosPorProveedor", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_proveedor", idProveedor);

                con.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        productos.Add(new ProductoDTO
                        {
                            id_producto = Convert.ToInt32(reader["id_producto"]),
                            nombre = reader["nombre"].ToString(),
                            categoria = reader["categoria"] != DBNull.Value ? reader["categoria"].ToString() : "",
                            stock = reader["stock"] != DBNull.Value ? Convert.ToInt32(reader["stock"]) : 0
                        });
                    }
                }
            }

            return productos;
        }
        
        public List<ProductoDTO> Listar()
        {
            List<ProductoDTO> lista = new List<ProductoDTO>();

            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_ListarProductos", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new ProductoDTO
                        {
                            id_producto = Convert.ToInt32(dr["id_producto"]),
                            nombre = dr["nombre"].ToString(),
                            stock = dr["stock"] != DBNull.Value ? Convert.ToInt32(dr["stock"]) : 0,
                            categoria = dr["categoria"] != DBNull.Value ? dr["categoria"].ToString() : "",
                            usuario = dr["usuario"] != DBNull.Value ? dr["usuario"].ToString() : "", // 🔥 AQUÍ
                            proveedor = dr["proveedor"] != DBNull.Value ? dr["proveedor"].ToString() : "",
                            fecha_creacion = dr["fecha_creacion"] != DBNull.Value
                            ? Convert.ToDateTime(dr["fecha_creacion"])
                            : DateTime.Now
                        });
                    }
                }
            }

            return lista;
        }

        public void Insertar(ProductoDTO p, int id_categoria, int creado_por, int id_proveedor)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_crearProducto", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", p.nombre);
                cmd.Parameters.AddWithValue("@stock", p.stock);
                cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
                cmd.Parameters.AddWithValue("@creado_por", creado_por);
                cmd.Parameters.AddWithValue("@id_proveedor", id_proveedor);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_eliminarProducto", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_producto", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(ProductoDTO p, int id_categoria, int id_proveedor)
        {
            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_ActualizarProducto", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_producto", p.id_producto);
                cmd.Parameters.AddWithValue("@nombre", p.nombre);
                cmd.Parameters.AddWithValue("@stock", p.stock);
                cmd.Parameters.AddWithValue("@id_categoria", id_categoria);
                cmd.Parameters.AddWithValue("@id_proveedor", id_proveedor);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}