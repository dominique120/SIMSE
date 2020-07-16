using BE.DOCUMENTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.DOCUMENTO {
    public class PlanosADO {
        Conection conection = new Conection();
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable ListarPlanosFull() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarPlanosFull";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Planos");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los Planos: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
            return dts.Tables["Planos"];
        }

        public DataTable ListarPlanosPorProyectoTipo(int id_proyecto, int id_tipo) {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarPlanosPorProyectoTipo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_proyecto", id_proyecto);
                cmd.Parameters.AddWithValue("@id_tipo", id_tipo);

                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Planos");
                return dts.Tables["Planos"];
            } catch (SqlException ex) {
                throw new Exception("Error mostrando Planos: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
        }


        public DataTable ListarPlanosPorProyecto(int id_proyecto) {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarPlanosPorProyecto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_proyecto", id_proyecto);

                SqlDataAdapter adapter;
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "Planos");
                return dts.Tables["Planos"];
            } catch (SqlException ex) {
                throw new Exception("Error mostrando Planos: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
        }

        public DataTable ListarTiposDePlano() {
            DataSet dts = new DataSet();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarTiposPlano";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dts, "TiposPlanos");
            } catch (Exception ex) {
                throw new Exception("Error mostrando los Tipos de Plano: " + ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
            }
            return dts.Tables["TiposPlanos"];
        }

        public Boolean PlanoNew(PlanoBE plBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DOCUMENTO.InsertarPlano";
            bool success;

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_proyecto", plBE.Id_proyecto);
                cmd.Parameters.AddWithValue("@revision", plBE.Revision);
                cmd.Parameters.AddWithValue("@tipo_plano", plBE.Tipo_plano);
                cmd.Parameters.AddWithValue("@dibujado_por", plBE.Dibujado_por);

                cmd.Parameters.AddWithValue("@revisado_por", plBE.Revisado_por);
                cmd.Parameters.AddWithValue("@nom_plano", plBE.Nom_plano);
                cmd.Parameters.AddWithValue("@fecha_creacion", plBE.Fecha_creacion);
                cmd.Parameters.AddWithValue("@fecha_revision", plBE.Fecha_revision);

                cmd.Parameters.AddWithValue("@fecha_envio", plBE.Fecha_envio);
                cmd.Parameters.AddWithValue("@path_plano", plBE.Path_plano);

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

        public Boolean EliminarPlano(int idPlano) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DOCUMENTO.EliminarPlano";
            bool success;

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_documento", idPlano);

                con.Open();
                cmd.ExecuteNonQuery();

                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception("No se pudo eliminar el plano, tiene data relacionada a ella" + x.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return success;
        }

        public Boolean ModificarPlano(PlanoBE plBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DOCUMENTO.ModificarPlano";
            bool success;

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_documento", plBE.Id_documento);
                cmd.Parameters.AddWithValue("@id_proyecto", plBE.Id_proyecto);
                cmd.Parameters.AddWithValue("@revision", plBE.Revision);
                cmd.Parameters.AddWithValue("@tipo_plano", plBE.Tipo_plano);
                cmd.Parameters.AddWithValue("@dibujado_por", plBE.Dibujado_por);

                cmd.Parameters.AddWithValue("@revisado_por", plBE.Revisado_por);
                cmd.Parameters.AddWithValue("@nom_plano", plBE.Nom_plano);
                cmd.Parameters.AddWithValue("@fecha_creacion", plBE.Fecha_creacion);
                cmd.Parameters.AddWithValue("@fecha_revision", plBE.Fecha_revision);

                cmd.Parameters.AddWithValue("@fecha_envio", plBE.Fecha_envio);
                cmd.Parameters.AddWithValue("@path_plano", plBE.Path_plano);

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


        public PlanoBE ListarPlanoPorId(int idDocumento) {
            PlanoBE plaBE = new PlanoBE();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DOCUMENTO.ListarPlanosPorId";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_documento", idDocumento);

                con.Open();
                SqlDataReader dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true) {
                    dtr.Read();
                    plaBE.Id_documento = int.Parse(dtr["id_documento"].ToString());
                    plaBE.Id_proyecto = int.Parse(dtr["id_proyecto"].ToString());
                    plaBE.Revision = dtr["revision"].ToString();
                    plaBE.Tipo_plano = int.Parse(dtr["tipo_plano"].ToString());
                    plaBE.Dibujado_por = int.Parse(dtr["dibujado_por"].ToString());
                    plaBE.Revisado_por = int.Parse(dtr["revisado_por"].ToString());
                    plaBE.Nom_plano = dtr["nom_plano"].ToString();
                    plaBE.Fecha_creacion = Convert.ToDateTime(dtr["fecha_creacion"]);
                    plaBE.Fecha_revision = Convert.ToDateTime(dtr["fecha_revision"]);
                    plaBE.Fecha_envio = Convert.ToDateTime(dtr["fecha_envio"]);
                    plaBE.Path_plano = dtr["path_plano"].ToString();
                } else {
                    throw new Exception("Error al buscar el documento.");
                }
                dtr.Close();

            } catch (Exception ex) {
                throw new Exception(ex.Message);
            } finally {
                if (con.State == ConnectionState.Open) {
                    con.Close();
                }
                cmd.Parameters.Clear();
            }
            return plaBE;
        }
    }
}
