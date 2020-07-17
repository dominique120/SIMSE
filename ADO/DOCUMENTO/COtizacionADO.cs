using BE.DOCUMENTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.DOCUMENTO {
    public class CotizacionADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable ListarCotizacionesPorProyecto(int id_proyecto) {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarCotizacionesPorProyecto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_proyecto", id_proyecto);

                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Cotizaciones");
                return dts.Tables["Cotizaciones"];
            } catch (SqlException ex) {
                throw new Exception("Error mostrando las Cotizaciones: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
        }

        public int CotizacionConDetallesNew(CotizacionBE cotBE) {
            try {
                con.ConnectionString = conection.GetCon();

                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.CotizacionNew";
                cmd.Parameters.Clear();

                cmd.Parameters.Add(new SqlParameter("@id_proyecto", cotBE.Id_proyecto));
                cmd.Parameters.Add(new SqlParameter("@id_encargado", cotBE.Id_encargado));
                cmd.Parameters.Add(new SqlParameter("@id_aprobado_por", cotBE.Id_aprobado_por));
                cmd.Parameters.Add(new SqlParameter("@enviar_a", cotBE.Enviar_a));
                cmd.Parameters.Add(new SqlParameter("@fecha_aprobacion", cotBE.Fecha_aprobacion));

                cmd.Parameters.Add(new SqlParameter("@fecha_creacion", cotBE.Fecha_creacion));
                cmd.Parameters.Add(new SqlParameter("@fecha_envio", cotBE.Fecha_envio));

                cmd.Parameters.Add(new SqlParameter("@notas", cotBE.Notas));
                cmd.Parameters.Add(new SqlParameter("@path_archivo", cotBE.Path_archivo));

                cmd.Parameters.Add(new SqlParameter("@rnid", SqlDbType.Int));

                cmd.Parameters["@rnid"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add(new SqlParameter("@detalles", SqlDbType.Structured));
                cmd.Parameters["@detalles"].Value = cotBE.DetalleDeCotizacion;


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
