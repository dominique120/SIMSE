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

        public DataTable ListarDistritos() {
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
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                    cmd.Parameters.Clear();
                }
            }
            return dts.Tables["Distritos"];
        }

        public DataTable ListarDistritosPorIdCiudad(int idCiudad) {
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
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                    cmd.Parameters.Clear();
                }
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
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                    cmd.Parameters.Clear();
                }
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
                throw new Exception("Error mostrando las ciudades: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                    cmd.Parameters.Clear();
                }
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
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                    cmd.Parameters.Clear();
                }
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
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                    cmd.Parameters.Clear();
                }
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
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                    cmd.Parameters.Clear();
                }
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
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                    cmd.Parameters.Clear();
                }
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

        public DataTable ListarDireccionesFull() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarDireccionesFull";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Direcciones");
            } catch (Exception ex) {
                throw new Exception("Error mostrando las direcciones: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    cmd.Parameters.Clear();
                    con.Close();
                }
            }
            return dts.Tables["Direcciones"];
        }

        public DataTable ListarPersonasConDirecciones() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarPersonasConDirecciones";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "PersonasConDirecciones");
            } catch (Exception ex) {
                throw new Exception("Error mostrando las personas con direcciones: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
            return dts.Tables["PersonasConDirecciones"];
        }

        public DataTable ListarDireccionesFullPorId(int idPersona) {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarDireccionesFullPorId";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", idPersona);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Direcciones");
            } catch (Exception ex) {
                throw new Exception("Error mostrando las direcciones: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                    cmd.Parameters.Clear();
                }
            }
            return dts.Tables["Direcciones"];
        }

        public DireccionBE SelectDireccion(int idDireccion) {
            DataSet dts = new DataSet();
            DireccionBE dirBE = new DireccionBE();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.SelectDireccion";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_direccion", idDireccion);

                con.Open();
                SqlDataReader dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true) {
                    dtr.Read();
                    dirBE.Tipo_direccion = byte.Parse(dtr["tipo_direccion"].ToString());
                    dirBE.Id_direccion = int.Parse(dtr["id_direccion"].ToString());
                    dirBE.Id_persona = int.Parse(dtr["id_persona"].ToString());
                    dirBE.Dir_pais = short.Parse(dtr["dir_pais"].ToString());
                    dirBE.Dir_provincia = int.Parse(dtr["dir_provincia"].ToString());
                    dirBE.Dir_ciudad = int.Parse(dtr["dir_ciudad"].ToString());
                    dirBE.Dir_distrito = int.Parse(dtr["dir_distrito"].ToString());
                    dirBE.Dir_linea_1 = dtr["dir_linea_1"].ToString();
                    dirBE.Dir_linea_2 = dtr["dir_linea_2"].ToString();
                    dirBE.Dir_codigo_postal = dtr["dir_codigo_postal"].ToString();

                } else {
                    throw new Exception("Error al buscar la dirección.");
                }
                dtr.Close();
            } catch (Exception ex) {
                throw new Exception("Error mostrando las direcciones: " + ex.Message);
            } finally {
                con.Close();
                cmd.Parameters.Clear();
            }
            return dirBE;
        }

        public Boolean ModificarDireccion(DireccionBE dirBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.ModificarDireccion";

            try {
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@id_direccion", dirBE.Id_direccion);
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

            } catch (Exception x) {
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

        public Boolean EliminarDireccion(int idDireccion) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.EliminarDireccion";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_direccion", idDireccion);

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
