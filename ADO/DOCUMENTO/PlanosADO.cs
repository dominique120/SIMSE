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
        grubalEntities db = new grubalEntities();
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
            }
        }

        public Boolean PlanoNew(PlanoBE p) {
            bool success;
            try {
                db.InsertarPlano(p.Id_proyecto, p.Revision, p.Tipo_plano, p.Dibujado_por, p.Revisado_por, p.Nom_plano, p.Fecha_creacion, p.Fecha_revision, p.Fecha_envio, p.Path_plano);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            }
            return success;
        }

        public Boolean EliminarPlano(int idPlano) {
            bool success;
            try {
                db.EliminarPlano(idPlano);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception("No se pudo eliminar el plano, tiene data relacionada a ella" + x.Message);
            }
            return success;
        }

        public Boolean ModificarPlano(PlanoBE p) {
            bool success;
            try {
                db.ModificarPlano(p.Id_documento, p.Id_proyecto, p.Revision, p.Tipo_plano, p.Dibujado_por, p.Revisado_por, p.Nom_plano, p.Fecha_creacion, p.Fecha_revision, p.Fecha_envio, p.Path_plano);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            }
            return success;
        }

        public PlanoBE ListarPlanoPorId(int idDocumento) {
            PlanoBE plaBE;
            try {
                var q = db.ListarPlanosPorId(idDocumento).FirstOrDefault();
                plaBE = new PlanoBE(q.id_documento, q.id_proyecto, q.revision, q.tipo_plano, q.dibujado_por, q.revisado_por, q.nom_plano, (DateTime)q.fecha_creacion, (DateTime)q.fecha_revision, (DateTime)q.fecha_envio, q.path_plano);
            } catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            return plaBE;
        }
    }
}
