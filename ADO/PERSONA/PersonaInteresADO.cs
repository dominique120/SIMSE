using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE;
using BE._EFE;
using BE.PROYECTO;

namespace ADO {
    public class PersonaInteresADO {
        Boolean success = false;

        public List<PersonaDeInteresBE> ListarPersonasDeInteresFull() {
            grubalEntities db = new grubalEntities();
            PersonaDeInteresBE p;
            List<PersonaDeInteresBE> list = new List<PersonaDeInteresBE>();
            try {
                var q = db.ListarPersonasDeInteresFull();

                // TODO: fix return type of project and title
                foreach(var r in q) {
                   // p = new PersonaDeInteresBE(r.Id_Persona, r.Id_Directorio, r.Proyecto, r.Puesto, r.Nombre);
                   // list.Add(p);
                }
                return list;
            } catch (Exception ex) {
                throw new Exception("Error mostrando las personas de interés: " + ex.Message);
            } 
        }

        public Boolean PersonaDeInteresNew(PersonaDeInteresBE p) {
            grubalEntities db = new grubalEntities();

            try {
                // TODO: Puesto needs to return different type
                db.PersonaDeInteresNew(p.Id_persona, p.Id_directorio, p.Id_proyecto, (short?)p.Puesto, p.Nom_persona);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;

        }
        public List<PuestoEFE> ListarPuestos() {
            grubalEntities db = new grubalEntities();
            List<PuestoEFE> list = new List<PuestoEFE>();
            PuestoEFE e;
            try {
                var q = db.ListarPuestos();
                foreach(var r in q) {
                    e = new PuestoEFE(r.id_puesto, r.desc_puesto);
                    list.Add(e);
                }
                return list;
            } catch (Exception ex) {
                throw new Exception("Error mostrando los puestos: " + ex.Message);
            } 
        }

        public List<ProyectoBE> ListarProyecto() {
            grubalEntities db = new grubalEntities();
            ProyectoBE p;
            List<ProyectoBE> list = new List<ProyectoBE>();
            try {
                var q = db.ListarProyecto();
                foreach(var r in q) {
                    p = new ProyectoBE(r.id_proyecto, r.nom_proyecto);
                    list.Add(p);
                }
                return list;
            } catch (Exception ex) {
                throw new Exception("Error mostrando proyecto: " + ex.Message);
            } 
        }

        public List<PersonaDeInteresBE> ListarPersonasDeInteres() {
            grubalEntities db = new grubalEntities();
            PersonaDeInteresBE p;
            List<PersonaDeInteresBE> list = new List<PersonaDeInteresBE>();

            try {
                var q = db.ListarPersonasDeInteres();

                foreach (var r in q) {
                    p = new PersonaDeInteresBE(r.id_persona, r.id_directorio, r.id_proyecto, r.puesto,r.nom_persona);
                    list.Add(p);
                }
                return list;

            } catch (Exception ex) {
                throw new Exception("Error mostrando PersonasDeInteres: " + ex.Message);
            } 
        }

        public PersonaDeInteresBE ListarPersonasDeInteresPorId(int idPersonaInter) {
            PersonaDeInteresBE perintBE = new PersonaDeInteresBE();
            try {
                con.ConnectionString = conection.GetCon();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "PERSONA.ListarPersonasDeInteresPorId";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", idPersonaInter);

                con.Open();
                SqlDataReader dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true) {
                    dtr.Read();
                    perintBE.Id_directorio = int.Parse(dtr["id_directorio"].ToString());
                    perintBE.Id_persona = int.Parse(dtr["id_persona"].ToString());
                    perintBE.Nom_persona = dtr["nom_persona"].ToString();
                    perintBE.Puesto = int.Parse(dtr["puesto"].ToString());
                    perintBE.Id_proyecto = int.Parse(dtr["id_proyecto"].ToString());

                } else {
                    throw new Exception("Error al buscar la persona de interés.");
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
            return perintBE;
        }

        public Boolean ModificarPersonaInteres(PersonaDeInteresBE perinteBE) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.UpdatePersonaInteres";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", perinteBE.Id_persona);
                cmd.Parameters.AddWithValue("@puesto", perinteBE.Puesto);
                cmd.Parameters.AddWithValue("@id_proyecto", perinteBE.Id_proyecto);
                cmd.Parameters.AddWithValue("@id_directorio", perinteBE.Id_directorio);
                cmd.Parameters.AddWithValue("@nom_persona", perinteBE.Nom_persona);
   

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

        public Boolean EliminarPersonaDeInteres(int idPersona) {
            con.ConnectionString = conection.GetCon();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "PERSONA.EliminarPersonaDeInteres";

            try {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id_persona", idPersona);


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
