using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;

namespace CapaDatos
{
    public class CategoriaDAL
    {
        // LISTAR
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_listarCategorias", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Categoria
                        {
                            ID_categoria = Convert.ToInt32(dr["ID_categoria"]),
                            Nombre_categoria = dr["Nombre_categoria"].ToString(),
                            Estado = Convert.ToBoolean(dr["Estado"])
                        });
                    }
                }
            }

            return lista;
        }

        // INSERTAR
        public void Insertar(Categoria cat)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_crearCategoria", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre_categoria", cat.Nombre_categoria);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ACTUALIZAR
        public void Actualizar(Categoria cat)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_actualizarCategoria", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_categoria", cat.ID_categoria);
                cmd.Parameters.AddWithValue("@Nombre_categoria", cat.Nombre_categoria);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // ELIMINAR LÓGICO
        public void Eliminar(int id)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_eliminarCategoria", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_categoria", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
