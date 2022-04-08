using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GestionPret.BD
{
    class DataProduits
    {
        /// <summary>
        /// Variable de qui contient les information pour la connexion au serveur
        /// </summary>
        private MySqlConnection con;

        /// <summary>
        /// Variable statique qui permet de rendre la classe static
        /// </summary>
        private static DataProduits instance = null;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public DataProduits()
        {
            this.con = new MySqlConnection("Server=localhost;Database=serge;Uid=root;Pwd=;port=3306; charset=utf8;");
        }

        /// <summary>
        /// Méthode qui rend la classe static (Singleton)
        /// </summary>
        /// <returns>Data_Produit</returns>
        public static DataProduits GetInstance()
        {
            if (instance == null)
            {
                instance = new DataProduits();
            }
            return instance;
        }

        /// <summary>
        /// Retourne les informations d'un équipement
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>DataTable d'un équipement</returns>
        public DataTable GetEquipement(string numero)
        {
            DataTable tabEquipement = null;
            MySqlDataReader r = null;

            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;
                commande.CommandText = "SELECT * " +
                                       "FROM equipements " +
                                       "WHERE id_equipement = @numero; ";

                commande.Parameters.Add("@numero", MySqlDbType.String).Value = numero;

                con.Open();
                commande.Prepare();
                r = commande.ExecuteReader();

                tabEquipement = new DataTable("equipement");
                tabEquipement.Load(r);

                return tabEquipement;
            }
            catch
            {
                return tabEquipement;
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
        /// Retourne les catégories d'équipement
        /// </summary>
        /// <returns>List<String> des catégories</returns>
        public List<String> GetCategoriesEquipement()
        {
            MySqlDataReader r = null;

            List<String> listCategories = new List<String>();

            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;
                commande.CommandText = "SELECT * " +
                                       "FROM categories_equipements;";

                con.Open();
                r = commande.ExecuteReader();

                while (r.Read())
                {
                    listCategories.Add(r[0].ToString() + " - " + r[1].ToString());
                }

                return listCategories;
            }
            catch
            {
                return listCategories;
            }
            finally
            {
                if (r != null)
                    r.Close();

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// Permet d'ajouter un équipement
        /// </summary>
        /// <param name="numero">ID de l'équipement</param>
        /// <param name="numeroSerie">Numéro de série de l'équipement</param>
        /// <param name="categorie">ID de la catégorie de l'équipement</param>
        /// <param name="description">Description de l'équipement</param>
        /// <param name="condition">Condition de l'équipement</param>
        /// <param name="statut">Statut de l'équipement</param>
        /// <returns>Vrai si l'ajout est réussi, faux si erreur</returns>
        public Boolean AjouterEquipement(String numero, String numeroSerie, int categorie, String description, int condition, int statut)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                commande.CommandText = "INSERT INTO equipements " +
                                       "VALUES(@numero, @description, @numeroSerie, @categorie, @condition, @statut); ";

                commande.Parameters.Add("@numero", MySqlDbType.String).Value = numero;
                commande.Parameters.Add("@description", MySqlDbType.String).Value = description;
                commande.Parameters.Add("@numeroSerie", MySqlDbType.String).Value = numeroSerie;
                commande.Parameters.Add("@categorie", MySqlDbType.Int32).Value = categorie;
                commande.Parameters.Add("@condition", MySqlDbType.Int32).Value = condition;
                commande.Parameters.Add("@statut", MySqlDbType.Int32).Value = statut;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Serge | Ajout d'un equipement - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// Permet de mofifier un équipement
        /// </summary>
        /// <param name="numero">ID de l'équipement</param>
        /// <param name="categorie">ID de la catégorie de l'équipement</param>
        /// <param name="description">Description de l'équipement</param>
        /// <param name="condition">Condition de l'équipement</param>
        /// <param name="statut">Statut de l'équipement</param>
        /// <returns>Vrai si la modification est réussi, faux si erreur</returns>
        public Boolean ModifierEquipement(String numero, int categorie, String description, int condition, int statut)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                commande.CommandText = "UPDATE equipements " +
                                       "SET categorie_id = @categorie, description_equipement = @description, " +
                                       "`condition` = @condition, statut = @statut " +
                                       "WHERE id_equipement = @numero; ";

                commande.Parameters.Add("@numero", MySqlDbType.String).Value = numero;
                commande.Parameters.Add("@description", MySqlDbType.String).Value = description;
                commande.Parameters.Add("@categorie", MySqlDbType.Int32).Value = categorie;
                commande.Parameters.Add("@condition", MySqlDbType.Int32).Value = condition;
                commande.Parameters.Add("@statut", MySqlDbType.Int32).Value = statut;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Serge | Modification d'un equipement - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// Retourne les équipements selon le filtre
        /// </summary>
        /// <param name="typeEquipements">Le filtre des équipements</param>
        /// <returns>DataTable des équipements</returns>
        public DataTable GetEquipements(int typeEquipements)
        {
            MySqlDataReader r = null;

            DataTable tableEquipements = new DataTable("equipements");

            try
            {
                MySqlCommand commande = new MySqlCommand();
                commande.Connection = con;

                if (typeEquipements == 0)
                {
                    commande.CommandText = "SELECT * " +
                                           "FROM vw_equipements;";
                }
                else if (typeEquipements == 1)
                {
                    commande.CommandText = "SELECT * " +
                                           "FROM vw_equipements_disponibles;";
                }
                else if (typeEquipements == 2)
                {
                    commande.CommandText = "SELECT * " +
                                           "FROM vw_equipements_empruntes;";
                }

                con.Open();
                r = commande.ExecuteReader();

                tableEquipements.Load(r);

                return tableEquipements;
            }
            catch
            {
                return tableEquipements;
            }
            finally
            {
                if (r != null)
                    r.Close();

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// Vérifie si l'équipement existe déjà dans la BD selon son numéro
        /// </summary>
        /// <param name="numero">Numéro d'équipement</param>
        /// <returns>Vrai si l'équipement n'existe pas, faux si existe</returns>
        public bool VerifEquipementExiste(string numero)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                commande.CommandText = "SELECT count(*) " +
                                        "FROM equipements " +
                                        "WHERE id_equipement = @numero;";

                commande.Parameters.AddWithValue("@numero", numero);

                con.Open();
                commande.Prepare();
                var result = commande.ExecuteScalar();

                if (result.ToString().Equals("0"))
                    return true;
                else
                    return false;
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
        /// Vérifie si l'équipement existe déjà dans la BD selon son numéro de série
        /// </summary>
        /// <param name="numeroSerie">Numéro de série de l'équipement</param>
        /// <returns>Vrai si l'équipement n'existe pas, faux si existe</returns>
        public bool VerifEquipementDejaDansBD(string numeroSerie)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                commande.CommandText = "SELECT count(*) " +
                                        "FROM equipements " +
                                        "WHERE no_serie_equipement = @numeroSerie;";

                commande.Parameters.AddWithValue("@numeroSerie", numeroSerie);

                con.Open();
                commande.Prepare();
                var result = commande.ExecuteScalar();

                if (result.ToString().Equals("0"))
                    return true;
                else
                    return false;
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
        /// Retourne les statuts d'équipements
        /// </summary>
        /// <returns>List<String> des status d'équipements</returns>
        public List<String> GetListStatutsEquipement()
        {
            MySqlDataReader r = null;

            List<String> listCategories = new List<String>();

            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;
                commande.CommandText = "SELECT * " +
                                       "FROM statut_equipement;";

                con.Open();
                r = commande.ExecuteReader();

                while (r.Read())
                {
                    listCategories.Add(r[0].ToString() + " - " + r[1].ToString());
                }

                return listCategories;
            }
            catch
            {
                return listCategories;
            }
            finally
            {
                if (r != null)
                    r.Close();

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// Vérifie si la catégorie existe déjà selon son numéro de catégorie
        /// </summary>
        /// <param name="numero">Numéro de catégorie</param>
        /// <returns>Vrai si la catégorie n'existe pas, faux si existe</returns>
        public bool VerifCategorieExiste(string numero)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                commande.CommandText = "SELECT count(*) " +
                                        "FROM categories_equipements " +
                                        "WHERE id_categorie = @numero;";

                commande.Parameters.AddWithValue("@numero", numero);

                con.Open();
                commande.Prepare();
                var result = commande.ExecuteScalar();

                if (result.ToString().Equals("0"))
                    return true;
                else
                    return false;
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
        /// Ajoute une catégorie
        /// </summary>
        /// <param name="numero">Numéro de catégorie</param>
        /// <param name="description">Description de la catégorie</param>
        /// <returns>Vrai si succès, faux si échec</returns>
        public Boolean AjouterCategorie(int numero, String description)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                commande.CommandText = "INSERT INTO categories_equipements " +
                                       "VALUES(@numero, @description); ";

                commande.Parameters.Add("@numero", MySqlDbType.Int32).Value = numero;
                commande.Parameters.Add("@description", MySqlDbType.String).Value = description;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Serge | Ajout d'une catégorie - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// Modifie une catégorie
        /// </summary>
        /// <param name="oldNumero">Ancient numéro de la catégorie</param>
        /// <param name="newNumero">Nouveau numéro de la catégorie</param>
        /// <param name="description">Description de la catégorie</param>
        /// <returns>Vrai si succès, faux si échec</returns>
        public Boolean ModifierCategorie(int oldNumero, int newNumero, String description)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                commande.CommandText = "UPDATE categories_equipements " +
                                       "SET id_categorie = @newNumero, description = @description " +
                                       "WHERE id_categorie = @oldNumero; ";

                commande.Parameters.Add("@oldNumero", MySqlDbType.Int32).Value = oldNumero;
                commande.Parameters.Add("@description", MySqlDbType.String).Value = description;
                commande.Parameters.Add("@newNumero", MySqlDbType.Int32).Value = newNumero;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();

                commande.Parameters.Clear();

                commande.CommandText = "UPDATE equipements " +
                                       "SET categorie_id = @newNumero " +
                                       "WHERE categorie_id = @oldNumero; ";

                commande.Parameters.Add("@oldNumero", MySqlDbType.Int32).Value = oldNumero;
                commande.Parameters.Add("@newNumero", MySqlDbType.Int32).Value = newNumero;

                commande.Prepare();
                commande.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Serge | Modification d'une catégorie - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// Vérifie si il y a des équipements dans une certaine catégorie
        /// </summary>
        /// <param name="numero">Numéro de la catégorie</param>
        /// <returns>Vrai il y a des équipements dans la catégorie, faux si il y en a pas</returns>
        public bool VerifEquipementDansCategorie(int numero)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;

                commande.CommandText = "SELECT count(*) " +
                                        "FROM equipements " +
                                        "WHERE categorie_id = @numero;";

                commande.Parameters.AddWithValue("@numero", numero);

                con.Open();
                commande.Prepare();
                var result = commande.ExecuteScalar();

                if (result.ToString().Equals("0"))
                    return false;
                else
                    return true;
            }
            catch
            {
                return true;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        /// <summary>
        /// Supprime la catégorie
        /// </summary>
        /// <param name="noCategorie">Numéro de la catégorie</param>
        /// <returns>Vrai si succès, faux si échec</returns>
        public bool SupprimerCategorie(int noCategorie)
        {
            try
            {
                MySqlCommand commande = new MySqlCommand();

                commande.Connection = con;
                commande.CommandText = "UPDATE equipements " +
                                        "SET categorie_id = 101 " +
                                        "WHERE categorie_id = @noCategorie;";

                commande.Parameters.Add("@noCategorie", MySqlDbType.Int32).Value = noCategorie;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();
                con.Close();

                commande.Connection = con;
                commande.CommandText = $"DELETE FROM categories_equipements WHERE id_categorie = @noCategorie;";

                commande.Parameters.Clear();
                commande.Parameters.Add("@noCategorie", MySqlDbType.Int32).Value = noCategorie;

                con.Open();
                commande.Prepare();
                commande.ExecuteNonQuery();
                con.Close();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Serge | Suppression d'une catégorie - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
    }
}