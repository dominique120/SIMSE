using BE._EFE;
using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.PersonaUTIL {
    public class TelefonoADO {
        grubalEntities db = new grubalEntities();

        public List<TelefonosTiposEFE> ListarTelefonosTipos() {
            List<TelefonosTiposEFE> list = new List<TelefonosTiposEFE>();
            TelefonosTiposEFE t;
            try {
                var q = db.ListarTelefonosTipos();
                foreach (var r in q) {
                    t = new TelefonosTiposEFE(r.nombre_telefono, r.tipo_telefono);
                    list.Add(t);
                }
                return list;
            } catch (Exception ex) {
                throw new Exception("Error mostrando los tipos de teléfonos: " + ex.Message);
            } 
        }


        Boolean success = false;
        public Boolean TelefonoNew(TelefonoBE t) {
            try {
                db.TelefonoNew(t.Id_persona, (byte)t.Tipo_telefono, t.Codigo_pais, t.Campo_1, t.Campo_2, t.Campo_3, t.Ext);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            }
            return success;

        }
        public List<TelefonoBE> ListarTelefonosFull()
        {
            List<TelefonoBE> list = new List<TelefonoBE>();
            TelefonoBE t;
            try
            {
                var q = db.ListarTelefonosFull();
                foreach(var r in q) {
                    t = new TelefonoBE((int)r.Id, (int)r.Id_Persona, r.Codigo_Pais, r.C1, r.C2, r.C3, r.EXT);
                    list.Add(t);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Error mostrando los teléfonos: " + ex.Message);
            } 
        }

        public List<TelefonoBE> ListarTelefonosFullPorId(int idPersona)
        {
            List<TelefonoBE> list = new List<TelefonoBE>();
            TelefonoBE t;
            try
            {
                var q = db.ListarTelefonosFullPorId(idPersona);
               
                foreach(var r in q) {
                    t = new TelefonoBE((int)r.Id, (int)r.Id_Persona, r.Codigo_Pais, r.C1, r.C2, r.C3, r.EXT);
                    list.Add(t);
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Error mostrando los emails: " + ex.Message);
            } 
        }

        public Boolean EliminarTelefono(int idTelefono) {

            try {
                db.EliminarTelefono(idTelefono);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }

        public Boolean ModificarTelefono(TelefonoBE t) {
            try {
                db.ModificarTelefono(t.Id_telefono, (byte)t.Tipo_telefono, t.Codigo_pais, t.Campo_1, t.Campo_2, t.Campo_3, t.Ext);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }

        public TelefonoBE SelectTelefono(int id_telefono) {
            TelefonoBE telBEl;
            try {
                var r = db.SelectTelefono(id_telefono).FirstOrDefault();
                telBEl = new TelefonoBE((short)r.id_telefono, r.id_persona, r.codigo_pais, r.campo_1, r.campo_2, r.campo_3, r.ext);
                return telBEl;
            } catch (Exception ex) {
                throw new Exception("Error mostrando los teléfonos: " + ex.Message);
            }
        }
    }
}
