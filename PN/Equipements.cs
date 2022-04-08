using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GestionPret.PN
{
    public partial class Equipements : UserControl
    {
        /// <summary>
        /// Option de visualisation des équipements :
        ///     0 = Tous
        ///     1 = Disponibles
        ///     2 = Empruntés
        /// </summary>
        private int typeEquipement = 1;

        /// <summary>
        /// Vrai si l'utilisateur est en trein de modifier un équipement, faux si ajout
        /// </summary>
        private bool editing;

        /// <summary>
        /// Vrai ou faux si l'équipement était activé ou pas avant la désactivation
        /// lors du changement de la condition à endommagé ou défectueux.
        /// </summary>
        private bool activer = true;

        /// <summary>
        /// Dernière sélection dans le ComboBox cbCondition
        /// </summary>
        private int lastConditionIndex = -1;

        /// <summary>
        /// Vrai si l'utilisateur est en trein de modifier une catégorie, faux si ajout
        /// </summary>
        private bool editingCategorie;

        /// <summary>
        /// Ancient numéro de la catégorie avant la modification
        /// </summary>
        private int oldNumeroCategorie = 0;

        public Equipements()
        {
            InitializeComponent();

            gbNouvelEquipement.Visible = false;
            btAnnuler.Visible = false;
            btEnregistrer.Visible = false;

            cbTypeEquipement.SelectedIndex = 0;
            UpdateCategories();
        }

        /// <summary>
        /// Load la liste des catégories d'équipement
        /// </summary>
        private void UpdateCategories()
        {
            cbCategorie.Items.Clear();

            List<String> listCategories = BD.DataProduits.GetInstance().GetCategoriesEquipement();

            foreach (String categorie in listCategories)
            {
                cbCategorie.Items.Add(categorie);
            }
        }

        /// <summary>
        /// Ouverture de l'interface d'ajout d'un nouvel équipement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btNouveau_Click(object sender, EventArgs e)
        {
            OuvrirAjout();
            editing = false;

            chkActif.Checked = true;
            gbNouvelEquipement.Text = "Nouvel équipement";
        }

        /// <summary>
        /// Ouvre la fenêtre d'ajout/modification d'équipement
        /// </summary>
        private void OuvrirAjout()
        {
            gbNouvelEquipement.Visible = true;

            btNouveau.Visible = false;
            btVisualiser.Visible = false;
            btAnnuler.Visible = true;
            btEnregistrer.Visible = true;
        }

        /// <summary>
        /// Ferme la fenêtre d'ajout/modification d'équipement
        /// </summary>
        private void FermerAjout()
        {
            gbNouvelEquipement.Visible = false;

            btNouveau.Visible = true;
            btVisualiser.Visible = true;
            btAnnuler.Visible = false;
            btEnregistrer.Visible = false;

            tbNumero.Text = "";
            tbNumeroSerie.Text = "";
            cbCategorie.SelectedIndex = -1;
            tbDescription.Text = "";

            tbNumero.ReadOnly = false;
            tbNumeroSerie.ReadOnly = false;
        }

        /// <summary>
        /// Annulation de l'ajout/modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAnnuler_Click(object sender, EventArgs e)
        {
            FermerAjout();
        }

        /// <summary>
        /// Ouvre l'interface de modification de l'équipement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btVisualiser_Click(object sender, EventArgs e)
        {
            if (dgvEquipements.SelectedCells.Count > 0)
            {
                OuvrirAjout();
                editing = true;
                gbNouvelEquipement.Text = "Modification d'équipement";

                string numeroEdit = dgvEquipements.Rows[dgvEquipements.CurrentCell.RowIndex].Cells[0].Value.ToString();

                DataTable equipement = BD.DataProduits.GetInstance().GetEquipement(numeroEdit);

                tbNumero.Text = equipement.Rows[0][0].ToString();
                tbDescription.Text = equipement.Rows[0][1].ToString();
                tbNumeroSerie.Text = equipement.Rows[0][2].ToString();

                foreach (string s in cbCategorie.Items)
                {
                    if (s.StartsWith(equipement.Rows[0][3].ToString()))
                    {
                        cbCategorie.SelectedItem = s;
                        return;
                    }
                }

                cbCondition.SelectedIndex = Convert.ToInt32(equipement.Rows[0][4].ToString()) - 1;

                if (Convert.ToInt32(equipement.Rows[0][5].ToString()) == 1)
                    chkActif.Checked = true;
                else
                    chkActif.Checked = false;

                tbNumero.ReadOnly = true;
                tbNumeroSerie.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un équipement.");
            }
        }

        /// <summary>
        /// Enregistre les informations lors de l'ajout ou de la modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            int actif;
            MettreCouleurTxtBxNormal();

            if (!BD.DataProduits.GetInstance().VerifEquipementExiste(tbNumero.Text) && !editing)
            {
                lErreurNumero.Visible = true;
                return;
            }

            if (!BD.DataProduits.GetInstance().VerifEquipementDejaDansBD(tbNumeroSerie.Text) && !editing)
            {
                lErreurNumeroSerie.Visible = true;
                return;
            }

            if (tbNumero.Text.Trim().Equals("") || tbNumeroSerie.Text.Trim().Equals("") || tbDescription.Text.Trim().Equals("") ||
            cbCategorie.Text.Trim().Equals(""))
            {
                if (tbNumero.Text.Trim().Equals(""))
                    tbNumero.BackColor = Color.Pink;
                if (tbNumeroSerie.Text.Trim().Equals(""))
                    tbNumeroSerie.BackColor = Color.Pink;
                if (tbDescription.Text.Trim().Equals(""))
                    tbDescription.BackColor = Color.Pink;
                if (cbCategorie.Text.Trim().Equals(""))
                    cbCategorie.BackColor = Color.Pink;
                if (cbCondition.Text.Trim().Equals(""))
                    cbCondition.BackColor = Color.Pink;

                MessageBox.Show("Vous devez compléter tous les champs.", "Serge | Gestion des équipements - ERREUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Trouve l'index de l'espace pour extraire le id de la categorie
            int indexEspace = cbCategorie.SelectedItem.ToString().IndexOf(" ", StringComparison.Ordinal);
            int categorie = Convert.ToInt32(cbCategorie.SelectedItem.ToString().Substring(0, indexEspace));

            if (chkActif.Checked)
                actif = 1;
            else
                actif = 2;

            if (!editing) // ajout
            {
                if (BD.DataProduits.GetInstance().AjouterEquipement(tbNumero.Text, tbNumeroSerie.Text, categorie, tbDescription.Text, (cbCondition.SelectedIndex + 1), actif))
                {
                    UpdateDGV();
                    FermerAjout();
                }
                else
                    return;
            }
            else // modification
            {
                if (BD.DataProduits.GetInstance().ModifierEquipement(tbNumero.Text, categorie, tbDescription.Text, (cbCondition.SelectedIndex + 1), actif))
                {
                    UpdateDGV();
                    FermerAjout();
                }
                else
                    return;
            }
        }

        /// <summary>
        /// Remmet les couleurs par défaut des champs
        /// </summary>
        private void MettreCouleurTxtBxNormal()
        {
            tbNumero.BackColor = Color.Azure;
            tbNumeroSerie.BackColor = Color.Azure;
            tbDescription.BackColor = Color.Azure;
            cbCategorie.BackColor = Color.Azure;
            cbCondition.BackColor = Color.Azure;

            lErreurNumero.Visible = false;
            lErreurNumeroSerie.Visible = false;
        }

        /// <summary>
        /// Update le DataGridView avec les nouvelles informations lors du changement du filtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbTypeEquipement_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDGV();
        }

        /// <summary>
        /// Update le DataGridView avec les nouvelles informations
        /// </summary>
        private void UpdateDGV()
        {
            typeEquipement = cbTypeEquipement.SelectedIndex;

            gbVisualiser.Text = cbTypeEquipement.SelectedItem.ToString();

            try
            {
                DataTable data = BD.DataProduits.GetInstance().GetEquipements(typeEquipement);

                if (data.Rows.Count > 0)
                {
                    dgvEquipements.Rows.Clear();

                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        dgvEquipements.Rows.Add();

                        dgvEquipements.Rows[i].Cells[0].Value = data.Rows[i][0].ToString();
                        dgvEquipements.Rows[i].Cells[1].Value = data.Rows[i][1].ToString();
                        dgvEquipements.Rows[i].Cells[2].Value = data.Rows[i][2].ToString();
                        dgvEquipements.Rows[i].Cells[3].Value = data.Rows[i][3].ToString();
                        dgvEquipements.Rows[i].Cells[4].Value = data.Rows[i][4].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Serge | Affichage des équipements - ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Vérifications lors de la modification des TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Textbox

        private void tbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        private void tbNumeroSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        private void tbNumero_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text.StartsWith(" "))
            {
                tbNumero.Text = "";
            }
        }

        private void tbNumeroSerie_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text.StartsWith(" "))
            {
                tbNumeroSerie.Text = "";
            }
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text.StartsWith(" "))
            {
                tbDescription.Text = "";
            }

            lCharacteres.Text = "Charactères restant: " + (150 - tbDescription.Text.Length);
        }

        private void tbNomCategorie_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            if (textBox.Text.StartsWith(" "))
            {
                tbNomCategorie.Text = "";
            }
        }

        private void tbNomCategorie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        #endregion

        /// <summary>
        /// Active ou désactive l'équipement selon la codition de celui-ci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {
            int condition = cbCondition.SelectedIndex;

            if (condition == 2 || condition == 3)
            {
                if (lastConditionIndex != 2 && lastConditionIndex != 3)
                {
                    if (chkActif.Checked)
                        activer = true;
                    else
                        activer = false;
                }

                chkActif.Checked = false;
                lDesactiver.Visible = true;
                chkActif.Enabled = false;
            }
            else
            {
                chkActif.Checked = true;
                lDesactiver.Visible = false;
                chkActif.Enabled = true;

                if (activer)
                    chkActif.Checked = true;
                else
                    chkActif.Checked = false;
            }

            lastConditionIndex = condition;
        }

        /// <summary>
        /// Enlève le message d'erreur lorsque la catégorie est changé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            lChoisirCategorie.Visible = false;
        }

        /// <summary>
        /// Ouvre la fenetre d'ajout d'une categorie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAjoutCategorie_Click(object sender, EventArgs e)
        {
            if (cbCategorie.SelectedIndex != -1)
            {
                int indexEspace = cbCategorie.SelectedItem.ToString().IndexOf(" ", StringComparison.Ordinal);
                oldNumeroCategorie = Convert.ToInt32(cbCategorie.SelectedItem.ToString().Substring(0, indexEspace));
            }

            btSupprimerCategorie.Visible = false;
            ShowAjoutCategorie();
        }

        /// <summary>
        /// Ouvre la fenetre de modification d'une catégorie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModCategorie_Click(object sender, EventArgs e)
        {
            if (cbCategorie.SelectedIndex == -1)
                lChoisirCategorie.Visible = true;
            else
            {
                int indexEspace = cbCategorie.SelectedItem.ToString().IndexOf(" ", StringComparison.Ordinal);
                oldNumeroCategorie = Convert.ToInt32(cbCategorie.SelectedItem.ToString().Substring(0, indexEspace));
                numNumeroCategorie.Value = Convert.ToDecimal(oldNumeroCategorie);
                tbNomCategorie.Text = cbCategorie.SelectedItem.ToString().Substring(indexEspace + 3);
                btSupprimerCategorie.Visible = true;
                editingCategorie = true;
                ShowAjoutCategorie();
            }
        }

        /// <summary>
        /// Ouvre la fenêtre des categories et bloque les composantes de la fenêtre des équipements
        /// </summary>
        private void ShowAjoutCategorie()
        {
            chkActif.Enabled = false;
            tbNumeroSerie.ReadOnly = true;
            tbNumero.ReadOnly = true;
            tbDescription.ReadOnly = true;
            cbCondition.Enabled = false;
            btAjoutCategorie.Enabled = false;
            btModCategorie.Enabled = false;
            btEnregistrer.Enabled = false;
            btAnnuler.Enabled = false;

            gbAjoutCategorie.Visible = true;
        }

        /// <summary>
        /// Ferme la fenêtre des catégories
        /// </summary>
        private void ExitAjoutCategorie()
        {
            if (!editing)
            {
                chkActif.Enabled = true;
                tbNumeroSerie.ReadOnly = false;
                tbNumero.ReadOnly = false;
            }

            tbDescription.ReadOnly = false;
            cbCondition.Enabled = true;
            btAjoutCategorie.Enabled = true;
            btModCategorie.Enabled = true;
            btEnregistrer.Enabled = true;
            btAnnuler.Enabled = true;

            numNumeroCategorie.Value = 1;
            tbNomCategorie.Text = "";

            editingCategorie = false;
            oldNumeroCategorie = 0;

            gbAjoutCategorie.Visible = false;
        }

        /// <summary>
        /// Annule l'ajout ou la modification des catégories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAnnulerCategorie_Click(object sender, EventArgs e)
        {
            ExitAjoutCategorie();
        }

        /// <summary>
        /// Supprime la catégorie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSupprimerCategorie_Click(object sender, EventArgs e)
        {
            if (BD.DataProduits.GetInstance().VerifEquipementDansCategorie(oldNumeroCategorie))
            {
                var result = MessageBox.Show(this, "Il existe des équipements dans cette catégorie.\n\n" +
                                                    "Ces équipements ne seront plus placé dans une catégorie.\n\n" +
                                                    $"Voulez-vous vraiment supprimer la catégorie #{oldNumeroCategorie}?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (BD.DataProduits.GetInstance().SupprimerCategorie(oldNumeroCategorie))
                    {
                        UpdateCategories();
                        UpdateDGV();
                        ExitAjoutCategorie();
                    }
                }
            }
            else
            {
                var result = MessageBox.Show(this, $"Voulez-vous vraiment supprimer la catégorie #{oldNumeroCategorie}?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (BD.DataProduits.GetInstance().SupprimerCategorie(oldNumeroCategorie))
                    {
                        UpdateCategories();
                        UpdateDGV();
                        ExitAjoutCategorie();
                    }
                }
            }
        }

        /// <summary>
        /// Enregistre les modifications faites sur la catégorie ou ajoute une nouvelle catégorie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEnregistrerCategorie_Click(object sender, EventArgs e)
        {
            tbNomCategorie.BackColor = Color.Azure;

            //Vérifie si tous les champs on été complété
            if (tbNomCategorie.Text.Trim().Equals(""))
            {
                tbNomCategorie.BackColor = Color.Pink;

                MessageBox.Show("Vous devez compléter tous les champs.", "Serge | Gestion des équipements - ERREUR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Vérifie si une catégorie avec ce numéro existe déja pour l'ajout
            if (BD.DataProduits.GetInstance().VerifCategorieExiste(numNumeroCategorie.Value.ToString()) || (editingCategorie && oldNumeroCategorie == Convert.ToInt32(numNumeroCategorie.Value)))
            {
                if (editingCategorie) //Modification
                {
                    if (BD.DataProduits.GetInstance().ModifierCategorie(oldNumeroCategorie, Convert.ToInt32(numNumeroCategorie.Value), tbNomCategorie.Text))
                    {
                        UpdateDGV();
                        UpdateCategories();
                    }
                    else
                        return;
                }
                else //Ajout
                {
                    if (BD.DataProduits.GetInstance().AjouterCategorie(Convert.ToInt32(numNumeroCategorie.Value), tbNomCategorie.Text))
                    {
                        UpdateDGV();
                        UpdateCategories();
                    }
                    else
                        return;
                }

                if (oldNumeroCategorie != 0)
                    cbCategorie.SelectedItem = Convert.ToInt32(numNumeroCategorie.Value) + " - " + tbNomCategorie.Text;

                ExitAjoutCategorie();
            }
            else
            {
                lErreurNumCategorie.Visible = true;
            }
        }

        /// <summary>
        /// Enlève le label d'erreur du numéro de catégorie lors du changement du numéro de catégorie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numNumeroCategorie_ValueChanged(object sender, EventArgs e)
        {
            lErreurNumCategorie.Visible = false;
        }
    }
}
