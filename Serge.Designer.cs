
namespace GestionPret
{
    partial class Serge
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pToolBar = new System.Windows.Forms.Panel();
            this.btMin = new System.Windows.Forms.Button();
            this.btMax = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.lTitreFenetre = new System.Windows.Forms.Label();
            this.pOffset = new System.Windows.Forms.Panel();
            this.pOptions = new System.Windows.Forms.Panel();
            this.btUtilisateurs = new System.Windows.Forms.Button();
            this.btClients = new System.Windows.Forms.Button();
            this.btParametres = new System.Windows.Forms.Button();
            this.btEquipements = new System.Windows.Forms.Button();
            this.btLocations = new System.Windows.Forms.Button();
            this.pMain = new System.Windows.Forms.Panel();
            this.Deconnexion = new System.Windows.Forms.Button();
            this.pToolBar.SuspendLayout();
            this.pOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pToolBar
            // 
            this.pToolBar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pToolBar.Controls.Add(this.btMin);
            this.pToolBar.Controls.Add(this.btMax);
            this.pToolBar.Controls.Add(this.btClose);
            this.pToolBar.Controls.Add(this.lTitreFenetre);
            this.pToolBar.Controls.Add(this.pOffset);
            this.pToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pToolBar.Location = new System.Drawing.Point(0, 0);
            this.pToolBar.Margin = new System.Windows.Forms.Padding(4);
            this.pToolBar.Name = "pToolBar";
            this.pToolBar.Size = new System.Drawing.Size(1546, 37);
            this.pToolBar.TabIndex = 0;
            // 
            // btMin
            // 
            this.btMin.BackColor = System.Drawing.Color.Transparent;
            this.btMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMin.FlatAppearance.BorderSize = 0;
            this.btMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMin.Image = global::GestionPret.Properties.Resources.min;
            this.btMin.Location = new System.Drawing.Point(1426, 0);
            this.btMin.Margin = new System.Windows.Forms.Padding(4);
            this.btMin.Name = "btMin";
            this.btMin.Size = new System.Drawing.Size(40, 37);
            this.btMin.TabIndex = 2;
            this.btMin.UseVisualStyleBackColor = false;
            this.btMin.Click += new System.EventHandler(this.BtMin_Click);
            // 
            // btMax
            // 
            this.btMax.BackColor = System.Drawing.Color.Transparent;
            this.btMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMax.FlatAppearance.BorderSize = 0;
            this.btMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMax.Image = global::GestionPret.Properties.Resources.max;
            this.btMax.Location = new System.Drawing.Point(1466, 0);
            this.btMax.Margin = new System.Windows.Forms.Padding(4);
            this.btMax.Name = "btMax";
            this.btMax.Size = new System.Drawing.Size(40, 37);
            this.btMax.TabIndex = 1;
            this.btMax.UseVisualStyleBackColor = false;
            this.btMax.Click += new System.EventHandler(this.BtMax_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = global::GestionPret.Properties.Resources.close;
            this.btClose.Location = new System.Drawing.Point(1506, 0);
            this.btClose.Margin = new System.Windows.Forms.Padding(4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(40, 37);
            this.btClose.TabIndex = 0;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // lTitreFenetre
            // 
            this.lTitreFenetre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitreFenetre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lTitreFenetre.Location = new System.Drawing.Point(265, 0);
            this.lTitreFenetre.Name = "lTitreFenetre";
            this.lTitreFenetre.Size = new System.Drawing.Size(1281, 37);
            this.lTitreFenetre.TabIndex = 8;
            this.lTitreFenetre.Text = "SERGE";
            this.lTitreFenetre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lTitreFenetre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lTitreFenetre_MouseDown);
            // 
            // pOffset
            // 
            this.pOffset.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pOffset.Dock = System.Windows.Forms.DockStyle.Left;
            this.pOffset.Location = new System.Drawing.Point(0, 0);
            this.pOffset.Margin = new System.Windows.Forms.Padding(4);
            this.pOffset.Name = "pOffset";
            this.pOffset.Size = new System.Drawing.Size(265, 37);
            this.pOffset.TabIndex = 9;
            this.pOffset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.POffset_MouseDown);
            // 
            // pOptions
            // 
            this.pOptions.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pOptions.Controls.Add(this.Deconnexion);
            this.pOptions.Controls.Add(this.btUtilisateurs);
            this.pOptions.Controls.Add(this.btClients);
            this.pOptions.Controls.Add(this.btParametres);
            this.pOptions.Controls.Add(this.btEquipements);
            this.pOptions.Controls.Add(this.btLocations);
            this.pOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pOptions.Location = new System.Drawing.Point(0, 37);
            this.pOptions.Margin = new System.Windows.Forms.Padding(4);
            this.pOptions.Name = "pOptions";
            this.pOptions.Size = new System.Drawing.Size(265, 723);
            this.pOptions.TabIndex = 1;
            // 
            // btUtilisateurs
            // 
            this.btUtilisateurs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btUtilisateurs.FlatAppearance.BorderSize = 0;
            this.btUtilisateurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUtilisateurs.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btUtilisateurs.ForeColor = System.Drawing.Color.Black;
            this.btUtilisateurs.Location = new System.Drawing.Point(0, 162);
            this.btUtilisateurs.Margin = new System.Windows.Forms.Padding(4);
            this.btUtilisateurs.Name = "btUtilisateurs";
            this.btUtilisateurs.Size = new System.Drawing.Size(265, 54);
            this.btUtilisateurs.TabIndex = 7;
            this.btUtilisateurs.Text = "Utilisateurs";
            this.btUtilisateurs.UseVisualStyleBackColor = true;
            this.btUtilisateurs.Click += new System.EventHandler(this.BtUtilisateurs_Click);
            // 
            // btClients
            // 
            this.btClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btClients.FlatAppearance.BorderSize = 0;
            this.btClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClients.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btClients.ForeColor = System.Drawing.Color.Black;
            this.btClients.Location = new System.Drawing.Point(0, 108);
            this.btClients.Margin = new System.Windows.Forms.Padding(4);
            this.btClients.Name = "btClients";
            this.btClients.Size = new System.Drawing.Size(265, 54);
            this.btClients.TabIndex = 5;
            this.btClients.Text = "Clients";
            this.btClients.UseVisualStyleBackColor = true;
            this.btClients.Click += new System.EventHandler(this.BtClients_Click);
            // 
            // btParametres
            // 
            this.btParametres.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btParametres.FlatAppearance.BorderSize = 0;
            this.btParametres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btParametres.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btParametres.ForeColor = System.Drawing.Color.Black;
            this.btParametres.Image = global::GestionPret.Properties.Resources.settings1;
            this.btParametres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btParametres.Location = new System.Drawing.Point(0, 669);
            this.btParametres.Margin = new System.Windows.Forms.Padding(4);
            this.btParametres.Name = "btParametres";
            this.btParametres.Size = new System.Drawing.Size(265, 54);
            this.btParametres.TabIndex = 4;
            this.btParametres.Text = "Paramètres";
            this.btParametres.UseVisualStyleBackColor = true;
            this.btParametres.Click += new System.EventHandler(this.BtParametres_Click);
            // 
            // btEquipements
            // 
            this.btEquipements.Dock = System.Windows.Forms.DockStyle.Top;
            this.btEquipements.FlatAppearance.BorderSize = 0;
            this.btEquipements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEquipements.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btEquipements.ForeColor = System.Drawing.Color.Black;
            this.btEquipements.Location = new System.Drawing.Point(0, 54);
            this.btEquipements.Margin = new System.Windows.Forms.Padding(4);
            this.btEquipements.Name = "btEquipements";
            this.btEquipements.Size = new System.Drawing.Size(265, 54);
            this.btEquipements.TabIndex = 6;
            this.btEquipements.Text = "Équipements";
            this.btEquipements.UseVisualStyleBackColor = true;
            this.btEquipements.Click += new System.EventHandler(this.BtEquipements_Click);
            // 
            // btLocations
            // 
            this.btLocations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btLocations.FlatAppearance.BorderSize = 0;
            this.btLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLocations.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.btLocations.ForeColor = System.Drawing.Color.Black;
            this.btLocations.Location = new System.Drawing.Point(0, 0);
            this.btLocations.Margin = new System.Windows.Forms.Padding(4);
            this.btLocations.Name = "btLocations";
            this.btLocations.Size = new System.Drawing.Size(265, 54);
            this.btLocations.TabIndex = 2;
            this.btLocations.Text = "Locations";
            this.btLocations.UseVisualStyleBackColor = true;
            this.btLocations.Click += new System.EventHandler(this.BtLocations_Click);
            // 
            // pMain
            // 
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(265, 37);
            this.pMain.Margin = new System.Windows.Forms.Padding(4);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1281, 723);
            this.pMain.TabIndex = 3;
            // 
            // Deconnexion
            // 
            this.Deconnexion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Deconnexion.FlatAppearance.BorderSize = 0;
            this.Deconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deconnexion.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold);
            this.Deconnexion.ForeColor = System.Drawing.Color.Black;
            this.Deconnexion.Location = new System.Drawing.Point(0, 615);
            this.Deconnexion.Margin = new System.Windows.Forms.Padding(4);
            this.Deconnexion.Name = "Deconnexion";
            this.Deconnexion.Size = new System.Drawing.Size(265, 54);
            this.Deconnexion.TabIndex = 8;
            this.Deconnexion.Text = "Deconnexion";
            this.Deconnexion.UseVisualStyleBackColor = true;
            this.Deconnexion.Click += new System.EventHandler(this.Deconnexion_Click);
            // 
            // Serge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1546, 760);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pOptions);
            this.Controls.Add(this.pToolBar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Serge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serge | Gestion Location";
            this.Load += new System.EventHandler(this.Serge_Load);
            this.pToolBar.ResumeLayout(false);
            this.pOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pToolBar;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btMax;
        private System.Windows.Forms.Button btMin;
        private System.Windows.Forms.Panel pOptions;
        private System.Windows.Forms.Button btLocations;
        private System.Windows.Forms.Button btParametres;
        private System.Windows.Forms.Button btClients;
        private System.Windows.Forms.Button btEquipements;
        private System.Windows.Forms.Label lTitreFenetre;
        private System.Windows.Forms.Panel pOffset;
        private System.Windows.Forms.Button btUtilisateurs;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button Deconnexion;
    }
}

