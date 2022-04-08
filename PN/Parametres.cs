using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GestionPret.PN
{
    public partial class Parametres : UserControl
    {
        public Parametres()
        {
            InitializeComponent();

            LoadHoraire();
        }

        /// <summary>
        /// Change la couleur des plages horaires lorsqu'on clique dessus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToggleOuverture(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;

            if (panel.BackColor == Color.LightGreen)
            {
                panel.BackColor = Color.Azure;
            }
            else
            {
                panel.BackColor = Color.LightGreen;
            }
        }

        /// <summary>
        /// Enregistre les disponibilitées dans la BD
        /// </summary>
        private void EnregistrerHoraire()
        {
            foreach (Control control in pHoraire.Controls)
            {
                if (control is Panel)
                {
                    Panel panel = (Panel)control;

                    if (panel.Tag != null)
                    {
                        foreach (Control controlDedansHoraire in panel.Controls)
                        {
                            if (controlDedansHoraire is Panel)
                            {
                                Panel panelDedansHoraire = (Panel)controlDedansHoraire;

                                if (panelDedansHoraire.Tag != null)
                                {
                                    string journee = "";
                                    int ouvert = 0;
                                    int periode = 1;

                                    string noJournee = panelDedansHoraire.Tag.ToString().Substring(0, 1);
                                    if (noJournee.Equals("1"))
                                        journee = "Lundi";
                                    else if (noJournee.Equals("2"))
                                        journee = "Mardi";
                                    else if (noJournee.Equals("3"))
                                        journee = "Mercredi";
                                    else if (noJournee.Equals("4"))
                                        journee = "Jeudi";
                                    else if (noJournee.Equals("5"))
                                        journee = "Vendredi";

                                    if (panelDedansHoraire.BackColor == Color.LightGreen)
                                    {
                                        ouvert = 1;
                                    }
                                    else
                                    {
                                        ouvert = 0;
                                    }

                                    periode = Convert.ToInt32(panelDedansHoraire.Tag.ToString().Substring(1, 2));

                                    BD.DataSysteme.GetInstance().UpdateDispos(journee, periode, ouvert);
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Débloque la grille horaire pour la modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModifierHoraire_Click(object sender, EventArgs e)
        {
            pHoraire.Enabled = true;
            btAnnuler.Visible = true;
            btEnregistrer.Visible = true;
            btModifierHoraire.Visible = false;
        }

        /// <summary>
        /// Annule la modificaiton des disponibilitées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAnnuler_Click(object sender, EventArgs e)
        {
            pHoraire.Enabled = false;
            btAnnuler.Visible = false;
            btEnregistrer.Visible = false;
            btModifierHoraire.Visible = true;

            LoadHoraire();
        }
        
        /// <summary>
        /// Enregistre les disponibilitées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            EnregistrerHoraire();

            pHoraire.Enabled = false;
            btAnnuler.Visible = false;
            btEnregistrer.Visible = false;
            btModifierHoraire.Visible = true;
        }

        /// <summary>
        /// Met les disponibilités dans l'interface de la base de données de l'horaire
        /// </summary>
        private void LoadHoraire()
        {
            DataTable dispos = BD.DataSysteme.GetInstance().GetHoraire();

            foreach (DataRow row in dispos.Rows)
            {
                if (row[0].ToString().Equals("Lundi"))
                {
                    ChangeEtatDispo(pLundi.Controls, row, "1");
                }
                else if (row[0].ToString().Equals("Mardi"))
                {
                    ChangeEtatDispo(pMardi.Controls, row, "2");
                }
                else if (row[0].ToString().Equals("Mercredi"))
                {
                    ChangeEtatDispo(pMercredi.Controls, row, "3");
                }
                else if (row[0].ToString().Equals("Jeudi"))
                {
                    ChangeEtatDispo(pJeudi.Controls, row, "4");
                }
                else if (row[0].ToString().Equals("Vendredi"))
                {
                    ChangeEtatDispo(pVendredi.Controls, row, "5");
                }
            }
        }

        /// <summary>
        /// Change l'état d'ouverture d'une plage horaire
        /// </summary>
        /// <param name="controles">Controles</param>
        /// <param name="row">Row de la table</param>
        /// <param name="noJour">Numéro du jour</param>
        private void ChangeEtatDispo(ControlCollection controles, DataRow row, string noJour)
        {
            foreach (Control control in controles)
            {
                if (control is Panel)
                {
                    Panel panel = (Panel)control;

                    if (panel.Tag != null)
                    {
                        string nombreJournee = "";
                        if (row[1].ToString().Length == 1)
                            nombreJournee = noJour + "0";
                        else
                            nombreJournee = noJour;

                        if (panel.Tag.Equals(nombreJournee + row[1]))
                        {
                            if (!Convert.ToBoolean(row[2].ToString()))
                            {
                                panel.BackColor = Color.Azure;
                            }
                            else
                            {
                                panel.BackColor = Color.LightGreen;
                            }

                            return;
                        }
                    }
                }
            }
        }
        
        /// <summary>
        /// Ouvre le guide d'utilisation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btGuideUtilisation_Click(object sender, EventArgs e)
        {
            string pathGuide = Directory.GetParent(System.AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName + "\\Resources\\Guide_Utilisation.docx";

            System.Diagnostics.Process.Start(pathGuide);
        }
    }
}
