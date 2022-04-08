using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GestionPret.BD
{
    class DataClients
    {
        /// <summary>
        /// Variable de qui contient les information pour la connexion au serveur
        /// </summary>
        private MySqlConnection con;

        /// <summary>
        /// Variable statique qui permet de rendre la classe static
        /// </summary>
        private static DataClients instance = null;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public DataClients()
        {
            this.con = new MySqlConnection("Server=localhost;Database=serge;Uid=root;Pwd=;port=3306; charset=utf8;");
        }

        /// <summary>
        /// Méthode qui rend la classe static (Singleton)
        /// </summary>
        /// <returns>Data_Systeme</returns>
        public static DataClients GetInstance()
        {
            if (instance == null)
            {
                instance = new DataClients();
            }
            return instance;
        }

        /********************************* Méthode pour les types de clients **************************************/

        /// <summary>
        /// Méthode qui retoure les types de clients sous forme de list
        /// </summary>
        /// <returns>List de string</returns>
        public List<String> GetTypesClients()
        {
            MySqlDataReader r = null;

            List<String> listForfaits = new List<String>();

            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "SELECT * " +
                                       "FROM types_clients; ";

                con.Open();
                r = commande.ExecuteReader();

                while (r.Read())
                {
                    listForfaits.Add(r[0].ToString() + " - " + r[1].ToString());
                }

                return listForfaits;
            }
            catch
            {
                return listForfaits;
            }
            finally
            {
                if (r != null)
                    r.Close();

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /************************************** Méthode pour les clients *******************************************/

        /// <summary>
        /// Méthode qui retourne les informations pour un seul client
        /// </summary>
        /// <param name="_IdClient">Id du client</param>
        /// <returns>DataTable</returns>
        public DataTable GetClient(String _IdClient)
        {
            DataTable tabClient = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "SELECT * " +
                                       "FROM vw_clients " +
                                       "WHERE id_client = @idClient; ";

                commande.Parameters.Add("@idClient", MySqlDbType.String).Value = _IdClient;

                con.Open();
                commande.Prepare();
                r = commande.ExecuteReader();

                tabClient = new DataTable("client");
                tabClient.Load(r);

                return tabClient;
            }
            catch
            {
                return tabClient;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                if (r != null)
                    r.Close();
            }
        }

        /// <summary>
        /// Méthode qui retourne toutes les locations d'un clients
        /// </summary>
        /// <param name="_IdClient">ID du client</param>
        /// <returns>DataTable</returns>
        public DataTable GetDataLocationsClient(String _IdClient)
        {
            DataTable tabLocations = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "SELECT date_debut, " +
                                        "description_equipement, " +
                                        "description, " +
                                        "date_retour_prevu " +
                                       "FROM vw_locations_clients " +
                                       "WHERE client_id = @idclient; ";

                commande.Parameters.Add("@idClient", MySqlDbType.String).Value = _IdClient;

                con.Open();
                commande.Prepare();
                r = commande.ExecuteReader();

                tabLocations = new DataTable("locations");

                tabLocations.Load(r);

                return tabLocations;
            }
            catch
            {
                return tabLocations;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                if (r != null)
                    r.Close();
            }
        }

        /// <summary>
        /// Méthode qui permet d'ajouter un client
        /// </summary>
        /// <param name="_Matricule">Matricule du client</param>
        /// <param name="_Nom">Nom du client</param>
        /// <param name="_Prenom">Prénom du client</param>
        /// <param name="_Type">Type de client</param>
        /// <param name="_Departement">Département du client</param>
        /// <param name="_Telephone">Téléphone du client</param>
        /// <param name="_Courriel">Courriel du client</param>
        /// <returns>Boolean</returns>
        public Boolean AjouterClient(String _Matricule, String _Nom, String _Prenom, int _Type,
                                  String _Departement, String _Telephone, String _Courriel)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "INSERT INTO clients " +
                                       "VALUES(@matricule, @nom, @prenom, @type, @departement, @courriel, @telephone); ";

                commande.Parameters.Add("@matricule", MySqlDbType.String).Value = _Matricule;
                commande.Parameters.Add("@nom", MySqlDbType.String).Value = _Nom;
                commande.Parameters.Add("@prenom", MySqlDbType.String).Value = _Prenom;
                commande.Parameters.Add("@type", MySqlDbType.Int32).Value = _Type;
                commande.Parameters.Add("@departement", MySqlDbType.String).Value = _Departement;
                commande.Parameters.Add("@courriel", MySqlDbType.String).Value = _Courriel;
                commande.Parameters.Add("@telephone", MySqlDbType.String).Value = _Telephone;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Serge | Ajout d'un client - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// Méthode qui permet de modifier les informations d'un client
        /// </summary>
        /// <param name="_Matricule">Matricule du client</param>
        /// <param name="_Nom">Nom du client</param>
        /// <param name="_Prenom">Prénom du client</param>
        /// <param name="_Type">Type de client</param>
        /// <param name="_Departement">Département du client</param>
        /// <param name="_Telephone">Téléphone du client</param>
        /// <param name="_Courriel">Courriel du client</param>
        /// <param name="_AncMatricule">Ancien matricule du client</param>
        /// <returns></returns>
        public Boolean ModifierClient(String _Matricule, String _Nom, String _Prenom, int _Type,
                                   String _Departement, String _Telephone, String _Courriel, String _AncMatricule)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };
 
                commande.CommandText = "UPDATE clients " +
                                       "SET id_client = @matricule, " +
                                       "nom_client = @nom, " +
                                       "prenom_client = @prenom, " +
                                       "type_id = @type, " +
                                       "departement = @departement, " +
                                       "courriel = @courriel, " +
                                       "telephone = @telephone " +
                                       "WHERE id_client = @ancienmatricule;";

                commande.Parameters.Add("@matricule", MySqlDbType.String).Value = _Matricule;
                commande.Parameters.Add("@nom", MySqlDbType.String).Value = _Nom;
                commande.Parameters.Add("@prenom", MySqlDbType.String).Value = _Prenom;
                commande.Parameters.Add("@type", MySqlDbType.Int32).Value = _Type;
                commande.Parameters.Add("@departement", MySqlDbType.String).Value = _Departement;
                commande.Parameters.Add("@courriel", MySqlDbType.String).Value = _Courriel;
                commande.Parameters.Add("@telephone", MySqlDbType.String).Value = _Telephone;
                commande.Parameters.Add("@ancienmatricule", MySqlDbType.String).Value = _AncMatricule;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Serge | Modification d'un client - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
}
