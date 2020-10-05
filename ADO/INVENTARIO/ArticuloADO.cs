using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.INVENTARIO {
    public class ArticuloADO {
        grubalEntities db = new grubalEntities();

        public DataTable ListarArticulos() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "INVENTARIO.ListarArticulos";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Articulos");
            } catch (Exception ex) {
                throw new Exception("Error mostrando Articulos: " + ex.Message);
            } 
        }
    }
}
