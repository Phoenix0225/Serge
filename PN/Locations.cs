using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;

namespace GestionPret.PN
{
    public partial class Locations : UserControl
    {
        /// <summary>
        /// User Control AddModLOcation.cs
        /// </summary>
        AddModLocation ucAddModLocation;

        AddModRetour ucAddModRetour;

        CultureInfo culture;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Locations()
        {
            InitializeComponent();

            culture = new CultureInfo(CultureInfo.CurrentCulture.Name);

            ChargerLocationsCourrantes();
            ChargerLocationRetourJournee();
            ChargerLocationsRetard();
        }

        /// <summary>
        /// Permet de créer une nouvelle location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtNouveau_Click(object sender, EventArgs e)
        {
            ucAddModLocation = new AddModLocation(this);

            pnLocation.Controls.Add(ucAddModLocation);
            ucAddModLocation.Dock = DockStyle.Fill;
            ucAddModLocation.BringToFront();
        }

        /// <summary>
        /// Affiche les locations courrante dans le tableau
        /// </summary>
        public void ChargerLocationsCourrantes()
        {
            DataTable tabLocationsCourrantes = BD.DataLocations.GetInstance().GetDataLocationsCourrantes();

            if (tabLocationsCourrantes != null)
            {
                if (tabLocationsCourrantes.Rows.Count > 0) // Valide si la tab est plus grand que 0 afin de ne pas avoir d'erreur
                {
                    dgvLocationsCourrantes.Rows.Clear(); // Vide le contenu du dgvProprietaire

                    for (int i = 0; i < tabLocationsCourrantes.Rows.Count; i++)
                    {
                        dgvLocationsCourrantes.Rows.Add();

                        dgvLocationsCourrantes.Rows[i].Cells[0].Value = tabLocationsCourrantes.Rows[i][4].ToString();
                        dgvLocationsCourrantes.Rows[i].Cells[1].Value = tabLocationsCourrantes.Rows[i][2].ToString();
                        dgvLocationsCourrantes.Rows[i].Cells[2].Value = tabLocationsCourrantes.Rows[i][1].ToString();
                        dgvLocationsCourrantes.Rows[i].Cells[3].Value = tabLocationsCourrantes.Rows[i][0].ToString();
                        dgvLocationsCourrantes.Rows[i].Cells[4].Value = tabLocationsCourrantes.Rows[i][3].ToString();

                       // DateTime dateRetourPrevu = Convert.ToDateTime(tabLocationsCourrantes.Rows[i][3].ToString());
                        DateTime dateRetourPrevu = Convert.ToDateTime(tabLocationsCourrantes.Rows[i][3].ToString(), culture); // test

                        if (dateRetourPrevu < DateTime.Now) // Si l'équipement est en retard, on met la ligne en rose
                        {
                            dgvLocationsCourrantes.Rows[i].DefaultCellStyle.BackColor = Color.Pink;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Affiche les locations en retard dans le tableau
        /// </summary>
        public void ChargerLocationsRetard()
        {
            DataTable tabRetardsLocations = BD.DataLocations.GetInstance().GetDataRetardsLocations();

            if (tabRetardsLocations != null)
            {
                if (tabRetardsLocations.Rows.Count > 0) // Valide si la tab est plus grand que 0 afin de ne pas avoir d'erreur
                {
                    dgvRetardsLocations.Rows.Clear(); // Vide le contenu du dgvProprietaire

                    for (int i = 0; i < tabRetardsLocations.Rows.Count; i++)
                    {
                        dgvRetardsLocations.Rows.Add();

                        dgvRetardsLocations.Rows[i].Cells[0].Value = tabRetardsLocations.Rows[i][0].ToString();
                        dgvRetardsLocations.Rows[i].Cells[1].Value = tabRetardsLocations.Rows[i][1].ToString();
                        dgvRetardsLocations.Rows[i].Cells[2].Value = tabRetardsLocations.Rows[i][2].ToString();
                        dgvRetardsLocations.Rows[i].Cells[3].Value = tabRetardsLocations.Rows[i][3].ToString();
                        dgvRetardsLocations.Rows[i].Cells[4].Value = tabRetardsLocations.Rows[i][4].ToString();
                    }
                }
            }
        }

        /// <summary>
        /// Charge les retour de location prévues dans la journee
        /// </summary>
        public void ChargerLocationRetourJournee()
        {
            DataTable tabRetoursLocationJournee = BD.DataLocations.GetInstance().GetDataRetourJournee();

            if (tabRetoursLocationJournee != null)
            {
                if (tabRetoursLocationJournee.Rows.Count > 0) // Valide si la tab est plus grand que 0 afin de ne pas avoir d'erreur
                {
                    dgvRetoursJournee.Rows.Clear(); // Vide le contenu du dgvProprietaire

                    for (int i = 0; i < tabRetoursLocationJournee.Rows.Count; i++)
                    {
                        dgvRetoursJournee.Rows.Add();

                        // dgvRetoursJournee.Rows[i].Cells[0].Value = tabRetoursLocationJournee.Rows[i][3].ToString();
                        dgvRetoursJournee.Rows[i].Cells[1].Value = tabRetoursLocationJournee.Rows[i][0].ToString();
                        dgvRetoursJournee.Rows[i].Cells[2].Value = tabRetoursLocationJournee.Rows[i][1].ToString();
                        dgvRetoursJournee.Rows[i].Cells[3].Value = tabRetoursLocationJournee.Rows[i][2].ToString();
                    }
                }
            }
        }

        /// <summary>
        /// Pas active encore
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtRetour_Click(object sender, EventArgs e)
        {
            ucAddModRetour = new AddModRetour(this);

            pnLocation.Controls.Add(ucAddModRetour);
            ucAddModRetour.Dock = DockStyle.Fill;
            ucAddModRetour.BringToFront();
        }

        /// <summary>
        /// Ouvre la modification des locations lors du double clique sur la location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvLocationsCourrantes_DoubleClick(object sender, EventArgs e)
        {
            int noLocation = Convert.ToInt32(dgvLocationsCourrantes.CurrentRow.Cells[0].Value.ToString());

            ucAddModLocation = new AddModLocation(this, noLocation);

            pnLocation.Controls.Add(ucAddModLocation);
            ucAddModLocation.Dock = DockStyle.Fill;
            ucAddModLocation.BringToFront();
        }
    }
}
