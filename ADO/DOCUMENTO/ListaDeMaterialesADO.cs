using BE.DOCUMENTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.DOCUMENTO {
    public class ListaDeMaterialesADO {
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
                cmd.Parameters.AddWithValue("@proyecto", id_proyecto);

                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "ListaMateriales");
                return dts.Tables["ListaMateriales"];
            } catch (SqlException ex) {
                throw new Exception("Error mostrando las Listas de Materiales: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
        }

        public int ListaMaterialesConDetallesNew(ListaDeMaterialesBE matBE) {
            try {
                con.ConnectionString = conection.GetCon();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListaMaterialesNew";
                cmd.Parameters.Clear();
                
                cmd.Parameters.Add(new SqlParameter("@proyecto", matBE.Proyecto));
                cmd.Parameters.Add(new SqlParameter("@pedido_por", matBE.Pedido_por));
                cmd.Parameters.Add(new SqlParameter("@fecha_pedida", matBE.Fecha_pedida));
                cmd.Parameters.Add(new SqlParameter("@fecha_aprobada", matBE.Fecha_aprobada));

                cmd.Parameters.Add(new SqlParameter("@aprobado", matBE.Aprobado));
                cmd.Parameters.Add(new SqlParameter("@aprobado_por", matBE.Aprobado_por));
                cmd.Parameters.Add(new SqlParameter("@ingresado_por", matBE.Ingresado_por));
                cmd.Parameters.Add(new SqlParameter("@rnid", SqlDbType.Int));

                cmd.Parameters["@rnid"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new SqlParameter("@detalles", SqlDbType.Structured));
                cmd.Parameters["@detalles"].Value = matBE.DetalleDeListaMateriales;


                con.Open();
                cmd.ExecuteNonQuery();
                return Convert.ToInt32(cmd.Parameters["@rnid"].Value.ToString());
            } catch (Exception) {

                return -1;
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
        }
    }
}
