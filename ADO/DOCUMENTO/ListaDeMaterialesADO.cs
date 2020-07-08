using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.DOCUMENTO {
    class ListaDeMaterialesADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable ListarMaterialesPorProyecto(int id_proyecto) {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarMaterialesPorProyecto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_proyecto", id_proyecto);

                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "ListaMateriales");
                return dts.Tables["ListaMateriales"];
            } catch (SqlException ex) {
                throw new Exception("Error mostrando las Listas de Materiales: " + ex.Message);
            }
        }
    }
}
