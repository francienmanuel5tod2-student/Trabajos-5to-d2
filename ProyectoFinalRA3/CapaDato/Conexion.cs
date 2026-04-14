    using System;
    using System.Collections.Generic;
    using Microsoft.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace CapaDato
    {
        public class Conexion
        {
            public static SqlConnection ObtenerConexion()
            {
                return new SqlConnection("Server=DESKTOP-U615B81;Database=Inventario;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
