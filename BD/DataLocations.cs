using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestionPret.BD
{
    class DataLocations
    {
        /// <summary>
        /// Variable de qui contient les information pour la connexion au serveur
        /// </summary>
        private MySqlConnection con;

        /// <summary>
        /// Variable statique qui permet de rendre la classe static
        /// </summary>
        private static DataLocations instance = null;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public DataLocations()
        {
            this.con = new MySqlConnection("Server=localhost;Database=serge;Uid=root;Pwd=;port=3306; charset=utf8;");
        }

        /// <summary>
        /// Méthode qui rend la classe static (Singleton)
        /// </summary>
        /// <returns>Data_Systeme</returns>
        public static DataLocations GetInstance()
        {
            if (instance == null)
            {
                instance = new DataLocations();
            }
            return instance;
        }

        /// <summary>
        /// Méthode qui permet d'ajouter des locations
        /// </summary>
        /// <param name="_IdClient">Id du client</param>
        /// <param name="_DateDebut">date de début</param>
        /// <returns></returns>
        public Boolean AjouterLocation(String _IdClient, DateTime _DateDebut)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "INSERT INTO locations " +
                                       "VALUES(null, @client, @date, 0, null); ";

                commande.Parameters.Add("@client", MySqlDbType.String).Value = _IdClient;
                commande.Parameters.Add("@date", MySqlDbType.DateTime).Value = _DateDebut;

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
        /// Méthode qui retourne la dernière location entrée
        /// </summary>
        /// <returns>Integer</returns>
        public int GetDerniereLocation()
        {
            int idDerniereLocation = 0;
            DataTable tabClient = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "SELECT * " +
                                       "FROM vw_derniere_location; ";

                con.Open();
                commande.Prepare();
                r = commande.ExecuteReader();

                tabClient = new DataTable("client");
                tabClient.Load(r);

                idDerniereLocation = Convert.ToInt32(tabClient.Rows[0][0].ToString());

                return idDerniereLocation;
            }
            catch
            {
                return idDerniereLocation;
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
        /// Méthode qui retourne la liste de locations en cours
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable GetDataLocationsCourrantes()
        {
            DataTable tabClient = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "SELECT * " +
                                       "FROM vw_locations_courantes; ";

                con.Open();
                commande.Prepare();
                r = commande.ExecuteReader();

                tabClient = new DataTable("locations");
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
        /// Méthode qui retourne les locations en retard
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable GetDataRetardsLocations()
        {
            DataTable tabLocations = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "SELECT * " +
                                       "FROM vw_retards_locations; ";

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
        /// Méthode qui retourne les retours de la journee
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable GetDataRetourJournee()
        {
            DataTable tabLocations = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "SELECT client, " +
                                       "description_equipement, " +
                                       "date_retour_prevu " +
                                       "FROM vw_retours_journee; ";

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
        /// Méthode qui permet d'ajouter un produit a une location
        /// </summary>
        /// <param name="_LocationID">Id de la location</param>
        /// <param name="_Equipement">Id de l'équipement</param>
        /// <param name="_DateRetour">Date de retour prevu</param>
        /// <param name="_EtatEquipement">État de l'équipement</param>
        /// <returns>Boolean indiquant si l'ajout a été effectué</returns>
        public Boolean AjouterProduitLocation(int _LocationID, String _Equipement, DateTime _DateRetour, int _EtatEquipement)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "INSERT INTO locations_equipements " +
                                       "VALUES(@idLocation, @equipement, @dateretour, @etat, null, null, null); ";

                commande.Parameters.Add("@idLocation", MySqlDbType.Int32).Value = _LocationID;
                commande.Parameters.Add("@equipement", MySqlDbType.String).Value = _Equipement;
                commande.Parameters.Add("@dateretour", MySqlDbType.DateTime).Value = _DateRetour;
                commande.Parameters.Add("@etat", MySqlDbType.Int32).Value = _EtatEquipement;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Serge | Ajout d'une location - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// Supprime une nouvelle location et les équipements de cette locations s'ils y a eu un erreur dans 
        /// l'entrée de données
        /// </summary>
        /// <param name="_LocationID">ID de la location</param>
        /// <returns></returns>
        public Boolean SupprimerProduitErreur(int _LocationID)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "DELETE FROM locations_equipements " +
                                       "WHERE location_id = @idLocation; " +
                                       "DELETE FROM locations " +
                                       "WHERE location_id = @idLocation; ";

                commande.Parameters.Add("@idLocation", MySqlDbType.Int32).Value = _LocationID;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Serge | Ajout d'une location - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// Retourne tous les équipements qu'un client a emprunté
        /// </summary>
        /// <param name="_ClientId">Id du client</param>
        /// <returns>DataTable</returns>
        public DataTable GetDataEquipementsRetour(String _ClientId)
        {
            DataTable tabLocations = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con }; ;

                commande.CommandText = "SELECT * " +
                                       "FROM vw_location_retour " +
                                       "WHERE client_id = @idclient; ";

                commande.Parameters.Add("@idClient", MySqlDbType.String).Value = _ClientId;

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
        /// Crée un nouveau retour
        /// </summary>
        /// <param name="_ClientId">Id du client</param>
        /// <param name="_DateRetour">Date du retour</param>
        /// <returns>Boolean indiquant si le retour a été effectué correctement</returns>
        public Boolean AjouterRetour(String _ClientId, DateTime _DateRetour)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "INSERT INTO retours " +
                                       "VALUES(null, @client, @date, null); ";

                commande.Parameters.Add("@client", MySqlDbType.String).Value = _ClientId;
                commande.Parameters.Add("@date", MySqlDbType.DateTime).Value = _DateRetour;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Serge | Retour location - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// Retour le ID du dernier retour qui a été fait
        /// </summary>
        /// <returns>Integer</returns>
        public int GetDernierRetour()
        {
            int idDernierRetour = 0;
            DataTable tabRetour = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "SELECT * " +
                                       "FROM vw_dernier_retour; ";

                con.Open();
                commande.Prepare();
                r = commande.ExecuteReader();

                tabRetour = new DataTable("retour");
                tabRetour.Load(r);

                idDernierRetour = Convert.ToInt32(tabRetour.Rows[0][0].ToString());

                return idDernierRetour;
            }
            catch
            {
                return idDernierRetour;
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
        /// Méthode qui confirme les équipements qui ont été retournées
        /// Elle modifie la table locations_equipements et y inscrit les informations du retour
        /// </summary>
        /// <param name="_RetourId">ID du retour</param>
        /// <param name="_LocationID">ID de la location</param>
        /// <param name="_Equipement">ID de l'équipement</param>
        /// <param name="_Etat">État de l'équipement au moment du retour</param>
        /// <returns>Boolean indiquant si la modificaiton a été faite correctement</returns>
        public Boolean RetournerEquipement(int _RetourId, int _LocationID, String _Equipement, int _Etat)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;
                commande.CommandText = "UPDATE locations_equipements " +
                                       "SET retour_id = @retourId, " +
                                           "statut_equipement_ap_retour = @etat " +
                                       "WHERE location_id = @locationId AND equipement_id = @equipement;";

                commande.Parameters.Add("@retourId", MySqlDbType.Int32).Value = _RetourId;
                commande.Parameters.Add("@etat", MySqlDbType.Int32).Value = _Etat;
                commande.Parameters.Add("@locationId", MySqlDbType.Int32).Value = _LocationID;
                commande.Parameters.Add("@equipement", MySqlDbType.String).Value = _Equipement;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Serge | Retour location - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// Retourne le code du client de la location
        /// </summary>
        /// <param name="_IdLocation">ID de la location</param>
        /// <returns>Code du client</returns>
        public String GetClientLocation(int _IdLocation)
        {
            String idClient = null;
            DataTable tabClient = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "SELECT * " +
                                       "FROM locations " +
                                       "WHERE id_location = @location; ";

                commande.Parameters.Add("@location", MySqlDbType.Int32).Value = _IdLocation;

                con.Open();
                commande.Prepare();
                r = commande.ExecuteReader();

                tabClient = new DataTable("client");
                tabClient.Load(r);

                idClient = tabClient.Rows[0][1].ToString();

                return idClient;
            }
            catch
            {
                return idClient;
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
        /// Retourne la liste d'équipement d'une location
        /// </summary>
        /// <param name="_IdLocation">ID de la location</param>
        /// <returns>DataTable</returns>
        public DataTable GetDataEquipementsLocation(int _IdLocation)
        {
            DataTable tabLocations = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "SELECT * " +
                                       "FROM vw_equipements_locations " +
                                       "WHERE location_id = @idlocation; ";

                commande.Parameters.Add("@idlocation", MySqlDbType.String).Value = _IdLocation;

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
        /// Valide si ouvert la journée sélectionné
        /// </summary>
        /// <param name="_Journee">Journée</param>
        /// <returns>Boolean</returns>
        public Boolean ValiderJourneeDisponible(String _Journee)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "SELECT count(*) FROM vw_jours_ouvert " +
                                       "WHERE journee = @journee;";

                commande.Parameters.AddWithValue("@journee", _Journee);

                con.Open();
                commande.Prepare();
                var result = commande.ExecuteScalar();

                if (result.ToString().Equals("0"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// Valide si la période est disponible
        /// </summary>
        /// <param name="_Journee">Journee</param>
        /// <param name="_Heure">Heure</param>
        /// <returns>Boolean</returns>
        public Boolean ValiderPeriodeDisponible(String _Journee, String _Heure)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand() { Connection = this.con };

                commande.CommandText = "SELECT count(*) FROM vw_jours_ouvert " +
                                       "WHERE journee = @journee AND @heure > heure_debut AND @heure < heure_fin ;";

                commande.Parameters.AddWithValue("@journee", _Journee);
                commande.Parameters.AddWithValue("@heure", _Heure);

                con.Open();
                commande.Prepare();
                var result = commande.ExecuteScalar();

                if (result.ToString().Equals("0"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
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
