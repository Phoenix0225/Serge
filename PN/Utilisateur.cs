using System;
using System.Data;
using System.Windows.Forms;

namespace GestionPret.PN
{
    public partial class Utilisateur : UserControl
    {
        DataTable listUtilisateur;

        public Utilisateur()
        {
            InitializeComponent();
        }

        private void Utilisateur_Load(object sender, EventArgs e)
        {
            erreurUser.Visible = false;
            erreurPrenom.Visible = false;
            erreurNom.Visible = false;
            erreur.Visible = false;

            listUtili.AllowUserToAddRows = false;
            listUtili.ReadOnly = true;
            listUtili.RowHeadersVisible = false;
            listUtili.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            ChargerListUitlisateur();
        }

        /// <summary>
        /// Autorise seulement les chiffres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                erreurUser.Text = "Chiffre seulement";
                erreurUser.Visible = true;
            }
            else
            {
                erreurUser.Visible = false;
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            String user = "";
            String prenom = "";
            String nom = "";
            String mdp1 = "";
            String mdp2 = "";
            String mdpCrypted = "";

            user = tbUser.Text;
            prenom = tbPrenom.Text;
            nom = tbNom.Text;
            mdp1 = tbMdp1.Text;
            mdp2 = tbMdp2.Text;

            if (BD.DataSysteme.GetInstance().ValiderUtilisateurExiste(user) == true)
            {
                erreurUser.Text = "L'ID utiliseur existe déjà veuillez le modifier";
                erreurUser.Visible = true;
                user = "";
                return;
            }

            if (user == "")
            {
                erreur.Text = "Veuillez remplir tous les champs";
                erreur.Visible = true;
                prenom = "";
                return;
            }

            if (prenom == "")
            {
                erreur.Text = "Veuillez remplir tous les champs";
                erreur.Visible = true;
                prenom = "";
                return;
            }

            if (nom == "")
            {
                erreur.Text = "Veuillez remplir tous les champs";
                erreur.Visible = true;
                nom = "";
                return;
            }

            if (mdp1 == "")
            {
                erreur.Text = "Veuillez remplir tous les champs";
                erreur.Visible = true;
                mdp1 = "";
                return;
            }

            if (mdp2 == "")
            {
                erreur.Text = "Veuillez remplir tous les champs";
                erreur.Visible = true;
                mdp2 = "";
                return;
            }

            if (mdp1.Equals(mdp2) == false)
            {
                erreur.Text = "Les mots de passes ne sont pas identique";
                erreur.Visible = true;
                mdp2 = "";
                mdp1 = "";
                return;
            }

            if (mdp2.Length < 6)
            {
                erreur.Text = "Mot de passe trop court 6 char min.";
                erreur.Visible = true;
                mdp2 = "";
                mdp1 = "";
                return;
            }

            if (mdp1.Length < 6)
            {
                erreur.Text = "Mot de passe trop court 6 char min.";
                erreur.Visible = true;
                mdp2 = "";
                mdp1 = "";
                return;
            }

            mdpCrypted = BD.Cryptage.Encrypt(mdp2);

            BD.DataSysteme.GetInstance().AjouterUtilisateur(user, nom, prenom, mdpCrypted);
            ChargerListUitlisateur();
            tbUser.Text = "";
            tbPrenom.Text = "";
            tbNom.Text = "";
            tbMdp1.Text = "";
            tbMdp2.Text = "";
        }

        /// <summary>
        /// Empêcher le premier caractère d'être un espace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbPrenom_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text.StartsWith(" "))
            {
                tbPrenom.Text = "";
            }
        }


        /// <summary>
        /// Empêcher le premier caractère d'être un espace
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNom_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text.StartsWith(" "))
            {
                tbNom.Text = "";
            }
        }

        private void tbUser_Enter(object sender, EventArgs e)
        {
            erreurUser.Visible = false;
            erreur.Visible = false;
        }

        private void tbPrenom_Enter(object sender, EventArgs e)
        {
            erreurPrenom.Visible = false;
            erreur.Visible = false;
        }

        private void tbNom_Enter(object sender, EventArgs e)
        {
            erreurNom.Visible = false;
            erreur.Visible = false;
        }

        private void tbMdp_Enter(object sender, EventArgs e)
        {
            erreur.Visible = false;
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            tbUser.Text = "";
            tbPrenom.Text = "";
            tbNom.Text = "";
            tbMdp1.Text = "";
            tbMdp2.Text = "";
        }

        private void ChargerListUitlisateur()
        {
            listUtilisateur = BD.DataSysteme.GetInstance().GetListUtilisateur();

            if (listUtilisateur != null)
            {
                if (listUtilisateur.Rows.Count > 0) // Valide si la tab est plus grand que 0 afin de ne pas avoir d'erreur
                {
                    listUtili.Rows.Clear(); // Vide le contenu du listUtili

                    for (int i = 0; i < listUtilisateur.Rows.Count; i++)
                    {
                        listUtili.Rows.Add();

                        listUtili.Rows[i].Cells[0].Value = listUtilisateur.Rows[i][0].ToString();
                        listUtili.Rows[i].Cells[1].Value = listUtilisateur.Rows[i][1].ToString();
                        listUtili.Rows[i].Cells[2].Value = listUtilisateur.Rows[i][2].ToString();
                    }
                }
            }
        }

        private void tbMdp1_Enter(object sender, EventArgs e)
        {
            erreur.Visible = false;
        }
    }
}
