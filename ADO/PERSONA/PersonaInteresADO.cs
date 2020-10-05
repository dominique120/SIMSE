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

                foreach(var r in q) {
                   p = new PersonaDeInteresBE(r.Id_Persona, r.Id_Directorio, r.proyecto_id, r.puesto_id, r.Nombre);
                   list.Add(p);
                }
                return list;
            } catch (Exception ex) {
                throw new Exception("Error mostrando las personas de interés: " + ex.Message);
            } 
        }

        public Boolean PersonaDeInteresNew(PersonaDeInteresBE p) {
            grubalEntities db = new grubalEntities();

            try {
                db.PersonaDeInteresNew(p.Id_persona, p.Id_directorio, p.Id_proyecto, (short)p.Puesto, p.Nom_persona);
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
            grubalEntities db = new grubalEntities();
            PersonaDeInteresBE p;

            try {
                var q = db.ListarPersonasDeInteresPorId(idPersonaInter).FirstOrDefault();

                p = new PersonaDeInteresBE(q.id_persona, q.id_directorio, q.id_proyecto, q.puesto, q.nom_persona);
                return p;
            } catch (Exception ex) {
                throw new Exception(ex.Message);
            } 
        }

        public Boolean ModificarPersonaInteres(PersonaDeInteresBE p) {
            grubalEntities db = new grubalEntities();
            try {
                db.UpdatePersonaInteres(p.Id_persona, p.Id_directorio, p.Id_proyecto, (short)p.Puesto, p.Nom_persona);

                success = true;

            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }

        public Boolean EliminarPersonaDeInteres(int idPersona) {
            grubalEntities db = new grubalEntities();
            try {
                db.EliminarPersonaDeInteres(idPersona);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }
    }
}
