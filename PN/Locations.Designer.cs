
namespace GestionPret.PN
{
    partial class Locations
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btRetourLocation = new System.Windows.Forms.Button();
            this.btNouveau = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLocationsCourrantes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvRetoursJournee = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvRetardsLocations = new System.Windows.Forms.DataGridView();
            this.pnLocation = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocationsCourrantes)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetoursJournee)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetardsLocations)).BeginInit();
            this.pnLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1281, 41);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btRetourLocation);
            this.panel2.Controls.Add(this.btNouveau);
            this.panel2.Location = new System.Drawing.Point(1040, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 46);
            this.panel2.TabIndex = 24;
            // 
            // btRetourLocation
            // 
            this.btRetourLocation.Dock = System.Windows.Forms.DockStyle.Right;
            this.btRetourLocation.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btRetourLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRetourLocation.Image = global::GestionPret.Properties.Resources.ICO_Modifier;
            this.btRetourLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRetourLocation.Location = new System.Drawing.Point(14, 0);
            this.btRetourLocation.Name = "btRetourLocation";
            this.btRetourLocation.Size = new System.Drawing.Size(108, 46);
            this.btRetourLocation.TabIndex = 5;
            this.btRetourLocation.Text = "Retour de location";
            this.btRetourLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRetourLocation.UseVisualStyleBackColor = true;
            this.btRetourLocation.Click += new System.EventHandler(this.BtRetour_Click);
            // 
            // btNouveau
            // 
            this.btNouveau.Dock = System.Windows.Forms.DockStyle.Right;
            this.btNouveau.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNouveau.Image = global::GestionPret.Properties.Resources.ICO_Nouveau;
            this.btNouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNouveau.Location = new System.Drawing.Point(122, 0);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(105, 46);
            this.btNouveau.TabIndex = 4;
            this.btNouveau.Text = "Nouvelle location";
            this.btNouveau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNouveau.UseVisualStyleBackColor = true;
            this.btNouveau.Click += new System.EventHandler(this.BtNouveau_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.dgvLocationsCourrantes);
            this.groupBox1.Location = new System.Drawing.Point(29, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 616);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Locations en cours";
            // 
            // dgvLocationsCourrantes
            // 
            this.dgvLocationsCourrantes.AllowUserToAddRows = false;
            this.dgvLocationsCourrantes.AllowUserToDeleteRows = false;
            this.dgvLocationsCourrantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocationsCourrantes.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvLocationsCourrantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLocationsCourrantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocationsCourrantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocationsCourrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocationsCourrantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocationsCourrantes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocationsCourrantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLocationsCourrantes.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dgvLocationsCourrantes.Location = new System.Drawing.Point(3, 21);
            this.dgvLocationsCourrantes.Name = "dgvLocationsCourrantes";
            this.dgvLocationsCourrantes.ReadOnly = true;
            this.dgvLocationsCourrantes.RowHeadersVisible = false;
            this.dgvLocationsCourrantes.Size = new System.Drawing.Size(604, 592);
            this.dgvLocationsCourrantes.TabIndex = 1;
            this.dgvLocationsCourrantes.DoubleClick += new System.EventHandler(this.dgvLocationsCourrantes_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No Location";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Date";
            this.Column2.MinimumWidth = 125;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Équipement";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Client (nom, prenom)";
            this.Column3.MinimumWidth = 200;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Date prévue";
            this.Column4.MinimumWidth = 125;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.dgvRetoursJournee);
            this.groupBox2.Location = new System.Drawing.Point(657, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 316);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Retours de la journée";
            // 
            // dgvRetoursJournee
            // 
            this.dgvRetoursJournee.AllowUserToAddRows = false;
            this.dgvRetoursJournee.AllowUserToDeleteRows = false;
            this.dgvRetoursJournee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRetoursJournee.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvRetoursJournee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRetoursJournee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRetoursJournee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRetoursJournee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRetoursJournee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Nom,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRetoursJournee.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRetoursJournee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRetoursJournee.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dgvRetoursJournee.Location = new System.Drawing.Point(3, 21);
            this.dgvRetoursJournee.Name = "dgvRetoursJournee";
            this.dgvRetoursJournee.ReadOnly = true;
            this.dgvRetoursJournee.RowHeadersVisible = false;
            this.dgvRetoursJournee.Size = new System.Drawing.Size(604, 292);
            this.dgvRetoursJournee.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No Location";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Client (nom, prenom)";
            this.Nom.MinimumWidth = 200;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Équipement";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Date d\'emprunt";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.dgvRetardsLocations);
            this.groupBox3.Location = new System.Drawing.Point(657, 396);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(610, 281);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Retard";
            // 
            // dgvRetardsLocations
            // 
            this.dgvRetardsLocations.AllowUserToAddRows = false;
            this.dgvRetardsLocations.AllowUserToDeleteRows = false;
            this.dgvRetardsLocations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRetardsLocations.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvRetardsLocations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRetardsLocations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRetardsLocations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRetardsLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRetardsLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column5,
            this.Column7});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRetardsLocations.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRetardsLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRetardsLocations.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dgvRetardsLocations.Location = new System.Drawing.Point(3, 21);
            this.dgvRetardsLocations.Name = "dgvRetardsLocations";
            this.dgvRetardsLocations.ReadOnly = true;
            this.dgvRetardsLocations.RowHeadersVisible = false;
            this.dgvRetardsLocations.Size = new System.Drawing.Size(604, 257);
            this.dgvRetardsLocations.TabIndex = 1;
            // 
            // pnLocation
            // 
            this.pnLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnLocation.Controls.Add(this.groupBox1);
            this.pnLocation.Controls.Add(this.panel2);
            this.pnLocation.Controls.Add(this.groupBox3);
            this.pnLocation.Controls.Add(this.groupBox2);
            this.pnLocation.Location = new System.Drawing.Point(0, 3);
            this.pnLocation.Name = "pnLocation";
            this.pnLocation.Size = new System.Drawing.Size(1281, 727);
            this.pnLocation.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "No Location";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Client (nom, prenom)";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Équipement";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date prévue";
            this.Column5.MinimumWidth = 150;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nb jours retard";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Locations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.pnLocation);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Locations";
            this.Size = new System.Drawing.Size(1281, 730);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocationsCourrantes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetoursJournee)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRetardsLocations)).EndInit();
            this.pnLocation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btRetourLocation;
        private System.Windows.Forms.Button btNouveau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvLocationsCourrantes;
        private System.Windows.Forms.DataGridView dgvRetoursJournee;
        private System.Windows.Forms.DataGridView dgvRetardsLocations;
        private System.Windows.Forms.Panel pnLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
