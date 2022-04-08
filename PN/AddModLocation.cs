using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace GestionPret.PN
{
    public partial class AddModLocation : UserControl
    {
        /// <summary>
        /// Controle utilisateur Location.cs
        /// </summary>
        Locations ucLocations;

        /// <summary>
        /// Si vrai on ajout
        /// Si faut on modifie
        /// </summary>
        Boolean option;

        /// <summary>
        /// Id de la location
        /// </summary>
        int noLocation;

        /// <summary>
        /// Constrtucteur par défaut
        /// </summary>
        public AddModLocation()
        {
            InitializeComponent();

            dtpDateDebut.MinDate = DateTime.Now;
        }

        /// <summary>
        /// Constructeur paramétré
        /// utilisé pour l'ajout de nouvellle locations
        /// </summary>
        /// <param name="_UcLocations">Controle utilisateur Location.cs</param>
        public AddModLocation(Locations _UcLocations)
        {
            InitializeComponent();

            dgvEquipementsLocations.Columns[7].Visible = false;

            dtpDateDebut.MinDate = DateTime.Now;
            ucLocations = _UcLocations;
            option = true;
        }

        /// <summary>
        /// Constructeur paramétré utilisé pour la modification et consultation
        /// des locations 
        /// </summary>
        /// <param name="_UcLocations">Controle utilisateur Location.cs</param>
        /// <param name="_IdLocation">Id Locations.cs</param>
        public AddModLocation(Locations _UcLocations, int _IdLocation)
        {
            InitializeComponent();

            ucLocations = _UcLocations;
            noLocation = _IdLocation;

            tbCodeLocation.Text = noLocation.ToString();
            dgvEquipementsLocations.Columns[7].Visible = true;

            ChargerInfoClient();
            ChargerDgvEquipementsLocation();
            tbCodeClient.Enabled = false;
            pbAddRow.Visible = false;
            pbEnleverLigne.Visible = false;

            dgvEquipementsLocations.Enabled = false;
            btEnregistrer.Visible = false;

            option = false;
        }

        /// <summary>
        ///  Lorsque l'utilisateur clique sur le bouton annuler, 
        ///  on ferme le controle utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAnnuler_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur le bouton enregistrer, on valide si les informations
        /// ont été entrées correctement et on enregistre dans la vase de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtEnregistrer_Click(object sender, EventArgs e)
        {
            if (tbCodeClient.Text.Equals("")) // Valide que le code du client a bien été saisi
            {
                MessageBox.Show("Veuillez sélectionner le matricule du client.", "Serge | Nouvelle location - ERREUR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgvEquipementsLocations.Rows.Count == 0) // Valide que l'utilisateur a entré des équipements a louer
            {
                MessageBox.Show("Il n'y a aucun équipement à louer", "Serge | Nouvelle location - ERREUR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si vrai, on ajoute
            // si faux on modifie
            if (option)
            {
                if (BD.DataLocations.GetInstance().AjouterLocation(tbCodeClient.Text, dtpDateDebut.Value)) // Ajoute la location
                {
                    int nouvEnregistrement = BD.DataLocations.GetInstance().GetDerniereLocation(); // récupère le code de la locations

                    for (int i = 0; i < dgvEquipementsLocations.Rows.Count; i++) // Valide et ajoute chacun des produis a la location
                    {

                        if (dgvEquipementsLocations.Rows[i].Cells[0].Value != null) // S'il n'y a pas de code de produit on supprime la ligne
                        {
                            String produit = dgvEquipementsLocations.Rows[i].Cells[0].Value.ToString(); // Met le numéro de produit dans une variable
                            int etat = Convert.ToInt32(dgvEquipementsLocations.Rows[i].Cells[2].Value.ToString().Substring(0, 1)); // Convertis l'état du produit

                            DateTime dateRetour;

                            if (dgvEquipementsLocations.Rows[i].Cells[3].Value.ToString().Equals("")) // Valide qu'il y a une date de retour au produit
                            {
                                MessageBox.Show("Veuillez entrer une date de retour à la ligne numéro " + 
                                                (i + 1) + ".", "Serge | Nouvelle location - ERREUR",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                BD.DataLocations.GetInstance().SupprimerProduitErreur(nouvEnregistrement);
                                return;
                            }

                            if (DateTime.TryParse(dgvEquipementsLocations.Rows[i].Cells[3].Value.ToString(), out dateRetour)) // Valide le format de la date de retour
                            {
                                dateRetour = Convert.ToDateTime(dgvEquipementsLocations.Rows[i].Cells[3].Value.ToString()); // Convertis la la date de retour en DataTime
                            }
                            else
                            {
                                BD.DataLocations.GetInstance().SupprimerProduitErreur(nouvEnregistrement);
                                return;
                            }
                            if (dateRetour < DateTime.Today) // Valide que la date de retour n'est pas plus petite que la date du jour
                            {
                                MessageBox.Show("La date de retour prévue ne peut pas être plus petite que la date du jour", 
                                                "Serge | Nouvelle location - ERREUR",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                BD.DataLocations.GetInstance().SupprimerProduitErreur(nouvEnregistrement);
                                return;
                            }

                            // Ajoute la ligne a la location
                            if (BD.DataLocations.GetInstance().AjouterProduitLocation(nouvEnregistrement, produit, dateRetour, etat))
                            {
                            }
                            else
                            {
                                BD.DataLocations.GetInstance().SupprimerProduitErreur(nouvEnregistrement);
                                return;
                            }
                        }
                    }
                }
                else return;

                ucLocations.ChargerLocationsCourrantes(); // Met à jour le tableau des locations
                this.Parent.Controls.Remove(this); // Ferme le controle utilisateur
            }
        }

        /// <summary>
        /// Pas encore fonctionnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtReprendre_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Charge les equipements loues
        /// </summary>
        private void ChargerDgvEquipementsLocation()
        {
            DataTable tabLocationEquipement = BD.DataLocations.GetInstance().GetDataEquipementsLocation(noLocation);

            if (tabLocationEquipement.Rows.Count > 0) // Valide si la tab est plus grand que 0 afin de ne pas avoir d'erreur
            {
                dgvEquipementsLocations.Rows.Clear(); // Vide le contenu du dgvProprietaire

                for (int i = 0; i < tabLocationEquipement.Rows.Count; i++)
                {
                    dgvEquipementsLocations.Rows.Add();

                    dgvEquipementsLocations.Rows[i].Cells[0].Value = tabLocationEquipement.Rows[i][1].ToString();
                    dgvEquipementsLocations.Rows[i].Cells[1].Value = tabLocationEquipement.Rows[i][2].ToString();
                    dgvEquipementsLocations.Rows[i].Cells[2].Value = tabLocationEquipement.Rows[i][3].ToString();
                    dgvEquipementsLocations.Rows[i].Cells[3].Value = tabLocationEquipement.Rows[i][4].ToString();
                    dgvEquipementsLocations.Rows[i].Cells[4].Value = tabLocationEquipement.Rows[i][5].ToString();
                    dgvEquipementsLocations.Rows[i].Cells[6].Value = tabLocationEquipement.Rows[i][6].ToString();
                    dgvEquipementsLocations.Rows[i].Cells[7].Value = tabLocationEquipement.Rows[i][7].ToString();
                    dgvEquipementsLocations.Rows[i].Cells[8].Value = tabLocationEquipement.Rows[i][8].ToString();
                }
            }
        }

        /// <summary>
        /// Lorsque l'utilisateur quitte la case matricule, on affiche les informations
        /// du client dans les textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbCodeClient_Leave(object sender, EventArgs e)
        {
            DataTable client = null;

            if (!tbCodeClient.Text.Trim().Equals("")) // Valide si l'utilisateur a entré un matricule
                client = BD.DataClients.GetInstance().GetClient(tbCodeClient.Text);
            else
            {
                MessageBox.Show("Veuillez sélectionner le matricule du client.", "Serge | Nouvelle location - ERREUR",
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
            }
            else
            {
                MessageBox.Show("Le client sélectionné est inexistant.", "Serge | Nouvelle location - ERREUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        /// <summary>
        /// Obsolete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvEquipementsLocations_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        /// Obsolete
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvEquipementsLocations_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur le +, on ajoute un ligne au tableau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbAddRow_Click(object sender, EventArgs e)
        {
            DataTable tabEquipementDisponibles = BD.DataProduits.GetInstance().GetEquipements(1); // Obtient la liste des équipements disponibles

            if (tabEquipementDisponibles.Rows.Count > 0) // Valide s'il reste des équipements disponibles
            {
                dgvEquipementsLocations.Rows.Add();

                int ligneAjoute = dgvEquipementsLocations.Rows.Count - 1;

                dgvEquipementsLocations.Rows[ligneAjoute].Cells[3].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                dgvEquipementsLocations.Rows[ligneAjoute].Cells[2].Value = "2 - En bon état";
            }
            else
            {
                MessageBox.Show("Il ne reste plus d'équipement disponible.", "Serge | Nouvelle location - ERREUR",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        /// <summary>
        /// Lorsque l'utilisateur entre ou modifie le code d'un équipement, on met a jout l'information de la row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvEquipementsLocations_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            String code = "";
            Boolean disponible = false;

            DataTable tabEquipementDisponibles = BD.DataProduits.GetInstance().GetEquipements(1); // Obtient la liste des équipements disponibles

            if (dgvEquipementsLocations.Rows.Count > 0) // Valide que l'utilisateur a bien ajouté une ligne
            {
                dgvEquipementsLocations.UpdateCellValue(0, e.RowIndex); // Entre correctement la valeur dans la cellule
                dgvEquipementsLocations.UpdateCellValue(3, e.RowIndex);

                //************************** AJOUTER UNE VALIDATION *****************************//

                if (dgvEquipementsLocations.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    code = Convert.ToString(dgvEquipementsLocations.Rows[e.RowIndex].Cells[0].Value.ToString()); // Convertis le code du produoit en string

                    if (e.ColumnIndex == 0) // Validation pour le code d'équipement
                    {
                        if (BD.DataProduits.GetInstance().GetEquipement(code).Rows.Count == 0) // Valide si le produit est existant
                        {
                            MessageBox.Show("Le produit entré est invalide.", "Serge | Nouvelle location - ERREUR",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (tabEquipementDisponibles.Rows.Count > 0) // Valide si le produit est disponible
                        {
                            for (int i = 0; i < tabEquipementDisponibles.Rows.Count; i++)
                            {
                                if (tabEquipementDisponibles.Rows[i][0].ToString().Equals(code))
                                {
                                    disponible = true;
                                    break;
                                }
                            }
                        }
                        if (disponible) // Si disponible ajout les informations a la ligne
                        {
                            Boolean dejaEntre = false;

                            for(int i = 0; i < dgvEquipementsLocations.Rows.Count; i++)
                            {
                                if(i != dgvEquipementsLocations.Rows[e.RowIndex].Index &&
                                    dgvEquipementsLocations.Rows[i].Cells[0].Value.ToString().Equals
                                    (dgvEquipementsLocations.Rows[e.RowIndex].Cells[0].Value.ToString()))
                                {
                                    dejaEntre = true;
                                }
                            }

                            if (!dejaEntre)
                            {
                                dgvEquipementsLocations.Rows[e.RowIndex].Cells[1].Value = BD.DataProduits.GetInstance().GetEquipement(code).Rows[0][1].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Vous ne pouvez pas entrez deux fois le même produit.", "Serge | Nouvelle location - ERREUR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dgvEquipementsLocations.Rows.RemoveAt(dgvEquipementsLocations.CurrentRow.Index);
                                return;
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Le produit entré est déjà loué.", "Serge | Nouvelle location - ERREUR",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dgvEquipementsLocations.Rows.RemoveAt(dgvEquipementsLocations.CurrentRow.Index);
                            return;
                        }


                    }
                    if (e.ColumnIndex == 3) // Validation de la date de retour prevu
                    {
                        if (!dgvEquipementsLocations.Rows[e.RowIndex].Cells[3].Value.ToString().Equals(""))
                        {
                            DateTime dateRetourPrevu;
                            String dateString = dgvEquipementsLocations.Rows[e.RowIndex].Cells[3].Value.ToString();

                            if (DateTime.TryParseExact(dateString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, 
                                DateTimeStyles.None, out dateRetourPrevu))
                            {
                                dateRetourPrevu = DateTime.ParseExact(dateString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                            }
                            //if (DateTime.TryParse(dgvEquipementsLocations.Rows[e.RowIndex].Cells[3].Value.ToString(), out dateRetourPrevu)) // Valide le format de la date de retour
                            //{
                            //    dateRetourPrevu = Convert.ToDateTime(dgvEquipementsLocations.Rows[e.RowIndex].Cells[3].Value.ToString()); // Convertis la la date de retour en DataTime
                            //}
                            else
                            {
                                dgvEquipementsLocations.Rows[e.RowIndex].Cells[3].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                                MessageBox.Show("Le format de la date entrée est invalide.",
                                    "Serge | Nouvelle location - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            if (ValiderJourRetour(dateRetourPrevu))
                            {
                                if (!ValiderPeriodeRetour(dateRetourPrevu))
                                {
                                    dgvEquipementsLocations.Rows[e.RowIndex].Cells[3].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                                    MessageBox.Show("La plage horaire sélectionné n'est pas disponible.",
                                        "Serge | Nouvelle location - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                            else
                            {
                                dgvEquipementsLocations.Rows[e.RowIndex].Cells[3].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                                MessageBox.Show("Il n'y a pas de plage de disponible pour cette journee.",
                                    "Serge | Nouvelle location - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                        }
                    }
                }
            }
        }

        /// <summary>
        /// Permet de charger les informations du client
        /// </summary>
        private void ChargerInfoClient()
        {
            String idClient = BD.DataLocations.GetInstance().GetClientLocation(noLocation);

            tbCodeClient.Text = idClient;

            DataTable client = BD.DataClients.GetInstance().GetClient(idClient);

            tbNom.Text = client.Rows[0][1].ToString();
            tbPrenom.Text = client.Rows[0][2].ToString();
            tbDepartement.Text = client.Rows[0][3].ToString();
            mskTelephone.Text = client.Rows[0][5].ToString();
            tbCourriel.Text = client.Rows[0][4].ToString();
        }

        /// <summary>
        /// Valide si la journee du retour prevu est disponible pour un retour
        /// </summary>
        /// <param name="_DateRetourPrevu"></param>
        /// <returns></returns>
        private Boolean ValiderJourRetour(DateTime _DateRetourPrevu)
        {
            String journee = "";

            switch (Convert.ToInt32(_DateRetourPrevu.DayOfWeek))
            {
                case 0: journee = "Dimanche"; break;
                case 1: journee = "Lundi"; break;
                case 2: journee = "Mardi"; break;
                case 3: journee = "Mercredi"; break;
                case 4: journee = "Jeudi"; break;
                case 5: journee = "Vendredi"; break;
                case 6: journee = "Samedi"; break;
            }

            return BD.DataLocations.GetInstance().ValiderJourneeDisponible(journee);
        }

        /// <summary>
        /// Valide s'il y a de la disponibilité pour la periode de retour prevu
        /// </summary>
        /// <param name="_DateRetourPrevu">Date de retour prevu</param>
        /// <returns></returns>
        private Boolean ValiderPeriodeRetour(DateTime _DateRetourPrevu)
        {
            String moment = _DateRetourPrevu.Hour.ToString() + ":" + _DateRetourPrevu.Minute.ToString();

            String journee = "";

            switch (Convert.ToInt32(_DateRetourPrevu.DayOfWeek))
            {
                case 0: journee = "Dimanche"; break;
                case 1: journee = "Lundi"; break;
                case 2: journee = "Mardi"; break;
                case 3: journee = "Mercredi"; break;
                case 4: journee = "Jeudi"; break;
                case 5: journee = "Vendredi"; break;
                case 6: journee = "Samedi"; break;
            }

            return BD.DataLocations.GetInstance().ValiderPeriodeDisponible(journee, moment);
        }

        /// <summary>
        /// Permet de retirer un ligne dans le DGV
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbEnleverLigne_Click(object sender, EventArgs e)
        {
            if(dgvEquipementsLocations.Rows.Count > 0)
            {
                dgvEquipementsLocations.Rows.RemoveAt(dgvEquipementsLocations.CurrentRow.Index);
            }
        }
    }
}
