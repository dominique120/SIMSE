using BE.DOCUMENTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.DOCUMENTO {
    public class EntregaFinalADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable ListarEntregasFinalesFechas(DateTime fecha_inicio, DateTime fecha_fin) {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarEntregasFinalesPorFecha";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
                cmd.Parameters.AddWithValue("@fecha_fin", fecha_fin);

                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "EntregasFinales");
                return dts.Tables["EntregasFinales"];
            } catch (SqlException ex) {
                throw new Exception("Error mostrando las Entregas Finales: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
        }


        public Boolean EntregaFinalNew(EntregaFinalBE eBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DOCUMENTO.EntregaFinalNew";
            bool success;

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_proyecto", eBE.Id_proyecto);
                cmd.Parameters.AddWithValue("@id_encargado", eBE.Id_encargado);
                cmd.Parameters.AddWithValue("@fecha", eBE.Fecha);
                cmd.Parameters.AddWithValue("@path_scan_reporte", eBE.Path_scan_reporte);

                con.Open();
                cmd.ExecuteNonQuery();

                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return success;
        }

        public Boolean EliminarEntregaFinal(int idDocumento) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DOCUMENTO.EliminarEntregaFinal";
            bool success;

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_documento", idDocumento);

                con.Open();
                cmd.ExecuteNonQuery();

                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception("No se pudo eliminar el documento, tiene data relacionada a ella" + x.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return success;
        }

        public Boolean ModificarEntregaFinal(EntregaFinalBE eBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DOCUMENTO.ActualizarEntregaFinal";
            bool success;

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_documento", eBE.Id_documento);
                cmd.Parameters.AddWithValue("@id_proyecto", eBE.Id_proyecto);
                cmd.Parameters.AddWithValue("@id_encargado", eBE.Id_encargado);
                cmd.Parameters.AddWithValue("@fecha", eBE.Fecha);
                cmd.Parameters.AddWithValue("@path_scan_reporte", eBE.Path_scan_reporte);

                con.Open();
                cmd.ExecuteNonQuery();

                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return success;
        }

        public EntregaFinalBE ListarEntregaPorId(int idDocumento) {
            EntregaFinalBE entBE = new EntregaFinalBE();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarEntregaFinalPorId";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_documento", idDocumento);

                con.Open();
                SqlDataReader dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true) {
                    dtr.Read();
                    entBE.Id_documento = int.Parse(dtr["id_documento"].ToString());
                    entBE.Id_proyecto = int.Parse(dtr["id_proyecto"].ToString());
                    entBE.Id_encargado = int.Parse(dtr["id_encargado"].ToString());
                    entBE.Path_scan_reporte = dtr["path_scan_reporte"].ToString();
                    entBE.Fecha = Convert.ToDateTime(dtr["fecha"]);
                } else {
                    throw new Exception("Error al buscar el documento.");
                }
                dtr.Close();

            } catch (Exception ex) {
                throw new Exception(ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return entBE;
        }
    }
}
