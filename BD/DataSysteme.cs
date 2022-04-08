using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GestionPret.BD
{
    class DataSysteme
    {
        /// <summary>
        /// Variable de qui contient les information pour la connexion au serveur
        /// </summary>
        private MySqlConnection con;

        /// <summary>
        /// Variable statique qui permet de rendre la classe static
        /// </summary>
        private static DataSysteme instance = null;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public DataSysteme()
        {
            this.con = new MySqlConnection("Server=localhost;Database=serge;Uid=root;Pwd=;port=3306; charset=utf8;");
        }

        /// <summary>
        /// Méthode qui rend la classe static (Singleton)
        /// </summary>
        /// <returns>Data_Systeme</returns>
        public static DataSysteme GetInstance()
        {
            if (instance == null)
            {
                instance = new DataSysteme();
            }
            return instance;
        }

        /********************************* Méthode pour vérifier utilisateur et mot de passe **************************************/

        /// <summary>
        /// Méthode qui valide si l'utilisateur existe
        /// </summary>
        /// <param name="_IdUtilisateur">Username</param>
        /// <returns>Boolean</returns>
        public Boolean ValiderUtilisateurExiste(String _IdUtilisateur)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                commande.CommandText = $"SELECT count(*) FROM utilisateurs " +
                                       $"WHERE id_utilisateur=@idUtilisateur;";
                commande.Parameters.AddWithValue("@idUtilisateur", _IdUtilisateur);

                con.Open();
                commande.Prepare();
                var result = commande.ExecuteScalar();

                if (result.ToString().Equals("0"))
                {
                    con.Close();
                    return false;
                }
                else
                {
                    con.Close();
                    return true;
                }
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                return false;
            }
        }

        /// <summary>
        /// Méthode qui valide le mdp de l'utilisateur
        /// </summary>
        /// <param name="_IdUtilisateur">Nom d'utilisateur</param>
        /// <returns>Boolean</returns>
        public String ValiderPasswordUtilisateur(String _IdUtilisateur)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                commande.CommandText = $"SELECT mot_passe " +
                                       $"FROM utilisateurs " +
                                       $"WHERE id_utilisateur=@IdUtilisateur;";

                commande.Parameters.AddWithValue("@IdUtilisateur", _IdUtilisateur);

                con.Open();
                commande.Prepare();
                var result = commande.ExecuteScalar();


                con.Close();
                return result.ToString();

            }
            catch
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                return "";
            }
        }

        /********************************* Méthode pour ajouter un utilisateur **************************************/

        /// <summary>
        /// Méthode qui permet l'ajout de nouveaux utilisateur dans la base de données
        /// </summary>
        /// <param name="_IdUtilisateur">Id utilisateur</param>
        /// <param name="_Nom">Nom de l'utilisateur</param>
        /// <param name="_Prenom">Prenom de l'utilisateur</param>
        /// <param name="_Mdp">Mot de passe</param>
        /// <returns>DataTable</returns>
        public Boolean AjouterUtilisateur(String _IdUtilisateur, String _Nom, String _Prenom, String _Mdp)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                commande.CommandText = "INSERT INTO utilisateurs " +
                                       "VALUES(@idUtilisateur, @nom, @prenom, @mdp); ";

                commande.Parameters.Add("@idUtilisateur", MySqlDbType.String).Value = _IdUtilisateur;
                commande.Parameters.Add("@nom", MySqlDbType.String).Value = _Nom;
                commande.Parameters.Add("@prenom", MySqlDbType.String).Value = _Prenom;
                commande.Parameters.Add("@mdp", MySqlDbType.String).Value = _Mdp;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();
                con.Close();

                return true;
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                    con.Close();

                return false;
            }
        }

        /// <summary>
        /// Retourne la liste des utilisateurs
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable GetListUtilisateur()
        {
            DataTable tabListUtilisateur = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;
                commande.CommandText = "SELECT id_utilisateur AS ID_Utilisateur, nom_utilisateur AS Nom, prenom_utilisateur AS Prenom  " +
                                       "FROM utilisateurs  ";

                con.Open();
                commande.Prepare();
                r = commande.ExecuteReader();

                tabListUtilisateur = new DataTable("utilisateur");
                tabListUtilisateur.Load(r);

                r.Close();
                con.Close();

                return tabListUtilisateur;
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                if (r != null)
                    r.Close();

                return tabListUtilisateur;
            }
        }

        public Boolean UpdateDispos(string journee, int periode, int ouvert)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                commande.CommandText = "UPDATE horaire_ouverture " +
                                       "SET is_ouvert = @ouvert " +
                                       "WHERE journee = @journee AND periode_id = @periode;";

                commande.Parameters.Add("@journee", MySqlDbType.String).Value = journee;
                commande.Parameters.Add("@ouvert", MySqlDbType.Int32).Value = ouvert;
                commande.Parameters.Add("@periode", MySqlDbType.Int32).Value = periode;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Serge | Modification des disponibilitées - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// Retourne l'horaire
        /// </summary>
        /// <returns>DataTable de l'horaire</returns>
        public DataTable GetHoraire()
        {
            DataTable tabHoraire = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;
                commande.CommandText = "SELECT * " +
                                       "FROM horaire_ouverture; ";

                con.Open();
                commande.Prepare();
                r = commande.ExecuteReader();

                tabHoraire = new DataTable("horaire");
                tabHoraire.Load(r);

                return tabHoraire;
            }
            catch
            {
                return tabHoraire;
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
        /// Retourne les informations d'un utilisateur
        /// </summary>
        /// <param name="_Utilisateur">Numéro d'utilisateur</param>
        /// <returns>DataTable</returns>
        public DataTable GetUtilisateur(String _Utilisateur)
        {
            DataTable tabUtilisateur = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;
                commande.CommandText = "SELECT id_utilisateur, nom_utilisateur, prenom_utilisateur " +
                                       "FROM utilisateurs " +
                                       "WHERE id_utilisateur = @idUtilisateur  ";

                commande.Parameters.Add("@idUtilisateur", MySqlDbType.String).Value = _Utilisateur;

                con.Open();
                commande.Prepare();
                r = commande.ExecuteReader();

                tabUtilisateur = new DataTable("utilisateur");
                tabUtilisateur.Load(r);

                r.Close();
                con.Close();

                return tabUtilisateur;
            }
            catch
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                if (r != null)
                    r.Close();

                return tabUtilisateur;
            }
        }
    }
}
