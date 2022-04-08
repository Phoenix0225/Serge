
namespace GestionPret.PN
{
    partial class AddModLocation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbCodeLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodeClient = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDepartement = new System.Windows.Forms.TextBox();
            this.mskTelephone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbAddRow = new System.Windows.Forms.PictureBox();
            this.dgvEquipementsLocations = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEtat = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDateRetourPrevu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEtatRetour = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colReprendre = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colCodeRetour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateRetour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFraisRetard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btReprendre = new System.Windows.Forms.Button();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.dtpDateDebut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pbEnleverLigne = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipementsLocations)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnleverLigne)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCodeLocation
            // 
            this.tbCodeLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbCodeLocation.BackColor = System.Drawing.Color.Azure;
            this.tbCodeLocation.Enabled = false;
            this.tbCodeLocation.Location = new System.Drawing.Point(85, 30);
            this.tbCodeLocation.Name = "tbCodeLocation";
            this.tbCodeLocation.Size = new System.Drawing.Size(175, 25);
            this.tbCodeLocation.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Code";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCodeClient);
            this.groupBox1.Controls.Add(this.tbPrenom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(34, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 165);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identification du client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Matricule";
            // 
            // tbCodeClient
            // 
            this.tbCodeClient.BackColor = System.Drawing.Color.Azure;
            this.tbCodeClient.Location = new System.Drawing.Point(102, 33);
            this.tbCodeClient.MaxLength = 20;
            this.tbCodeClient.Name = "tbCodeClient";
            this.tbCodeClient.Size = new System.Drawing.Size(175, 25);
            this.tbCodeClient.TabIndex = 9;
            this.tbCodeClient.Leave += new System.EventHandler(this.TbCodeClient_Leave);
            // 
            // tbPrenom
            // 
            this.tbPrenom.BackColor = System.Drawing.Color.Azure;
            this.tbPrenom.Enabled = false;
            this.tbPrenom.Location = new System.Drawing.Point(102, 80);
            this.tbPrenom.MaxLength = 75;
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(286, 25);
            this.tbPrenom.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Prénom";
            // 
            // tbNom
            // 
            this.tbNom.BackColor = System.Drawing.Color.Azure;
            this.tbNom.Enabled = false;
            this.tbNom.Location = new System.Drawing.Point(102, 123);
            this.tbNom.MaxLength = 75;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(286, 25);
            this.tbNom.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nom";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.tbDepartement);
            this.groupBox2.Controls.Add(this.mskTelephone);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbCourriel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(466, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 165);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coordonnées";
            // 
            // tbDepartement
            // 
            this.tbDepartement.BackColor = System.Drawing.Color.Azure;
            this.tbDepartement.Enabled = false;
            this.tbDepartement.Location = new System.Drawing.Point(134, 25);
            this.tbDepartement.MaxLength = 100;
            this.tbDepartement.Name = "tbDepartement";
            this.tbDepartement.Size = new System.Drawing.Size(175, 25);
            this.tbDepartement.TabIndex = 15;
            // 
            // mskTelephone
            // 
            this.mskTelephone.BackColor = System.Drawing.Color.Azure;
            this.mskTelephone.Enabled = false;
            this.mskTelephone.Location = new System.Drawing.Point(134, 70);
            this.mskTelephone.Mask = "(000) 000-0000";
            this.mskTelephone.Name = "mskTelephone";
            this.mskTelephone.Size = new System.Drawing.Size(175, 25);
            this.mskTelephone.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Courriel";
            // 
            // tbCourriel
            // 
            this.tbCourriel.BackColor = System.Drawing.Color.Azure;
            this.tbCourriel.Enabled = false;
            this.tbCourriel.Location = new System.Drawing.Point(134, 120);
            this.tbCourriel.MaxLength = 150;
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(280, 25);
            this.tbCourriel.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Téléphone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Département";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.pbEnleverLigne);
            this.groupBox3.Controls.Add(this.pbAddRow);
            this.groupBox3.Controls.Add(this.dgvEquipementsLocations);
            this.groupBox3.Location = new System.Drawing.Point(31, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1216, 405);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste des items";
            // 
            // pbAddRow
            // 
            this.pbAddRow.Image = global::GestionPret.Properties.Resources.add;
            this.pbAddRow.Location = new System.Drawing.Point(105, 1);
            this.pbAddRow.Name = "pbAddRow";
            this.pbAddRow.Size = new System.Drawing.Size(22, 23);
            this.pbAddRow.TabIndex = 37;
            this.pbAddRow.TabStop = false;
            this.pbAddRow.Click += new System.EventHandler(this.PbAddRow_Click);
            // 
            // dgvEquipementsLocations
            // 
            this.dgvEquipementsLocations.AllowUserToAddRows = false;
            this.dgvEquipementsLocations.AllowUserToResizeColumns = false;
            this.dgvEquipementsLocations.AllowUserToResizeRows = false;
            this.dgvEquipementsLocations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipementsLocations.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvEquipementsLocations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEquipementsLocations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipementsLocations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEquipementsLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipementsLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colDescription,
            this.colEtat,
            this.colDateRetourPrevu,
            this.colEtatRetour,
            this.colReprendre,
            this.colCodeRetour,
            this.colDateRetour,
            this.colFraisRetard});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEquipementsLocations.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvEquipementsLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEquipementsLocations.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dgvEquipementsLocations.Location = new System.Drawing.Point(3, 21);
            this.dgvEquipementsLocations.MultiSelect = false;
            this.dgvEquipementsLocations.Name = "dgvEquipementsLocations";
            this.dgvEquipementsLocations.RowHeadersVisible = false;
            this.dgvEquipementsLocations.Size = new System.Drawing.Size(1210, 381);
            this.dgvEquipementsLocations.TabIndex = 1;
            this.dgvEquipementsLocations.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEquipementsLocations_CellEndEdit);
            this.dgvEquipementsLocations.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEquipementsLocations_CellLeave);
            this.dgvEquipementsLocations.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvEquipementsLocations_RowsAdded);
            // 
            // colCode
            // 
            this.colCode.HeaderText = "Code équipement";
            this.colCode.MaxInputLength = 50;
            this.colCode.Name = "colCode";
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Description";
            this.colDescription.MinimumWidth = 200;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colEtat
            // 
            this.colEtat.HeaderText = "État";
            this.colEtat.Items.AddRange(new object[] {
            "1 - Neuf",
            "2 - En bon état",
            "3 - Endommagé",
            "4 - Défectueux"});
            this.colEtat.MinimumWidth = 150;
            this.colEtat.Name = "colEtat";
            this.colEtat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEtat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colDateRetourPrevu
            // 
            dataGridViewCellStyle10.Format = "g";
            dataGridViewCellStyle10.NullValue = null;
            this.colDateRetourPrevu.DefaultCellStyle = dataGridViewCellStyle10;
            this.colDateRetourPrevu.HeaderText = "Date prévue";
            this.colDateRetourPrevu.MaxInputLength = 45;
            this.colDateRetourPrevu.Name = "colDateRetourPrevu";
            // 
            // colEtatRetour
            // 
            this.colEtatRetour.HeaderText = "État au retour";
            this.colEtatRetour.Items.AddRange(new object[] {
            "1 - Neuf",
            "2 - En bon état",
            "3 - Endommagé",
            "4 - Défectueux"});
            this.colEtatRetour.MinimumWidth = 150;
            this.colEtatRetour.Name = "colEtatRetour";
            this.colEtatRetour.ReadOnly = true;
            this.colEtatRetour.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEtatRetour.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colEtatRetour.Visible = false;
            // 
            // colReprendre
            // 
            this.colReprendre.HeaderText = "Reprendre";
            this.colReprendre.Name = "colReprendre";
            this.colReprendre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colReprendre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colReprendre.Visible = false;
            // 
            // colCodeRetour
            // 
            this.colCodeRetour.HeaderText = "Code retour";
            this.colCodeRetour.Name = "colCodeRetour";
            this.colCodeRetour.ReadOnly = true;
            this.colCodeRetour.Visible = false;
            // 
            // colDateRetour
            // 
            dataGridViewCellStyle11.Format = "g";
            dataGridViewCellStyle11.NullValue = null;
            this.colDateRetour.DefaultCellStyle = dataGridViewCellStyle11;
            this.colDateRetour.HeaderText = "Date retour";
            this.colDateRetour.Name = "colDateRetour";
            this.colDateRetour.ReadOnly = true;
            this.colDateRetour.Visible = false;
            // 
            // colFraisRetard
            // 
            this.colFraisRetard.HeaderText = "Frais retard";
            this.colFraisRetard.Name = "colFraisRetard";
            this.colFraisRetard.ReadOnly = true;
            this.colFraisRetard.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btReprendre);
            this.panel2.Controls.Add(this.btEnregistrer);
            this.panel2.Controls.Add(this.btAnnuler);
            this.panel2.Location = new System.Drawing.Point(935, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 46);
            this.panel2.TabIndex = 34;
            // 
            // btReprendre
            // 
            this.btReprendre.Dock = System.Windows.Forms.DockStyle.Right;
            this.btReprendre.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btReprendre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReprendre.Image = global::GestionPret.Properties.Resources.ICO_Enregistrer;
            this.btReprendre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReprendre.Location = new System.Drawing.Point(6, 0);
            this.btReprendre.Name = "btReprendre";
            this.btReprendre.Size = new System.Drawing.Size(111, 46);
            this.btReprendre.TabIndex = 4;
            this.btReprendre.Text = "Reprendre";
            this.btReprendre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btReprendre.UseVisualStyleBackColor = true;
            this.btReprendre.Visible = false;
            this.btReprendre.Click += new System.EventHandler(this.BtReprendre_Click);
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btEnregistrer.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnregistrer.Image = global::GestionPret.Properties.Resources.ICO_Enregistrer;
            this.btEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEnregistrer.Location = new System.Drawing.Point(117, 0);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(111, 46);
            this.btEnregistrer.TabIndex = 2;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEnregistrer.UseVisualStyleBackColor = true;
            this.btEnregistrer.Click += new System.EventHandler(this.BtEnregistrer_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Dock = System.Windows.Forms.DockStyle.Right;
            this.btAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnnuler.Image = global::GestionPret.Properties.Resources.ICO_Annuler;
            this.btAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAnnuler.Location = new System.Drawing.Point(228, 0);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(96, 46);
            this.btAnnuler.TabIndex = 3;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.BtAnnuler_Click);
            // 
            // dtpDateDebut
            // 
            this.dtpDateDebut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDateDebut.CustomFormat = "yyyy-mm-dd HH:mm";
            this.dtpDateDebut.Enabled = false;
            this.dtpDateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateDebut.Location = new System.Drawing.Point(719, 27);
            this.dtpDateDebut.Name = "dtpDateDebut";
            this.dtpDateDebut.Size = new System.Drawing.Size(167, 25);
            this.dtpDateDebut.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Date de la location";
            // 
            // pbEnleverLigne
            // 
            this.pbEnleverLigne.Image = global::GestionPret.Properties.Resources.ICO_Annuler;
            this.pbEnleverLigne.Location = new System.Drawing.Point(133, 1);
            this.pbEnleverLigne.Name = "pbEnleverLigne";
            this.pbEnleverLigne.Size = new System.Drawing.Size(22, 23);
            this.pbEnleverLigne.TabIndex = 38;
            this.pbEnleverLigne.TabStop = false;
            this.pbEnleverLigne.Click += new System.EventHandler(this.PbEnleverLigne_Click);
            // 
            // AddModLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateDebut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCodeLocation);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddModLocation";
            this.Size = new System.Drawing.Size(1281, 689);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipementsLocations)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnleverLigne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodeLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodeClient;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbDepartement;
        private System.Windows.Forms.MaskedTextBox mskTelephone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvEquipementsLocations;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btReprendre;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.DateTimePicker dtpDateDebut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbAddRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn colEtat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateRetourPrevu;
        private System.Windows.Forms.DataGridViewComboBoxColumn colEtatRetour;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colReprendre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodeRetour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateRetour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFraisRetard;
        private System.Windows.Forms.PictureBox pbEnleverLigne;
    }
}
