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

        public DataTable ListarEntregaFinalFull() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarEntregaFinalFull";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "EntregaFinal");
            } catch (Exception ex) {
                throw new Exception("Error mostrando las Entregas Finales: " + ex.Message);
            }
            return dts.Tables["EntregaFinal"];
        }

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
    }
}
