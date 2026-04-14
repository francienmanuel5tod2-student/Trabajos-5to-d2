using System;
using System.Collections.Generic;
using System.Data;
using ClassLibrary1;
using Microsoft.Data.SqlClient;

namespace CapaDato
{
    public class MovimientoDAL
    {
        public int ObtenerSiguienteMovimiento()
        {
            int siguiente = 1;

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_ObtenerSiguienteMovimiento", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                siguiente = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return siguiente;
        }

        public int Insertar(MovimientoDTO m)
        {
            int idMovimiento = 0;

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                SqlTransaction tx = cn.BeginTransaction(); 

                try
                {
                    using (SqlCommand cmd = new SqlCommand("SP_InsertarMovimiento", cn, tx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@tipo_movimiento", m.tipo_movimiento);
                        cmd.Parameters.AddWithValue("@fecha", m.fecha);
                        cmd.Parameters.AddWithValue("@id_usuario", m.id_usuario);

                        SqlParameter outputId = new SqlParameter("@IdMovimientoSalida", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };

                        cmd.Parameters.Add(outputId);

                        cmd.ExecuteNonQuery();

                        idMovimiento = (int)outputId.Value;
                    }

                    foreach (var detalle in m.detalles)
                    {
                        using (SqlCommand cmdDetalle = new SqlCommand("SP_InsertarDetalleMovimiento", cn, tx))
                        {
                            cmdDetalle.CommandType = CommandType.StoredProcedure;

                            cmdDetalle.Parameters.AddWithValue("@id_movimiento", idMovimiento);
                            cmdDetalle.Parameters.AddWithValue("@id_producto", detalle.id_producto);
                            cmdDetalle.Parameters.AddWithValue("@cantidad", detalle.cantidad);
                            cmdDetalle.Parameters.AddWithValue("@id_cliente", (object)detalle.id_cliente ?? DBNull.Value);
                            cmdDetalle.Parameters.AddWithValue("@id_proveedor", (object)detalle.id_proveedor ?? DBNull.Value);

                            cmdDetalle.ExecuteNonQuery();
                        }

                        using (SqlCommand cmdStock = new SqlCommand(
                            m.tipo_movimiento == "Entrada"
                                ? "SP_ActualizarStockEntrada"
                                : "SP_ActualizarStockSalida",
                            cn, tx))
                        {
                            cmdStock.CommandType = CommandType.StoredProcedure;

                            cmdStock.Parameters.AddWithValue("@id_producto", detalle.id_producto);
                            cmdStock.Parameters.AddWithValue("@cantidad", detalle.cantidad);

                            cmdStock.ExecuteNonQuery(); 
                        }
                    }

                    tx.Commit(); 
                }
                catch (Exception)
                {
                    tx.Rollback(); 
                    throw;
                }
            }

            return idMovimiento;
        }

        public List<MovimientoDTO> Listar()
        {
            List<MovimientoDTO> lista = new List<MovimientoDTO>();

            using (SqlConnection con = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("SP_ListarMovimientos", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new MovimientoDTO
                        {
                            id_movimiento = Convert.ToInt32(dr["id_movimiento"]),
                            tipo_movimiento = dr["tipo_movimiento"].ToString(),
                            fecha = Convert.ToDateTime(dr["fecha"]),
                            usuario = dr["usuario"].ToString()
                        });
                    }
                }
            }

            return lista;
        }

        public DataTable ObtenerReporteMovimientos(int idMovimiento)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_ReporteMovimientos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.Parameters.AddWithValue("@id_movimiento", idMovimiento);

                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    }
}