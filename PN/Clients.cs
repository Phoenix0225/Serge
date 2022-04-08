using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GestionPret.PN
{
    public partial class Clients : UserControl
    {
        /// <summary>
        /// Si vrai = Ajout a la BD
        /// Si faux = Modification a la BD
        /// </summary>
        private Boolean operation;

        /// <summary>
        /// Valide si l'utilisateur est en train de modifier des trucs
        /// </summary>
        private Boolean edition;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Clients()
        {
            InitializeComponent();

            ChargerCbTypeClient();

            ModeConsultation();

            edition = false;
            operation = false;
        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur le bouton visualiser, on affiche les informations
        /// u client qui a été saisi dans la case matricule
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtVisualiser_Click(object sender, EventArgs e)
        {
            AfficherClient();
        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur le bouton Nouveau,
        /// on vhange la visibilité des boutons et on lui permet de modifier les text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtNouveau_Click(object sender, EventArgs e)
        {
            Clear();
            ModeEdition();
            edition = true;
            operation = true;
        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur le bouton annuler, on retourne en mode de consultation et on vide les text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtAnnuler_Click(object sender, EventArgs e)
        {
            ModeConsultation();
            Clear();
        }

        /// <summary>
        /// Lorsque l'utilisateur clique sur enregistrer, on envoie les informations à la base de données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtEnregistrer_Click(object sender, EventArgs e)
        {
            // Mise en forme du telephone pour la base de données
            String telephone = mskTelephone.Text.Replace(" ", "");
            telephone = telephone.Replace("(", "");
            telephone = telephone.Replace(")", "");
            telephone = telephone.Replace("-", "");

            // Converti le type du client en integer
            int type = Convert.ToInt32(cbTypesClients.SelectedItem.ToString().Substring(0, 1));

            MettreCouleurTxtBxNormal();

            // Valide si tout les champs ont été complété
            // Les champs non complétés sont changé de couleur
            if (tbCodeClient.Text.Trim().Equals("") || tbNom.Text.Trim().Equals("") || tbPrenom.Text.Trim().Equals("") ||
                tbDepartement.Text.Trim().Equals("") || tbCourriel.Text.Trim().Equals("") || telephone.Equals(""))
            {
                if (tbCodeClient.Text.Trim().Equals(""))
                    tbCodeClient.BackColor = Color.Pink;
                if (tbNom.Text.Trim().Equals(""))
                    tbNom.BackColor = Color.Pink;
                if (tbPrenom.Text.Trim().Equals(""))
                    tbPrenom.BackColor = Color.Pink;
                if (tbDepartement.Text.Trim().Equals(""))
                    tbDepartement.BackColor = Color.Pink;
                if (tbCourriel.Text.Trim().Equals(""))
                    tbCourriel.BackColor = Color.Pink;
                if (telephone.Equals(""))
                    mskTelephone.BackColor = Color.Pink;

                MessageBox.Show("Vous devez compléter tous les champs.", "Serge | Gestion des clients - ERREUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (operation)  // Ajout de client
            {
                if (BD.DataClients.GetInstance().AjouterClient(tbCodeClient.Text, tbNom.Text,
                                        tbPrenom.Text, type, tbDepartement.Text, telephone, tbCourriel.Text))
                {
                    ModeConsultation();
                    edition = false;
                }
                else return;
            }
            else  // Modification d'un client
            {
                if (BD.DataClients.GetInstance().ModifierClient(tbCodeClient.Text, tbNom.Text, tbPrenom.Text,
                                        type, tbDepartement.Text, telephone, tbCourriel.Text, tbMatrSel.Text))
                {
                    ModeConsultation();
                    edition = false;
                }
                else return;
            }

            MettreCouleurTxtBxNormal();
        }

        /// <summary>
        /// Remet la couleur des text box normal
        /// </summary>
        private void MettreCouleurTxtBxNormal()
        {
            tbCodeClient.BackColor = Color.Azure;
            tbNom.BackColor = Color.Azure;
            tbPrenom.BackColor = Color.Azure;
            tbDepartement.BackColor = Color.Azure;
            tbCourriel.BackColor = Color.Azure;
            mskTelephone.BackColor = Color.Azure;
        }

        /// <summary>
        /// Métode qui charge le combo box contenant les types de clients
        /// </summary>
        private void ChargerCbTypeClient()
        {
            List<String> listTypesClients = BD.DataClients.GetInstance().GetTypesClients();

            if (listTypesClients.Count > 0)
            {
                foreach (String s in listTypesClients)
                {
                    cbTypesClients.Items.Add(s);
                }

                cbTypesClients.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Mode qui permet d'afficher le bouton Annuler et enregistrer et qui libère les text box
        /// </summary>
        private void ModeEdition()
        {
            btAnnuler.Visible = true;
            btEnregistrer.Visible = true;
            btNouveau.Visible = false;
            btVisualiser.Visible = false;

            tbMatrSel.Enabled = false;
            cbTypesClients.Enabled = true;
            tbCodeClient.Enabled = true;
            tbNom.Enabled = true;
            tbPrenom.Enabled = true;
            tbDepartement.Enabled = true;
            tbCourriel.Enabled = true;
            mskTelephone.Enabled = true;
        }

        /// <summary>
        /// Cache les boutons enregistrer et annulé
        /// </summary>
        private void ModeConsultation()
        {
            btAnnuler.Visible = false;
            btEnregistrer.Visible = false;
            btNouveau.Visible = true;
            btVisualiser.Visible = true;

            tbMatrSel.Enabled = true;
            cbTypesClients.Enabled = false;
            tbCodeClient.Enabled = false;
            tbNom.Enabled = false;
            tbPrenom.Enabled = false;
            tbDepartement.Enabled = false;
            tbCourriel.Enabled = false;
            mskTelephone.Enabled = false;
        }

        /// <summary>
        /// Vide le contenue des texts box
        /// </summary>
        private void Clear()
        {
            tbMatrSel.Text = "";
            tbCodeClient.Text = "";
            tbNom.Text = "";
            tbPrenom.Text = "";
            tbDepartement.Text = "";
            tbCourriel.Text = "";
            mskTelephone.Text = "";
        }

        /// <summary>
        /// Lorsque l'on quitte le champ matricule, on affiche le client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TbMatrSel_Leave(object sender, EventArgs e)
        {
            AfficherClient();
        }

        /// <summary>
        /// Méthode qui permet d'afficher les informations du client dans les textbox
        /// </summary>
        private void AfficherClient()
        {
            DataTable client = null;

            if (!tbMatrSel.Text.Trim().Equals("")) // Valide si l'utilisateur a entré un matricule
                client = BD.DataClients.GetInstance().GetClient(tbMatrSel.Text);
            else
            {
                //MessageBox.Show("Veuillez sélectionner le matricule du client.", "Serge | Gestion des clients - ERREUR",
                //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (client.Rows.Count > 0) // Valide si le matricule est existant
            {
                // Affiche l'information du client dans les Txt Box
                tbCodeClient.Text = client.Rows[0][0].ToString();
                tbNom.Text = client.Rows[0][1].ToString();
                tbPrenom.Text = client.Rows[0][2].ToString();
                tbDepartement.Text = client.Rows[0][3].ToString();
                mskTelephone.Text = client.Rows[0][5].ToString();
                tbCourriel.Text = client.Rows[0][4].ToString();
                cbTypesClients.SelectedItem = client.Rows[0][6].ToString();
                ChargerLocationClient();
            }
            else
            {
                MessageBox.Show("Le client sélectionné est inexistant.", "Serge | Gestion des clients - ERREUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ModeConsultation();

            // Permet la modification du client

            cbTypesClients.Enabled = true;
            tbCodeClient.Enabled = true;
            tbNom.Enabled = true;
            tbPrenom.Enabled = true;
            tbDepartement.Enabled = true;
            tbCourriel.Enabled = true;
            mskTelephone.Enabled = true;

            edition = false;
        }

        /// <summary>
        /// Méthode qui charge les locations en cours d'un client
        /// </summary>
        private void ChargerLocationClient()
        {
            DataTable tabLocationsClient = BD.DataClients.GetInstance().GetDataLocationsClient(tbCodeClient.Text);

            if (tabLocationsClient.Rows.Count > 0 || tabLocationsClient != null) // Valide si la tab est plus grand que 0 afin de ne pas avoir d'erreur
            {
                dgvListeEmprunts.Rows.Clear(); // Vide le contenu du dgvProprietaire

                for (int i = 0; i < tabLocationsClient.Rows.Count; i++)
                {
                    dgvListeEmprunts.Rows.Add();

                    // dgvListeEmprunts.Rows[i].Cells[0].Value = tabLocationsClient.Rows[i][0].ToString();
                    dgvListeEmprunts.Rows[i].Cells[1].Value = tabLocationsClient.Rows[i][0].ToString();
                    dgvListeEmprunts.Rows[i].Cells[2].Value = tabLocationsClient.Rows[i][1].ToString();
                    dgvListeEmprunts.Rows[i].Cells[3].Value = tabLocationsClient.Rows[i][2].ToString();
                    dgvListeEmprunts.Rows[i].Cells[4].Value = tabLocationsClient.Rows[i][3].ToString();

                    DateTime dateRetourPrevu = Convert.ToDateTime(tabLocationsClient.Rows[i][3].ToString());

                    if (dateRetourPrevu < DateTime.Now)
                    {
                        dgvListeEmprunts.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                    }
                }
            }
        }

        /// <summary>
        /// S'applique à toutes les méthodes suivantes
        /// 
        /// Valide si l'utilisateur a modifié une information, si oui, on tombe en mode édition
        /// </summary>
        #region EditLabel

        private void cbTypesClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!edition)
            {
                edition = true;
                operation = false;

                ModeEdition();
            }
        }

        private void tbCodeClient_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text.StartsWith(" "))
            {
                tbCodeClient.Text = "";
            }

            if (!edition)
            {
                edition = true;
                operation = false;

                ModeEdition();
            }
        }

        private void tbPrenom_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text.StartsWith(" "))
            {
                tbPrenom.Text = "";
            }

            if (!edition)
            {
                edition = true;
                operation = false;

                ModeEdition();
            }
        }

        private void tbNom_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text.StartsWith(" "))
            {
                tbNom.Text = "";
            }

            if (!edition)
            {
                edition = true;
                operation = false;

                ModeEdition();
            }
        }

        private void tbDepartement_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text.StartsWith(" "))
            {
                tbDepartement.Text = "";
            }

            if (!edition)
            {
                edition = true;
                operation = false;

                ModeEdition();
            }
        }

        private void mskTelephone_TextChanged(object sender, EventArgs e)
        {
            if (!edition)
            {
                edition = true;
                operation = false;

                ModeEdition();
            }
        }

        private void tbCourriel_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text.StartsWith(" "))
            {
                tbCourriel.Text = "";
            }

            if (!edition)
            {
                edition = true;
                operation = false;

                ModeEdition();
            }
        }

        #endregion

        /// <summary>
        /// Vérifie les charactères entré dans les zones de textes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region TEXTBOX

        private void tbMatrSel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        private void tbCodeClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        private void tbMatrSel_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text.StartsWith(" "))
            {
                tbMatrSel.Text = "";
            }
        }

        #endregion
    }
}
