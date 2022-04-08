using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GestionPret.PN
{
    public partial class AddModRetour : UserControl
    {
        Locations ucLocation;

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        public AddModRetour()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        public AddModRetour(Locations _UcLocation)
        {
            InitializeComponent();

            ucLocation = _UcLocation;
        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur enregistrer, on fait les validations et on envoie 
        /// à la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEnregistrer_Click(object sender, EventArgs e)
        {

            if (tbCodeClient.Text.Equals("")) // Valide que le code du client a bien été saisi
            {
                MessageBox.Show("Veuillez sélectionner le matricule du client.", "Serge | Retour de location - ERREUR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvEquipementsRetour.Rows.Count == 0) // Valide qu'il y a des items en location présentement
            {
                MessageBox.Show("Il n'y a aucun équipement à reprendre.", "Serge | Retour de location - ERREUR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (BD.DataLocations.GetInstance().AjouterRetour(tbCodeClient.Text, dtpDateDebut.Value)) // Crée un novueau retour
            {
                int dernierRetour = BD.DataLocations.GetInstance().GetDernierRetour(); // Obtient le ID du retour qui vient d'être fait

                for (int i = 0; i < dgvEquipementsRetour.Rows.Count; i++) // Valide chaque ligne du DataGrid
                {
                    String equipement = dgvEquipementsRetour.Rows[i].Cells[0].Value.ToString(); // ID de l'équipement
                    int noLocation = Convert.ToInt32(dgvEquipementsRetour.Rows[i].Cells[7].Value.ToString()); // Id de la location
                    int etat = Convert.ToInt32(dgvEquipementsRetour.Rows[i].Cells[2].Value.ToString().Substring(0, 1)); // Convertis l'état du produit

                    Boolean isRetour = Convert.ToBoolean(dgvEquipementsRetour.Rows[i].Cells[5].Value); // Case a cocher indiquant si l'on reprend ou non

                    if (isRetour) // Si la case est coché
                    {
                        if (BD.DataLocations.GetInstance().RetournerEquipement(dernierRetour, noLocation, equipement, etat)) // Ajoute l'item retourne
                        {
                            ucLocation.ChargerLocationsCourrantes();
                            ucLocation.ChargerLocationsRetard();
                            ucLocation.ChargerLocationRetourJournee();
                        }
                        else break;
                    }
                }
            }
            else return;

            Parent.Controls.Remove(this); // Ferme le user control
        }

        /// <summary>
        /// Annule le retour et ferme le panes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAnnuler_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this); // Ferme le user controle
        }

        /// <summary>
        /// Lorsque l'utilisateur quitte la case code client, on affiche les informations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCodeClient_Leave(object sender, EventArgs e)
        {
            DataTable client = null;

            if (!tbCodeClient.Text.Trim().Equals("")) // Valide si l'utilisateur a entré un matricule
                client = BD.DataClients.GetInstance().GetClient(tbCodeClient.Text);
            else
            {
                MessageBox.Show("Veuillez sélectionner le matricule du client.", "Serge | Retour de location - ERREUR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (client.Rows.Count > 0) // Valide si le matricule est existant
            {
                // Affiche l'information du client dans les Txt Box
                tbNom.Text = client.Rows[0][1].ToString();
                tbPrenom.Text = client.Rows[0][2].ToString();
                tbDepartement.Text = client.Rows[0][3].ToString();
                mskTelephone.Text = client.Rows[0][5].ToString();
                tbCourriel.Text = client.Rows[0][4].ToString();

                ChargerEquipementLocation();
            }
            else
            {
                MessageBox.Show("Le client sélectionné est inexistant.", "Serge | Retour de location - ERREUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        /// <summary>
        /// Charge les équipements en cours de location dans le tableau
        /// </summary>
        private void ChargerEquipementLocation()
        {
            DataTable tabEquipementLoue = BD.DataLocations.GetInstance().GetDataEquipementsRetour(tbCodeClient.Text);

            if (tabEquipementLoue.Rows.Count > 0) // Valide si la tab est plus grand que 0 afin de ne pas avoir d'erreur
            {
                dgvEquipementsRetour.Rows.Clear(); // Vide le contenu du dgvProprietaire 

                for (int i = 0; i < tabEquipementLoue.Rows.Count; i++)
                {
                    dgvEquipementsRetour.Rows.Add();

                    dgvEquipementsRetour.Rows[i].Cells[0].Value = tabEquipementLoue.Rows[i][0].ToString();
                    dgvEquipementsRetour.Rows[i].Cells[1].Value = tabEquipementLoue.Rows[i][1].ToString();
                    dgvEquipementsRetour.Rows[i].Cells[2].Value = tabEquipementLoue.Rows[i][2].ToString();
                    dgvEquipementsRetour.Rows[i].Cells[3].Value = tabEquipementLoue.Rows[i][3].ToString();
                    dgvEquipementsRetour.Rows[i].Cells[7].Value = tabEquipementLoue.Rows[i][4].ToString();

                    DateTime dateRetourPrevu = Convert.ToDateTime(tabEquipementLoue.Rows[i][3].ToString());

                    if (dateRetourPrevu < DateTime.Now) // Si l'équipement est en retard, on met la ligne en rose
                    {
                        dgvEquipementsRetour.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                    }
                }
            }
            else
            {
                MessageBox.Show("Il n'y a aucun retour à faire pour ce client", "Serge | Retour de location - ERREUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
