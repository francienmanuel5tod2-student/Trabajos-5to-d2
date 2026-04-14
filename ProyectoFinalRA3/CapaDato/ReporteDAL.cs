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
    public class ReporteDAL
    {
        public DataTable ObtenerReporteMovimientos()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("sp_ReporteMovimientos", cn);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    da.Fill(dt); 

                    return dt; 
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener los datos del reporte: " + ex.Message);
                }
            }
        }
    }
}
