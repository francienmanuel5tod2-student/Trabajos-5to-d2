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
    public class ProveedorDAL
    {
        public List<ProveedorDTO> Listar()
        {
            List<ProveedorDTO> lista = new List<ProveedorDTO>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_Listar_Proveedores", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new ProveedorDTO
                        {
                            id_proveedor = Convert.ToInt32(dr["id_proveedor"]),
                            nombre = dr["nombre"].ToString()
                        });
                    }
                }
            }

            return lista;
        }
    }
}
