using BE.PERSONA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO {
    public class ClienteADO {
        bool success = false;

        public List<ClienteBE> ListarClientesFull() {
            grubalEntities db = new grubalEntities();
            List<ClienteBE> cliList = new List<ClienteBE>();

            try {
                var query = db.ListarClientesFull();

                foreach (var result in query) {
                    ClienteBE bE = new ClienteBE {
                        Doc_oficial = result.Documento,
                        Marketing = result.ID_Ficha_Marketing,
                        Id_persona = result.ID_Persona,
                        Nom_cliente = result.Nombre_Cliente
                    };
                    cliList.Add(bE);
                }
                return cliList;

            } catch (Exception ex) {
                throw new Exception("Error mostrando clientes: " + ex.Message);
            } 
        }

        public Boolean ClienteNew(ClienteBE cliBE) {
            grubalEntities db = new grubalEntities();
            try {
                db.ClienteNew(cliBE.Id_persona, cliBE.Marketing, cliBE.Nom_cliente, cliBE.Doc_oficial);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            } 
            return success;
        }

        public Boolean EliminarCliente(int IdCliente, int IdFichaMarketing) {
            grubalEntities db = new grubalEntities();
            try {
                db.EliminarCliente(IdCliente, IdFichaMarketing);

                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception("No se pudo eliminar la persona, tiene data relacionada a ella" + x.Message);
            } 
            return success;
        }

        public Boolean ModificarCliente(ClienteBE cliBE) {
            grubalEntities db = new grubalEntities();

            try {
                db.ModificarCliente(cliBE.Id_persona, cliBE.Marketing, cliBE.Nom_cliente, cliBE.Doc_oficial);
                success = true;
            } catch (SqlException x) {
                success = false;
                throw new Exception(x.Message);
            }
            return success;
        }

        public List<ClienteBE> ListarClientes() {
            grubalEntities db = new grubalEntities();
            List<ClienteBE> cliList = new List<ClienteBE>();
            try {
                var query = db.ListarClientes();

                foreach (var result in query) {
                    ClienteBE bE = new ClienteBE {
                        Doc_oficial = result.doc_oficial,
                        Marketing = result.marketing,
                        Id_persona = result.id_persona,
                        Nom_cliente = result.nom_cliente
                    };
                    cliList.Add(bE);
                }
                return cliList;
 
            } catch (Exception ex) {
                throw new Exception("Error mostrando los clientes: " + ex.Message);
            } 
        }

        public ClienteBE ListarClientesPorId(int idCliente) {
            ClienteBE cliBE = new ClienteBE();
            grubalEntities db = new grubalEntities();
            try {

                var query = db.ListarClientesPorId(idCliente).FirstOrDefault();

                cliBE.Doc_oficial = query.doc_oficial;
                cliBE.Nom_cliente = query.nom_cliente;
                cliBE.Marketing = query.marketing;
                cliBE.Id_persona = query.id_persona;

            } catch (Exception ex) {
                throw new Exception(ex.Message);
            } 
            return cliBE;
        }
    }
}
