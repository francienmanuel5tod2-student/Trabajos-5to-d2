using System;
using System.Data;
using Microsoft.Data.SqlClient;
using CapaDato;
using ClassLibrary1;

public class UsuarioDAL
{
    public UsuarioDTO Login(string user, string pass)
    {
        UsuarioDTO usuario = null;

        using (SqlConnection cn = Conexion.ObtenerConexion())
        using (SqlCommand cmd = new SqlCommand("SP_Login", cn))
        {
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", user);
            cmd.Parameters.AddWithValue("@contraseña", pass);

            cn.Open();

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                if (dr.Read())
                {
                    usuario = new UsuarioDTO
                    {
                        id_usuario = Convert.ToInt32(dr["id_usuario"]),
                        nombre = dr["nombre"].ToString(),
                        username = dr["username"].ToString(),
                        id_rol = Convert.ToInt32(dr["id_rol"]),
                        nombre_rol = dr["nombre_rol"].ToString()
                    };
                }
            }
        }

        return usuario;
    }
}