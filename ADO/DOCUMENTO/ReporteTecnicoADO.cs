using BE.DOCUMENTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.DOCUMENTO {
    public class ReporteTecnicoADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable ListarReporteTecnicoFull() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarReporteTecnicoFull";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "ReporteTecnico");
            } catch (Exception ex) {
                throw new Exception("Error mostrando Reportes Técnicos: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
            return dts.Tables["ReporteTecnico"];
        }

        public DataTable ListarReporteTecnicoPorProyectoEmpleado(int id_proyecto, int id_tecnico) {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarReporteTecnicoPorProyectoEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_proyecto", id_proyecto);
                cmd.Parameters.AddWithValue("@id_tecnico", id_tecnico);

                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "ReporteTecnico");
                return dts.Tables["ReporteTecnico"];
            } catch (SqlException ex) {
                throw new Exception("Error mostrando Reportes de Técnicos: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
        }


        public Boolean ReporteTecnicoNew(ReporteTecnicoBE rtBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DOCUMENTO.ReporteTecnicoNew";
            bool success;

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_proyecto", rtBE.Id_proyecto);
                cmd.Parameters.AddWithValue("@id_tecnico", rtBE.Id_tecnico);
                cmd.Parameters.AddWithValue("@fecha_reporte", rtBE.Fecha_reporte);
                cmd.Parameters.AddWithValue("@detalles_reporte", rtBE.Detalles_reporte);
                cmd.Parameters.AddWithValue("@path_scan_reporte", rtBE.Path_scan_reporte);

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

        public Boolean EliminarReporteTecnico(int idDocumento) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DOCUMENTO.EliminarReporteTecnico";
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

        public Boolean ModificarReporteTecnico(ReporteTecnicoBE rtBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DOCUMENTO.ActualizarReporteTecnico";
            bool success;

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_documento", rtBE.Id_documento);
                cmd.Parameters.AddWithValue("@id_proyecto", rtBE.Id_proyecto);
                cmd.Parameters.AddWithValue("@id_tecnico", rtBE.Id_tecnico);
                cmd.Parameters.AddWithValue("@fecha_reporte", rtBE.Fecha_reporte);
                cmd.Parameters.AddWithValue("@detalles_reporte", rtBE.Detalles_reporte);
                cmd.Parameters.AddWithValue("@path_scan_reporte", rtBE.Path_scan_reporte);

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

        public ReporteTecnicoBE ListarReporteTecnicoPorId(int idDocumento) {
            ReporteTecnicoBE rpBE = new ReporteTecnicoBE();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarReporteTecnicoPorId";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_documento", idDocumento);

                con.Open();
                SqlDataReader dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true) {
                    dtr.Read();
                    rpBE.Id_documento = int.Parse(dtr["id_documento"].ToString());
                    rpBE.Id_proyecto = int.Parse(dtr["id_proyecto"].ToString());
                    rpBE.Id_tecnico = int.Parse(dtr["id_tecnico"].ToString());
                    rpBE.Fecha_reporte = Convert.ToDateTime(dtr["fecha_reporte"]);
                    rpBE.Detalles_reporte = dtr["detalles_reporte"].ToString();
                    rpBE.Path_scan_reporte = dtr["path_scan_reporte"].ToString();
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
            return rpBE;
        }
    }
}
