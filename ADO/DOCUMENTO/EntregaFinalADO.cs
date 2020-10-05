using BE.DOCUMENTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.DOCUMENTO {
    public class EntregaFinalADO {
        grubalEntities db = new grubalEntities();

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
            } 
        }


        public Boolean EntregaFinalNew(EntregaFinalBE e) {
            bool success;
            try {
                db.EntregaFinalNew(e.Id_proyecto, e.Id_encargado, e.Path_scan_reporte, e.Fecha);

                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }

        public Boolean EliminarEntregaFinal(int idDocumento) {
            bool success;
            try {
                db.EliminarEntregaFinal(idDocumento);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception("No se pudo eliminar el documento, tiene data relacionada a ella" + x.Message);
            } 
            return success;
        }

        public Boolean ModificarEntregaFinal(EntregaFinalBE e) {
            bool success;
            try {
                db.ActualizarEntregaFinal(e.Id_documento,e.Id_proyecto, e.Id_encargado, e.Path_scan_reporte, e.Fecha);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }

        public EntregaFinalBE ListarEntregaPorId(int idDocumento) {
            EntregaFinalBE entBE;
            try {
                var r = db.ListarEntregaFinalPorId(idDocumento).FirstOrDefault();
                entBE = new EntregaFinalBE(r.id_documento, r.id_proyecto, r.id_encargado, r.path_scan_reporte, (DateTime)r.fecha);
            } catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            return entBE;
        }
    }
}
