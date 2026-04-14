using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using Microsoft.Data.SqlClient;

namespace CapaDato
{
    public class ClienteDAL
    {
        public List<ClienteDTO> Listar()
        {
            List<ClienteDTO> lista = new List<ClienteDTO>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_ListarClientes", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new ClienteDTO
                        {
                            id_cliente = Convert.ToInt32(dr["id_cliente"]),
                            nombre_completo = dr["nombre_completo"].ToString(),
                            telefono = dr["telefono"].ToString(),
                            correo = dr["correo"].ToString(),
                            direccion = dr["direccion"].ToString(),
                            fecha_registro = Convert.ToDateTime(dr["fecha_registro"])
                        });
                    }
                }
            }

            return lista;
        }
    }
}
