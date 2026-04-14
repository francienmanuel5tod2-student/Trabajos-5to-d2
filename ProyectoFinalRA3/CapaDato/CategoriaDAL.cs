using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ClassLibrary1;

namespace CapaDato
{
    public class CategoriaDAL
    {

        public List<CategoriaDTO> Listar()
        {
            List<CategoriaDTO> lista = new List<CategoriaDTO>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_Listar_Categorias", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new CategoriaDTO
                        {
                            id_categoria = Convert.ToInt32(dr["id_categoria"]),
                            nombre = dr["nombre"].ToString(),
                            estado = Convert.ToBoolean(dr["estado"])
                        });
                    }
                }
            }

            return lista;
        }

        public void Insertar(CategoriaDTO c)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_crearCategoria", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", c.nombre);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(CategoriaDTO c)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_actualizarCategoria", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID_categoria", c.id_categoria);
                cmd.Parameters.AddWithValue("@Nombre_categoria", c.nombre); 

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Eliminar(int id)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_eliminarCategoria", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_categoria", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}