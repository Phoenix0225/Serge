
namespace GestionPret.PN
{
    partial class Clients
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbTypesClients = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCodeClient = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDepartement = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskTelephone = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btVisualiser = new System.Windows.Forms.Button();
            this.btNouveau = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btEnregistrer = new System.Windows.Forms.Button();
            this.tbMatrSel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvListeEmprunts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEmprunts)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTypesClients
            // 
            this.cbTypesClients.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTypesClients.BackColor = System.Drawing.Color.Azure;
            this.cbTypesClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypesClients.Enabled = false;
            this.cbTypesClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTypesClients.FormattingEnabled = true;
            this.cbTypesClients.Location = new System.Drawing.Point(331, 121);
            this.cbTypesClients.Name = "cbTypesClients";
            this.cbTypesClients.Size = new System.Drawing.Size(224, 25);
            this.cbTypesClients.TabIndex = 4;
            this.cbTypesClients.SelectedIndexChanged += new System.EventHandler(this.cbTypesClients_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1281, 26);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type de client";
            // 
            // tbCodeClient
            // 
            this.tbCodeClient.BackColor = System.Drawing.Color.Azure;
            this.tbCodeClient.Enabled = false;
            this.tbCodeClient.Location = new System.Drawing.Point(102, 33);
            this.tbCodeClient.MaxLength = 20;
            this.tbCodeClient.Name = "tbCodeClient";
            this.tbCodeClient.Size = new System.Drawing.Size(175, 25);
            this.tbCodeClient.TabIndex = 9;
            this.tbCodeClient.TextChanged += new System.EventHandler(this.tbCodeClient_TextChanged);
            this.tbCodeClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodeClient_KeyPress);
            // 
            // tbPrenom
            // 
            this.tbPrenom.BackColor = System.Drawing.Color.Azure;
            this.tbPrenom.Enabled = false;
            this.tbPrenom.Location = new System.Drawing.Point(102, 80);
            this.tbPrenom.MaxLength = 75;
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(283, 25);
            this.tbPrenom.TabIndex = 10;
            this.tbPrenom.TextChanged += new System.EventHandler(this.tbPrenom_TextChanged);
            // 
            // tbNom
            // 
            this.tbNom.BackColor = System.Drawing.Color.Azure;
            this.tbNom.Enabled = false;
            this.tbNom.Location = new System.Drawing.Point(102, 123);
            this.tbNom.MaxLength = 75;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(283, 25);
            this.tbNom.TabIndex = 11;
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Matricule";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nom";
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
            this.tbDepartement.TextChanged += new System.EventHandler(this.tbDepartement_TextChanged);
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
            // mskTelephone
            // 
            this.mskTelephone.BackColor = System.Drawing.Color.Azure;
            this.mskTelephone.Enabled = false;
            this.mskTelephone.Location = new System.Drawing.Point(134, 70);
            this.mskTelephone.Mask = "(000) 000-0000";
            this.mskTelephone.Name = "mskTelephone";
            this.mskTelephone.Size = new System.Drawing.Size(175, 25);
            this.mskTelephone.TabIndex = 17;
            this.mskTelephone.TextChanged += new System.EventHandler(this.mskTelephone_TextChanged);
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
            // tbCourriel
            // 
            this.tbCourriel.BackColor = System.Drawing.Color.Azure;
            this.tbCourriel.Enabled = false;
            this.tbCourriel.Location = new System.Drawing.Point(134, 120);
            this.tbCourriel.MaxLength = 150;
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(280, 25);
            this.tbCourriel.TabIndex = 19;
            this.tbCourriel.TextChanged += new System.EventHandler(this.tbCourriel_TextChanged);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbCodeClient);
            this.groupBox1.Controls.Add(this.tbPrenom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(229, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 165);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identification du client";
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
            this.groupBox2.Location = new System.Drawing.Point(670, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 165);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Coordonnées";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btVisualiser);
            this.panel2.Controls.Add(this.btNouveau);
            this.panel2.Controls.Add(this.btAnnuler);
            this.panel2.Controls.Add(this.btEnregistrer);
            this.panel2.Location = new System.Drawing.Point(664, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 46);
            this.panel2.TabIndex = 23;
            // 
            // btVisualiser
            // 
            this.btVisualiser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btVisualiser.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btVisualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVisualiser.Image = global::GestionPret.Properties.Resources.ICO_Modifier;
            this.btVisualiser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVisualiser.Location = new System.Drawing.Point(6, 0);
            this.btVisualiser.Name = "btVisualiser";
            this.btVisualiser.Size = new System.Drawing.Size(108, 46);
            this.btVisualiser.TabIndex = 5;
            this.btVisualiser.Text = "Consulter";
            this.btVisualiser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btVisualiser.UseVisualStyleBackColor = true;
            this.btVisualiser.Click += new System.EventHandler(this.BtVisualiser_Click);
            // 
            // btNouveau
            // 
            this.btNouveau.Dock = System.Windows.Forms.DockStyle.Right;
            this.btNouveau.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btNouveau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNouveau.Image = global::GestionPret.Properties.Resources.ICO_Nouveau;
            this.btNouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNouveau.Location = new System.Drawing.Point(114, 0);
            this.btNouveau.Name = "btNouveau";
            this.btNouveau.Size = new System.Drawing.Size(105, 46);
            this.btNouveau.TabIndex = 4;
            this.btNouveau.Text = "Nouveau";
            this.btNouveau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNouveau.UseVisualStyleBackColor = true;
            this.btNouveau.Click += new System.EventHandler(this.BtNouveau_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Dock = System.Windows.Forms.DockStyle.Right;
            this.btAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAnnuler.Image = global::GestionPret.Properties.Resources.ICO_Annuler;
            this.btAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAnnuler.Location = new System.Drawing.Point(219, 0);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(96, 46);
            this.btAnnuler.TabIndex = 3;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Visible = false;
            this.btAnnuler.Click += new System.EventHandler(this.BtAnnuler_Click);
            // 
            // btEnregistrer
            // 
            this.btEnregistrer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btEnregistrer.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise;
            this.btEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnregistrer.Image = global::GestionPret.Properties.Resources.ICO_Enregistrer;
            this.btEnregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEnregistrer.Location = new System.Drawing.Point(315, 0);
            this.btEnregistrer.Name = "btEnregistrer";
            this.btEnregistrer.Size = new System.Drawing.Size(111, 46);
            this.btEnregistrer.TabIndex = 2;
            this.btEnregistrer.Text = "Enregistrer";
            this.btEnregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEnregistrer.UseVisualStyleBackColor = true;
            this.btEnregistrer.Visible = false;
            this.btEnregistrer.Click += new System.EventHandler(this.BtEnregistrer_Click);
            // 
            // tbMatrSel
            // 
            this.tbMatrSel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbMatrSel.BackColor = System.Drawing.Color.Azure;
            this.tbMatrSel.Location = new System.Drawing.Point(331, 79);
            this.tbMatrSel.MaxLength = 20;
            this.tbMatrSel.Name = "tbMatrSel";
            this.tbMatrSel.Size = new System.Drawing.Size(175, 25);
            this.tbMatrSel.TabIndex = 24;
            this.tbMatrSel.TextChanged += new System.EventHandler(this.tbMatrSel_TextChanged);
            this.tbMatrSel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMatrSel_KeyPress);
            this.tbMatrSel.Leave += new System.EventHandler(this.TbMatrSel_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(235, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "No Client";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.dgvListeEmprunts);
            this.groupBox3.Location = new System.Drawing.Point(232, 361);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(858, 282);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emprunts en cours";
            // 
            // dgvListeEmprunts
            // 
            this.dgvListeEmprunts.AllowUserToAddRows = false;
            this.dgvListeEmprunts.AllowUserToDeleteRows = false;
            this.dgvListeEmprunts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListeEmprunts.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvListeEmprunts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListeEmprunts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListeEmprunts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListeEmprunts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeEmprunts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListeEmprunts.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListeEmprunts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListeEmprunts.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dgvListeEmprunts.Location = new System.Drawing.Point(3, 21);
            this.dgvListeEmprunts.Name = "dgvListeEmprunts";
            this.dgvListeEmprunts.ReadOnly = true;
            this.dgvListeEmprunts.RowHeadersVisible = false;
            this.dgvListeEmprunts.Size = new System.Drawing.Size(852, 258);
            this.dgvListeEmprunts.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No Emprunt";
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
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Équipement";
            this.Column3.MinimumWidth = 250;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "État";
            this.Column4.MinimumWidth = 175;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date de retour prévu";
            this.Column5.MinimumWidth = 125;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbMatrSel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbTypesClients);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Clients";
            this.Size = new System.Drawing.Size(1281, 730);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeEmprunts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTypesClients;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCodeClient;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDepartement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskTelephone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btVisualiser;
        private System.Windows.Forms.Button btNouveau;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btEnregistrer;
        private System.Windows.Forms.TextBox tbMatrSel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvListeEmprunts;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
