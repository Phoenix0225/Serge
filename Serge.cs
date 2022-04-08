using System;
using System.Windows.Forms;

namespace GestionPret
{
    public partial class Serge : Form
    {
        //*****************Variables pour le déplacement de la fenêtre.*****************
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //*****************Variables pour le déplacement de la fenêtre.*****************

        /// <summary>
        /// Controle utilisateur Clients.cs
        /// </summary>
        PN.Clients ucClients;

        /// <summary>
        /// Controle utilisateur Equiement.cs
        /// </summary>
        PN.Equipements ucEquipements;

        /// <summary>
        /// Controle utilisateur Locations.cs
        /// </summary>
        PN.Locations ucLocations;

        /// <summary>
        /// Controle utilisateur Parametre.cs
        /// </summary>
        PN.Parametres ucParametres;

        /// <summary>
        /// Controle utilisateur Utilisateurs.cs
        /// </summary>
        PN.Utilisateur ucUtilisateurs;

        /// <summary>
        /// Fenetre Connection.cs
        /// </summary>
        PN.Connection fnConnection;

        private static String utilisateur;
        private static String nom;
        private static String prenom;

        //Méthode Get et Set

        public static string Utilisateur { get => utilisateur; set => utilisateur = value; }
        public static string Nom { get => nom; set => nom = value; }
        public static string Prenom { get => prenom; set => prenom = value; }

        /// <summary>
        /// Constructeur par defaut
        /// </summary>
        public Serge()
        {
            InitializeComponent();
            AfficherLocations();
        }

        /// <summary>
        /// Ferme l'application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Permet de déplacer la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void POffset_MouseDown(object sender, MouseEventArgs e)
        {
            DeplacerFenetre(sender, e);
        }

        /// <summary>
        /// Permet de déplacer la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lTitreFenetre_MouseDown(object sender, MouseEventArgs e)
        {
            DeplacerFenetre(sender, e);
        }

        /// <summary>
        /// Méthode pour déplacer la fenêtre à partir du haut de la fenêtre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeplacerFenetre(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// Maximize la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        /// <summary>
        /// Minimize la fenetre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Affiche le controle utilisateur Clients.cs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtClients_Click(object sender, EventArgs e)
        {
            ucClients = new PN.Clients();

            SetTitreFenetre("Clients");

            pMain.Controls.Clear();

            pMain.Controls.Add(ucClients);
            ucClients.Dock = DockStyle.Fill;
            ucClients.BringToFront();
        }

        /// <summary>
        /// Affiche le controle utilisateur Equipements.cs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtEquipements_Click(object sender, EventArgs e)
        {
            ucEquipements = new PN.Equipements();

            SetTitreFenetre("Équipements");

            pMain.Controls.Clear();

            pMain.Controls.Add(ucEquipements);
            ucEquipements.Dock = DockStyle.Fill;
            ucEquipements.BringToFront();
        }

        /// <summary>
        /// Affiche le controle utilisateur Locations.cs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtLocations_Click(object sender, EventArgs e)
        {
            pMain.Controls.Clear();
            AfficherLocations();
        }

        /// <summary>
        /// Permet de modifier le titre de la fenêtre
        /// </summary>
        /// <param name="titre"></param>
        private void SetTitreFenetre(string titre)
        {
            lTitreFenetre.Text = titre;
        }

        /// <summary>
        /// Affiche le controle utilisateur Locations.cs
        /// </summary>
        private void AfficherLocations()
        {
            ucLocations = new PN.Locations();

            SetTitreFenetre("Locations");

            pMain.Controls.Add(ucLocations);
            ucLocations.Dock = DockStyle.Fill;
            ucLocations.BringToFront();
        }

        /// <summary>
        /// Affiche le controle utilisateur Patametres.cs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtParametres_Click(object sender, EventArgs e)
        {
            ucParametres = new PN.Parametres();

            SetTitreFenetre("Paramètres");

            pMain.Controls.Add(ucParametres);
            ucParametres.Dock = DockStyle.Fill;
            ucParametres.BringToFront();
        }

        /// <summary>
        /// Affiche le controle utilisateur Utilisateurs.cs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtUtilisateurs_Click(object sender, EventArgs e)
        {
            ucUtilisateurs = new PN.Utilisateur();

            SetTitreFenetre("Utilisateurs");

            pMain.Controls.Add(ucUtilisateurs);
            ucUtilisateurs.Dock = DockStyle.Fill;
            ucUtilisateurs.BringToFront();

        }

        /// <summary>
        /// Lorsque la fenetre se charge, on affiche la connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Serge_Load(object sender, EventArgs e)
        {
            fnConnection = new PN.Connection(this);
            fnConnection.ShowDialog();
        }

        /// <summary>
        /// Déconnecte l'utilisateur et oure une nouelle fenetre de connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Deconnexion_Click(object sender, EventArgs e)
        {
            // Cache la fenêtre principale
            this.Hide();

            // Ouvre une nouvelle fenêtre de connection
            fnConnection = new PN.Connection(this);
            fnConnection.ShowDialog();
        }
    }
}
