using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.PersonaUTIL.Direcciones {
    public class DireccionADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();


        public DataTable  ListarDistritos() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarDistritos";

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Distritos");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los distritos: " + ex.Message);
            }
            return dts.Tables["Distritos"];
        }

        public DataTable  ListarDistritosPorIdCiudad(int idCiudad) {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarDistritoPorIdPorCiudad";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_ciudad", idCiudad);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Distritos");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los distritos: " + ex.Message);
            }
            return dts.Tables["Distritos"];
        }

        public DataTable ListarCiudades() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarCiudades";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Ciudades");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los ciudades: " + ex.Message);
            }
            return dts.Tables["Ciudades"];
        }

        public DataTable ListarCiudadesPorIdRegion(int idRegion) {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarCiudadesPorIdRegion";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_region", idRegion);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Regiones");
            } catch (Exception ex) {
                throw new Exception("Error mostrando las regiones: " + ex.Message);
            }
            return dts.Tables["Regiones"];
        }

        public DataTable ListarRegiones() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarRegiones";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Regiones");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los regiones: " + ex.Message);
            }
            return dts.Tables["Regiones"];
        }

        public DataTable ListarRegionesPorIdPais(int idPais) {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarRegionesPorIdPais";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_pais", idPais);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Regiones");
            } catch (Exception ex) {
                throw new Exception("Error mostrando las regiones: " + ex.Message);
            }
            return dts.Tables["Regiones"];
        }

        public DataTable ListarPaises() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarPaises";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Países");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los países: " + ex.Message);
            }
            return dts.Tables["Países"];
        }

        public DataTable ListarDireccionesTipos() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarDireccionesTipos";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "DireccionesTipos");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los tipos de dirección: " + ex.Message);
            }
            return dts.Tables["DireccionesTipos"];
        }






        Boolean success = false;
        public Boolean DireccionNew(DireccionBE dirBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.DireccionNew";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@tipo_direccion", dirBE.Tipo_direccion);
                cmd.Parameters.AddWithValue("@id_persona", dirBE.Id_persona);
                cmd.Parameters.AddWithValue("@dir_pais", dirBE.Dir_pais);
                cmd.Parameters.AddWithValue("@dir_provincia", dirBE.Dir_provincia);

                cmd.Parameters.AddWithValue("@dir_ciudad", dirBE.Dir_ciudad);
                cmd.Parameters.AddWithValue("@dir_distrito", dirBE.Dir_distrito);
                cmd.Parameters.AddWithValue("@dir_linea_1", dirBE.Dir_linea_1);
                cmd.Parameters.AddWithValue("@dir_linea_2", dirBE.Dir_linea_2);
                cmd.Parameters.AddWithValue("@dir_codigo_postal", dirBE.Dir_codigo_postal);

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
    }
}
