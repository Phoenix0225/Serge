using System;
using System.Data;
using System.Windows.Forms;

namespace GestionPret.PN
{
    public partial class Connection : Form
    {
        /// <summary>
        /// Fenetre prinsipale Serge.cs
        /// </summary>
        Serge serge;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Connection()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="_Serge">Classe GuichetAutomatique</param>
        public Connection(Serge _Serge)
        {
            InitializeComponent();
            serge = _Serge;
        }

        /// <summary>
        /// Lorsque l'utilisateur clic sur le X, l'application se ferme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btCnx_Click(object sender, EventArgs e)
        {
            erreur.Visible = false;
            string utilisateur = user.Text;
            string mdpCrypted = "";
            string mdpDecrypted = "";
            string mdp = password.Text;
            DataTable infoUtilisateur;

            if (utilisateur == "")
            {
                erreur.Text = "*Veuillez remplir tous les champs.";
                erreur.Visible = true;

                return;
            }

            if (mdp == "")
            {
                erreur.Text = "*Veuillez remplir tous les champs.";
                erreur.Visible = true;

                return;
            }

            if (BD.DataSysteme.GetInstance().ValiderUtilisateurExiste(utilisateur) == false)
            {
                erreur.Text = "*Les informations de connexion sont incorrectes.";
                erreur.Visible = true;

                return;
            }


            mdpCrypted = BD.DataSysteme.GetInstance().ValiderPasswordUtilisateur(utilisateur);
            mdpDecrypted = BD.Cryptage.Decrypt(mdpCrypted);

            // Valide si le mot de passe est bon
            if (mdpDecrypted == mdp)
            {
                infoUtilisateur = BD.DataSysteme.GetInstance().GetUtilisateur(utilisateur);

                //Serge.Utilisateur = infoUtilisateur.Rows[0][0].ToString();
                Serge.Nom = infoUtilisateur.Rows[0][1].ToString();
                Serge.Prenom = infoUtilisateur.Rows[0][2].ToString();

                // Affiche la fenêtre principale
                serge.Show();

                // Si ou la fenêtre de connection se ferme et la fenêtre principale s'ouvre
                this.Close();
            }
            else
            {
                erreur.Text = "*Les informations de connexion sont incorrectes.";
                erreur.Visible = true;
            }

        }

        /// <summary>
        /// Avant de charger la fenetre de connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Connection_Load(object sender, EventArgs e)
        {
            btCnx.FlatAppearance.BorderSize = 0;
            erreur.Visible = false;
            erreurUser.Visible = false;
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                erreurUser.Text = "*Chiffre seulement";
                erreurUser.Visible = true;
            }
            else
            {
                erreurUser.Visible = false;
            }
        }
    }
}
