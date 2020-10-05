using BE.DOCUMENTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.DOCUMENTO {
    public class ReporteSupervisionADO {
        grubalEntities db = new grubalEntities();


        public DataTable ListarReporteSupervisionProyectoSupervisor(int id_proyecto, int id_supervisor) {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarReporteSupervisionPorProyectoEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_proyecto", id_proyecto);
                cmd.Parameters.AddWithValue("@id_supervisor", id_supervisor);

                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "ReporteSupervision");
                return dts.Tables["ReporteSupervision"];
            } catch (SqlException ex) {
                throw new Exception("Error mostrando Reportes de Supervision: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
        }

        public DataTable ListarReporteSupervisionProyecto(int id_proyecto) {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarReporteSupervisionPorProyecto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_proyecto", id_proyecto);


                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "ReporteSupervision");
                return dts.Tables["ReporteSupervision"];
            } catch (SqlException ex) {
                throw new Exception("Error mostrando Reportes de Supervision: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
        }


        public Boolean ReporteSupervisionNew(ReporteSupervisionBE r) {
            bool success;
            try {
                db.ReporteSupervisionNew(r.Id_proyecto, r.Id_supervisor, r.Fecha_reporte, r.Detalles_reporte, r.Path_scan_reporte);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }

        public Boolean EliminarReporteSupervision(int idDocumento) {
            bool success;
            try {
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception("No se pudo eliminar el documento, tiene data relacionada a ella" + x.Message);
            }
            return success;
        }

        public Boolean ModificarReporteSupervision(ReporteSupervisionBE r) {
            bool success;
            try {
                db.ModificarReporteSupervision(r.Id_documento,r.Id_proyecto, r.Id_supervisor, r.Fecha_reporte, r.Detalles_reporte, r.Path_scan_reporte);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }



        public ReporteSupervisionBE ListarReporteSupervisionPorId(int idDocumento) {
            ReporteSupervisionBE rpBE;
            try {
                var q = db.ListarReporteSupervisionPorId(idDocumento).FirstOrDefault();
                rpBE = new ReporteSupervisionBE(q.id_documento, q.id_proyecto, q.id_supervisor, (DateTime)q.fecha_reporte, q.detalles_reporte, q.path_scan_reporte);
            } catch (Exception ex) {
                throw new Exception(ex.Message);
            } 
            return rpBE;
        }
    }
}
