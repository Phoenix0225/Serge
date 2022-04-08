
namespace GestionPret.PN
{
    partial class Equipements
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipements));
            this.gbVisualiser = new System.Windows.Forms.GroupBox();
            this.dgvEquipements = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catégorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btVisualiser = new System.Windows.Forms.Button();
            this.btNouveau = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pAffichage = new System.Windows.Forms.Panel();
            this.gbAjoutCategorie = new System.Windows.Forms.GroupBox();
            this.lErreurNumCategorie = new System.Windows.Forms.Label();
            this.btAnnulerCategorie = new System.Windows.Forms.Button();
            this.btSupprimerCategorie = new System.Windows.Forms.Button();
            this.btEnregistrerCategorie = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.numNumeroCategorie = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNomCategorie = new System.Windows.Forms.TextBox();
            this.gbNouvelEquipement = new System.Windows.Forms.GroupBox();
            this.lChoisirCategorie = new System.Windows.Forms.Label();
            this.btModCategorie = new System.Windows.Forms.Button();
            this.lDesactiver = new System.Windows.Forms.Label();
            this.chkActif = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCondition = new System.Windows.Forms.ComboBox();
            this.lErreurNumeroSerie = new System.Windows.Forms.Label();
            this.lErreurNumero = new System.Windows.Forms.Label();
            this.lCharacteres = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btAjoutCategorie = new System.Windows.Forms.Button();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbNumeroSerie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTypeEquipement = new System.Windows.Forms.ComboBox();
            this.gbVisualiser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipements)).BeginInit();
            this.panel2.SuspendLayout();
            this.pAffichage.SuspendLayout();
            this.gbAjoutCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroCategorie)).BeginInit();
            this.gbNouvelEquipement.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVisualiser
            // 
            this.gbVisualiser.Controls.Add(this.dgvEquipements);
            this.gbVisualiser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVisualiser.Location = new System.Drawing.Point(0, 364);
            this.gbVisualiser.Name = "gbVisualiser";
            this.gbVisualiser.Size = new System.Drawing.Size(852, 145);
            this.gbVisualiser.TabIndex = 35;
            this.gbVisualiser.TabStop = false;
            this.gbVisualiser.Text = "Equipements";
            // 
            // dgvEquipements
            // 
            this.dgvEquipements.AllowUserToAddRows = false;
            this.dgvEquipements.AllowUserToDeleteRows = false;
            this.dgvEquipements.AllowUserToResizeRows = false;
            this.dgvEquipements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipements.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvEquipements.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquipements.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipements.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEquipements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Catégorie,
            this.Description,
            this.Condition});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquipements.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEquipements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEquipements.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dgvEquipements.Location = new System.Drawing.Point(3, 21);
            this.dgvEquipements.Name = "dgvEquipements";
            this.dgvEquipements.ReadOnly = true;
            this.dgvEquipements.RowHeadersVisible = false;
            this.dgvEquipements.RowHeadersWidth = 51;
            this.dgvEquipements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipements.Size = new System.Drawing.Size(846, 121);
            this.dgvEquipements.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numéro";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Numéro de série";
            this.Column2.MinimumWidth = 175;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Catégorie
            // 
            this.Catégorie.HeaderText = "Catégorie";
            this.Catégorie.MinimumWidth = 125;
            this.Catégorie.Name = "Catégorie";
            this.Catégorie.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 175;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Condition
            // 
            this.Condition.HeaderText = "Condition";
            this.Condition.MinimumWidth = 125;
            this.Condition.Name = "Condition";
            this.Condition.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btSupprimer);
            this.panel2.Controls.Add(this.btEnregistrer);
            this.panel2.Controls.Add(this.btAnnuler);
            this.panel2.Controls.Add(this.btVisualiser);
            this.panel2.Controls.Add(this.btNouveau);
            this.panel2.Location = new System.Drawing.Point(604, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 46);
            this.panel2.TabIndex = 32;
            // 
            // btSupprimer
            // 
            this.btSupprimer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSupprimer.Location = new System.Drawing.Point(-45, 0);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(111, 46);
            this.btSupprimer.TabIndex = 6;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Visible = false;
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btEnregistrer.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnregistrer.Image = global::GestionPret.Properties.Resources.ICO_Enregistrer;
            this.btEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEnregistrer.Location = new System.Drawing.Point(66, 0);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(111, 46);
            this.btEnregistrer.TabIndex = 2;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEnregistrer.UseVisualStyleBackColor = true;
            this.btEnregistrer.Visible = false;
            this.btEnregistrer.Click += new System.EventHandler(this.btEnregistrer_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Dock = System.Windows.Forms.DockStyle.Right;
            this.btAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnnuler.Image = global::GestionPret.Properties.Resources.ICO_Annuler;
            this.btAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAnnuler.Location = new System.Drawing.Point(177, 0);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(96, 46);
            this.btAnnuler.TabIndex = 3;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Visible = false;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btVisualiser
            // 
            this.btVisualiser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btVisualiser.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btVisualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVisualiser.Image = global::GestionPret.Properties.Resources.ICO_Modifier;
            this.btVisualiser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVisualiser.Location = new System.Drawing.Point(273, 0);
            this.btVisualiser.Name = "btVisualiser";
            this.btVisualiser.Size = new System.Drawing.Size(108, 46);
            this.btVisualiser.TabIndex = 5;
            this.btVisualiser.Text = "Modifier";
            this.btVisualiser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btVisualiser.UseVisualStyleBackColor = true;
            this.btVisualiser.Click += new System.EventHandler(this.btVisualiser_Click);
            // 
            // btNouveau
            // 
            this.btNouveau.Dock = System.Windows.Forms.DockStyle.Right;
            this.btNouveau.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNouveau.Image = global::GestionPret.Properties.Resources.ICO_Nouveau;
            this.btNouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNouveau.Location = new System.Drawing.Point(381, 0);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(105, 46);
            this.btNouveau.TabIndex = 4;
            this.btNouveau.Text = "Nouveau";
            this.btNouveau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNouveau.UseVisualStyleBackColor = true;
            this.btNouveau.Click += new System.EventHandler(this.btNouveau_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Filtrer par";
            // 
            // pAffichage
            // 
            this.pAffichage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pAffichage.Controls.Add(this.gbVisualiser);
            this.pAffichage.Controls.Add(this.gbAjoutCategorie);
            this.pAffichage.Controls.Add(this.gbNouvelEquipement);
            this.pAffichage.Location = new System.Drawing.Point(238, 166);
            this.pAffichage.Name = "pAffichage";
            this.pAffichage.Size = new System.Drawing.Size(852, 509);
            this.pAffichage.TabIndex = 37;
            // 
            // gbAjoutCategorie
            // 
            this.gbAjoutCategorie.Controls.Add(this.lErreurNumCategorie);
            this.gbAjoutCategorie.Controls.Add(this.btAnnulerCategorie);
            this.gbAjoutCategorie.Controls.Add(this.btSupprimerCategorie);
            this.gbAjoutCategorie.Controls.Add(this.btEnregistrerCategorie);
            this.gbAjoutCategorie.Controls.Add(this.label9);
            this.gbAjoutCategorie.Controls.Add(this.numNumeroCategorie);
            this.gbAjoutCategorie.Controls.Add(this.label8);
            this.gbAjoutCategorie.Controls.Add(this.tbNomCategorie);
            this.gbAjoutCategorie.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAjoutCategorie.Location = new System.Drawing.Point(0, 206);
            this.gbAjoutCategorie.Name = "gbAjoutCategorie";
            this.gbAjoutCategorie.Size = new System.Drawing.Size(852, 158);
            this.gbAjoutCategorie.TabIndex = 48;
            this.gbAjoutCategorie.TabStop = false;
            this.gbAjoutCategorie.Text = "Nouvelle catégorie";
            this.gbAjoutCategorie.Visible = false;
            // 
            // lErreurNumCategorie
            // 
            this.lErreurNumCategorie.AutoSize = true;
            this.lErreurNumCategorie.BackColor = System.Drawing.Color.Transparent;
            this.lErreurNumCategorie.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lErreurNumCategorie.ForeColor = System.Drawing.Color.Red;
            this.lErreurNumCategorie.Location = new System.Drawing.Point(296, 71);
            this.lErreurNumCategorie.Name = "lErreurNumCategorie";
            this.lErreurNumCategorie.Size = new System.Drawing.Size(143, 15);
            this.lErreurNumCategorie.TabIndex = 50;
            this.lErreurNumCategorie.Text = "Ce numéro est déjà utilisé";
            this.lErreurNumCategorie.Visible = false;
            // 
            // btAnnulerCategorie
            // 
            this.btAnnulerCategorie.BackColor = System.Drawing.Color.Azure;
            this.btAnnulerCategorie.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btAnnulerCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnnulerCategorie.Location = new System.Drawing.Point(498, 67);
            this.btAnnulerCategorie.Name = "btAnnulerCategorie";
            this.btAnnulerCategorie.Size = new System.Drawing.Size(111, 30);
            this.btAnnulerCategorie.TabIndex = 53;
            this.btAnnulerCategorie.Text = "Annuler";
            this.btAnnulerCategorie.UseVisualStyleBackColor = false;
            this.btAnnulerCategorie.Click += new System.EventHandler(this.btAnnulerCategorie_Click);
            // 
            // btSupprimerCategorie
            // 
            this.btSupprimerCategorie.BackColor = System.Drawing.Color.Pink;
            this.btSupprimerCategorie.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.btSupprimerCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSupprimerCategorie.Location = new System.Drawing.Point(498, 103);
            this.btSupprimerCategorie.Name = "btSupprimerCategorie";
            this.btSupprimerCategorie.Size = new System.Drawing.Size(111, 30);
            this.btSupprimerCategorie.TabIndex = 52;
            this.btSupprimerCategorie.Text = "Supprimer";
            this.btSupprimerCategorie.UseVisualStyleBackColor = false;
            this.btSupprimerCategorie.Click += new System.EventHandler(this.btSupprimerCategorie_Click);
            // 
            // btEnregistrerCategorie
            // 
            this.btEnregistrerCategorie.BackColor = System.Drawing.Color.LightCyan;
            this.btEnregistrerCategorie.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btEnregistrerCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnregistrerCategorie.Location = new System.Drawing.Point(498, 31);
            this.btEnregistrerCategorie.Name = "btEnregistrerCategorie";
            this.btEnregistrerCategorie.Size = new System.Drawing.Size(111, 30);
            this.btEnregistrerCategorie.TabIndex = 51;
            this.btEnregistrerCategorie.Text = "Enregistrer";
            this.btEnregistrerCategorie.UseVisualStyleBackColor = false;
            this.btEnregistrerCategorie.Click += new System.EventHandler(this.btEnregistrerCategorie_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 50;
            this.label9.Text = "Nom";
            // 
            // numNumeroCategorie
            // 
            this.numNumeroCategorie.BackColor = System.Drawing.Color.Azure;
            this.numNumeroCategorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numNumeroCategorie.Location = new System.Drawing.Point(299, 47);
            this.numNumeroCategorie.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumeroCategorie.Name = "numNumeroCategorie";
            this.numNumeroCategorie.Size = new System.Drawing.Size(177, 25);
            this.numNumeroCategorie.TabIndex = 49;
            this.numNumeroCategorie.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumeroCategorie.ValueChanged += new System.EventHandler(this.numNumeroCategorie_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Numéro";
            // 
            // tbNomCategorie
            // 
            this.tbNomCategorie.BackColor = System.Drawing.Color.Azure;
            this.tbNomCategorie.Location = new System.Drawing.Point(299, 89);
            this.tbNomCategorie.MaxLength = 50;
            this.tbNomCategorie.Name = "tbNomCategorie";
            this.tbNomCategorie.Size = new System.Drawing.Size(177, 25);
            this.tbNomCategorie.TabIndex = 9;
            this.tbNomCategorie.TextChanged += new System.EventHandler(this.tbNomCategorie_TextChanged);
            this.tbNomCategorie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomCategorie_KeyPress);
            // 
            // gbNouvelEquipement
            // 
            this.gbNouvelEquipement.Controls.Add(this.lChoisirCategorie);
            this.gbNouvelEquipement.Controls.Add(this.btModCategorie);
            this.gbNouvelEquipement.Controls.Add(this.lDesactiver);
            this.gbNouvelEquipement.Controls.Add(this.chkActif);
            this.gbNouvelEquipement.Controls.Add(this.label7);
            this.gbNouvelEquipement.Controls.Add(this.cbCondition);
            this.gbNouvelEquipement.Controls.Add(this.lErreurNumeroSerie);
            this.gbNouvelEquipement.Controls.Add(this.lErreurNumero);
            this.gbNouvelEquipement.Controls.Add(this.lCharacteres);
            this.gbNouvelEquipement.Controls.Add(this.tbDescription);
            this.gbNouvelEquipement.Controls.Add(this.label6);
            this.gbNouvelEquipement.Controls.Add(this.btAjoutCategorie);
            this.gbNouvelEquipement.Controls.Add(this.cbCategorie);
            this.gbNouvelEquipement.Controls.Add(this.label2);
            this.gbNouvelEquipement.Controls.Add(this.tbNumero);
            this.gbNouvelEquipement.Controls.Add(this.tbNumeroSerie);
            this.gbNouvelEquipement.Controls.Add(this.label4);
            this.gbNouvelEquipement.Controls.Add(this.label5);
            this.gbNouvelEquipement.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbNouvelEquipement.Location = new System.Drawing.Point(0, 0);
            this.gbNouvelEquipement.Name = "gbNouvelEquipement";
            this.gbNouvelEquipement.Size = new System.Drawing.Size(852, 206);
            this.gbNouvelEquipement.TabIndex = 37;
            this.gbNouvelEquipement.TabStop = false;
            this.gbNouvelEquipement.Text = "Nouvel équipement";
            // 
            // lChoisirCategorie
            // 
            this.lChoisirCategorie.AutoSize = true;
            this.lChoisirCategorie.BackColor = System.Drawing.Color.Transparent;
            this.lChoisirCategorie.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lChoisirCategorie.ForeColor = System.Drawing.Color.Red;
            this.lChoisirCategorie.Location = new System.Drawing.Point(96, 181);
            this.lChoisirCategorie.Name = "lChoisirCategorie";
            this.lChoisirCategorie.Size = new System.Drawing.Size(159, 15);
            this.lChoisirCategorie.TabIndex = 49;
            this.lChoisirCategorie.Text = "Veuillez choisir une catégorie";
            this.lChoisirCategorie.Visible = false;
            // 
            // btModCategorie
            // 
            this.btModCategorie.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btModCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModCategorie.Image = global::GestionPret.Properties.Resources.ModifierCategorie;
            this.btModCategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btModCategorie.Location = new System.Drawing.Point(292, 152);
            this.btModCategorie.Name = "btModCategorie";
            this.btModCategorie.Size = new System.Drawing.Size(31, 28);
            this.btModCategorie.TabIndex = 48;
            this.btModCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btModCategorie.UseVisualStyleBackColor = true;
            this.btModCategorie.Click += new System.EventHandler(this.btModCategorie_Click);
            // 
            // lDesactiver
            // 
            this.lDesactiver.AutoSize = true;
            this.lDesactiver.BackColor = System.Drawing.Color.Transparent;
            this.lDesactiver.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lDesactiver.ForeColor = System.Drawing.Color.Red;
            this.lDesactiver.Location = new System.Drawing.Point(120, 33);
            this.lDesactiver.Name = "lDesactiver";
            this.lDesactiver.Size = new System.Drawing.Size(356, 15);
            this.lDesactiver.TabIndex = 47;
            this.lDesactiver.Text = "L\'équipement a été désactivé car il est endommagé ou défectueux";
            this.lDesactiver.Visible = false;
            // 
            // chkActif
            // 
            this.chkActif.AutoSize = true;
            this.chkActif.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkActif.Location = new System.Drawing.Point(16, 31);
            this.chkActif.Name = "chkActif";
            this.chkActif.Size = new System.Drawing.Size(98, 21);
            this.chkActif.TabIndex = 46;
            this.chkActif.Text = "Actif?          ";
            this.chkActif.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 45;
            this.label7.Text = "Condition";
            // 
            // cbCondition
            // 
            this.cbCondition.BackColor = System.Drawing.Color.Azure;
            this.cbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCondition.FormattingEnabled = true;
            this.cbCondition.Items.AddRange(new object[] {
            "Neuf",
            "En bon état",
            "Endommagé",
            "Defectueux"});
            this.cbCondition.Location = new System.Drawing.Point(491, 153);
            this.cbCondition.Name = "cbCondition";
            this.cbCondition.Size = new System.Drawing.Size(331, 25);
            this.cbCondition.TabIndex = 44;
            this.cbCondition.SelectedIndexChanged += new System.EventHandler(this.cbCondition_SelectedIndexChanged);
            // 
            // lErreurNumeroSerie
            // 
            this.lErreurNumeroSerie.AutoSize = true;
            this.lErreurNumeroSerie.BackColor = System.Drawing.Color.Transparent;
            this.lErreurNumeroSerie.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lErreurNumeroSerie.ForeColor = System.Drawing.Color.Red;
            this.lErreurNumeroSerie.Location = new System.Drawing.Point(96, 134);
            this.lErreurNumeroSerie.Name = "lErreurNumeroSerie";
            this.lErreurNumeroSerie.Size = new System.Drawing.Size(221, 15);
            this.lErreurNumeroSerie.TabIndex = 43;
            this.lErreurNumeroSerie.Text = "Cet équipement est déjà dans le système";
            this.lErreurNumeroSerie.Visible = false;
            // 
            // lErreurNumero
            // 
            this.lErreurNumero.AutoSize = true;
            this.lErreurNumero.BackColor = System.Drawing.Color.Transparent;
            this.lErreurNumero.Font = new System.Drawing.Font("Segoe UI", 8.75F);
            this.lErreurNumero.ForeColor = System.Drawing.Color.Red;
            this.lErreurNumero.Location = new System.Drawing.Point(96, 91);
            this.lErreurNumero.Name = "lErreurNumero";
            this.lErreurNumero.Size = new System.Drawing.Size(143, 15);
            this.lErreurNumero.TabIndex = 42;
            this.lErreurNumero.Text = "Ce numéro est déjà utilisé";
            this.lErreurNumero.Visible = false;
            // 
            // lCharacteres
            // 
            this.lCharacteres.Location = new System.Drawing.Point(669, 59);
            this.lCharacteres.Name = "lCharacteres";
            this.lCharacteres.Size = new System.Drawing.Size(153, 17);
            this.lCharacteres.TabIndex = 41;
            this.lCharacteres.Text = "Charactères restant : 150";
            this.lCharacteres.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.Azure;
            this.tbDescription.Location = new System.Drawing.Point(421, 79);
            this.tbDescription.MaxLength = 150;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(401, 60);
            this.tbDescription.TabIndex = 40;
            this.tbDescription.TextChanged += new System.EventHandler(this.tbDescription_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Description";
            // 
            // btAjoutCategorie
            // 
            this.btAjoutCategorie.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btAjoutCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAjoutCategorie.Image = ((System.Drawing.Image)(resources.GetObject("btAjoutCategorie.Image")));
            this.btAjoutCategorie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAjoutCategorie.Location = new System.Drawing.Point(329, 152);
            this.btAjoutCategorie.Name = "btAjoutCategorie";
            this.btAjoutCategorie.Size = new System.Drawing.Size(31, 28);
            this.btAjoutCategorie.TabIndex = 6;
            this.btAjoutCategorie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAjoutCategorie.UseVisualStyleBackColor = true;
            this.btAjoutCategorie.Click += new System.EventHandler(this.btAjoutCategorie_Click);
            // 
            // cbCategorie
            // 
            this.cbCategorie.BackColor = System.Drawing.Color.Azure;
            this.cbCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(99, 153);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(187, 25);
            this.cbCategorie.TabIndex = 38;
            this.cbCategorie.SelectedIndexChanged += new System.EventHandler(this.cbCategorie_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Numéro";
            // 
            // tbNumero
            // 
            this.tbNumero.BackColor = System.Drawing.Color.Azure;
            this.tbNumero.Location = new System.Drawing.Point(99, 66);
            this.tbNumero.MaxLength = 50;
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(261, 25);
            this.tbNumero.TabIndex = 9;
            this.tbNumero.TextChanged += new System.EventHandler(this.tbNumero_TextChanged);
            this.tbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumero_KeyPress);
            // 
            // tbNumeroSerie
            // 
            this.tbNumeroSerie.BackColor = System.Drawing.Color.Azure;
            this.tbNumeroSerie.Location = new System.Drawing.Point(99, 109);
            this.tbNumeroSerie.MaxLength = 150;
            this.tbNumeroSerie.Name = "tbNumeroSerie";
            this.tbNumeroSerie.Size = new System.Drawing.Size(261, 25);
            this.tbNumeroSerie.TabIndex = 10;
            this.tbNumeroSerie.TextChanged += new System.EventHandler(this.tbNumeroSerie_TextChanged);
            this.tbNumeroSerie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeroSerie_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "No de série";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Catégorie";
            // 
            // cbTypeEquipement
            // 
            this.cbTypeEquipement.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTypeEquipement.BackColor = System.Drawing.Color.Azure;
            this.cbTypeEquipement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeEquipement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTypeEquipement.FormattingEnabled = true;
            this.cbTypeEquipement.Items.AddRange(new object[] {
            "Tous les équipements",
            "Équipements disponibles",
            "Équipements empruntés"});
            this.cbTypeEquipement.Location = new System.Drawing.Point(316, 82);
            this.cbTypeEquipement.Name = "cbTypeEquipement";
            this.cbTypeEquipement.Size = new System.Drawing.Size(282, 25);
            this.cbTypeEquipement.TabIndex = 38;
            this.cbTypeEquipement.SelectedIndexChanged += new System.EventHandler(this.cbTypeEquipement_SelectedIndexChanged);
            // 
            // Equipements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.cbTypeEquipement);
            this.Controls.Add(this.pAffichage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Equipements";
            this.Size = new System.Drawing.Size(1281, 730);
            this.gbVisualiser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipements)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pAffichage.ResumeLayout(false);
            this.gbAjoutCategorie.ResumeLayout(false);
            this.gbAjoutCategorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroCategorie)).EndInit();
            this.gbNouvelEquipement.ResumeLayout(false);
            this.gbNouvelEquipement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVisualiser;
        private System.Windows.Forms.DataGridView dgvEquipements;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btVisualiser;
        private System.Windows.Forms.Button btNouveau;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pAffichage;
        private System.Windows.Forms.GroupBox gbNouvelEquipement;
        private System.Windows.Forms.Label lCharacteres;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAjoutCategorie;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.TextBox tbNumeroSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTypeEquipement;
        private System.Windows.Forms.Label lErreurNumero;
        private System.Windows.Forms.Label lErreurNumeroSerie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCondition;
        private System.Windows.Forms.CheckBox chkActif;
        private System.Windows.Forms.Label lDesactiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catégorie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condition;
        private System.Windows.Forms.GroupBox gbAjoutCategorie;
        private System.Windows.Forms.TextBox tbNomCategorie;
        private System.Windows.Forms.NumericUpDown numNumeroCategorie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btModCategorie;
        private System.Windows.Forms.Button btEnregistrerCategorie;
        private System.Windows.Forms.Button btSupprimerCategorie;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btAnnulerCategorie;
        private System.Windows.Forms.Label lChoisirCategorie;
        private System.Windows.Forms.Label lErreurNumCategorie;
    }
}
