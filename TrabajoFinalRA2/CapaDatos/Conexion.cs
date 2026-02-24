using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class Conexion
    {
            public static string connectionString = @"Server=DESKTOP-U615B81;Database=SistemaVentas;Trusted_Connection=True;";

            public static SqlConnection ObtenerConexion()
            {
                return new SqlConnection(connectionString);
            }

    }
}
