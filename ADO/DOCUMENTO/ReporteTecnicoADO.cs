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
            }
        }
    }
}
