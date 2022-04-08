
namespace GestionPret.PN
{
    partial class Utilisateur
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
            this.tbUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMdp1 = new System.Windows.Forms.TextBox();
            this.erreur = new System.Windows.Forms.Label();
            this.erreurNom = new System.Windows.Forms.Label();
            this.erreurPrenom = new System.Windows.Forms.Label();
            this.erreurUser = new System.Windows.Forms.Label();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.labelMdp = new System.Windows.Forms.Label();
            this.tbMdp2 = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listUtili = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.id_utilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_utilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom_utilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listUtili)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.Azure;
            this.tbUser.Location = new System.Drawing.Point(77, 70);
            this.tbUser.MaxLength = 15;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(175, 25);
            this.tbUser.TabIndex = 25;
            this.tbUser.Enter += new System.EventHandler(this.tbUser_Enter);
            this.tbUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUser_KeyPress);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(74, 50);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(80, 17);
            this.labelUser.TabIndex = 26;
            this.labelUser.Text = "ID utilisateur";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.erreur);
            this.groupBox1.Controls.Add(this.erreurNom);
            this.groupBox1.Controls.Add(this.erreurPrenom);
            this.groupBox1.Controls.Add(this.erreurUser);
            this.groupBox1.Controls.Add(this.btAnnuler);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.labelMdp);
            this.groupBox1.Controls.Add(this.tbMdp2);
            this.groupBox1.Controls.Add(this.tbMdp1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelNom);
            this.groupBox1.Controls.Add(this.tbNom);
            this.groupBox1.Controls.Add(this.labelPrenom);
            this.groupBox1.Controls.Add(this.tbPrenom);
            this.groupBox1.Controls.Add(this.labelUser);
            this.groupBox1.Controls.Add(this.tbUser);
            this.groupBox1.Location = new System.Drawing.Point(217, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 541);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajouter un utilisateur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Mot de passe";
            // 
            // tbMdp1
            // 
            this.tbMdp1.BackColor = System.Drawing.Color.Azure;
            this.tbMdp1.Location = new System.Drawing.Point(77, 300);
            this.tbMdp1.MaxLength = 300;
            this.tbMdp1.Name = "tbMdp1";
            this.tbMdp1.PasswordChar = '•';
            this.tbMdp1.Size = new System.Drawing.Size(175, 25);
            this.tbMdp1.TabIndex = 30;
            this.tbMdp1.Enter += new System.EventHandler(this.tbMdp1_Enter);
            // 
            // erreur
            // 
            this.erreur.AutoSize = true;
            this.erreur.ForeColor = System.Drawing.Color.Red;
            this.erreur.Location = new System.Drawing.Point(74, 385);
            this.erreur.Name = "erreur";
            this.erreur.Size = new System.Drawing.Size(43, 17);
            this.erreur.TabIndex = 38;
            this.erreur.Text = "label3";
            // 
            // erreurNom
            // 
            this.erreurNom.AutoSize = true;
            this.erreurNom.ForeColor = System.Drawing.Color.Red;
            this.erreurNom.Location = new System.Drawing.Point(74, 252);
            this.erreurNom.Name = "erreurNom";
            this.erreurNom.Size = new System.Drawing.Size(43, 17);
            this.erreurNom.TabIndex = 37;
            this.erreurNom.Text = "label3";
            // 
            // erreurPrenom
            // 
            this.erreurPrenom.AutoSize = true;
            this.erreurPrenom.ForeColor = System.Drawing.Color.Red;
            this.erreurPrenom.Location = new System.Drawing.Point(77, 172);
            this.erreurPrenom.Name = "erreurPrenom";
            this.erreurPrenom.Size = new System.Drawing.Size(43, 17);
            this.erreurPrenom.TabIndex = 36;
            this.erreurPrenom.Text = "label3";
            // 
            // erreurUser
            // 
            this.erreurUser.AutoSize = true;
            this.erreurUser.ForeColor = System.Drawing.Color.Red;
            this.erreurUser.Location = new System.Drawing.Point(74, 98);
            this.erreurUser.Name = "erreurUser";
            this.erreurUser.Size = new System.Drawing.Size(43, 17);
            this.erreurUser.TabIndex = 35;
            this.erreurUser.Text = "label2";
            // 
            // btAnnuler
            // 
            this.btAnnuler.BackColor = System.Drawing.Color.Transparent;
            this.btAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAnnuler.Location = new System.Drawing.Point(187, 430);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(129, 46);
            this.btAnnuler.TabIndex = 34;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = false;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Transparent;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAdd.Location = new System.Drawing.Point(34, 430);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(129, 46);
            this.btAdd.TabIndex = 33;
            this.btAdd.Text = "Ajouter";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Location = new System.Drawing.Point(74, 337);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(164, 17);
            this.labelMdp.TabIndex = 32;
            this.labelMdp.Text = "Confirmer le mot de passe";
            // 
            // tbMdp2
            // 
            this.tbMdp2.BackColor = System.Drawing.Color.Azure;
            this.tbMdp2.Location = new System.Drawing.Point(77, 357);
            this.tbMdp2.MaxLength = 300;
            this.tbMdp2.Name = "tbMdp2";
            this.tbMdp2.PasswordChar = '•';
            this.tbMdp2.Size = new System.Drawing.Size(175, 25);
            this.tbMdp2.TabIndex = 31;
            this.tbMdp2.Enter += new System.EventHandler(this.tbMdp_Enter);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(74, 204);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(37, 17);
            this.labelNom.TabIndex = 30;
            this.labelNom.Text = "Nom";
            // 
            // tbNom
            // 
            this.tbNom.BackColor = System.Drawing.Color.Azure;
            this.tbNom.Location = new System.Drawing.Point(77, 224);
            this.tbNom.MaxLength = 50;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(175, 25);
            this.tbNom.TabIndex = 29;
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
            this.tbNom.Enter += new System.EventHandler(this.tbNom_Enter);
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(74, 124);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(53, 17);
            this.labelPrenom.TabIndex = 28;
            this.labelPrenom.Text = "Prénom";
            // 
            // tbPrenom
            // 
            this.tbPrenom.BackColor = System.Drawing.Color.Azure;
            this.tbPrenom.Location = new System.Drawing.Point(77, 144);
            this.tbPrenom.MaxLength = 50;
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(175, 25);
            this.tbPrenom.TabIndex = 27;
            this.tbPrenom.TextChanged += new System.EventHandler(this.tbPrenom_TextChanged);
            this.tbPrenom.Enter += new System.EventHandler(this.tbPrenom_Enter);
            // 
            // listUtili
            // 
            this.listUtili.AllowUserToAddRows = false;
            this.listUtili.AllowUserToDeleteRows = false;
            this.listUtili.BackgroundColor = System.Drawing.Color.Azure;
            this.listUtili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listUtili.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_utilisateur,
            this.nom_utilisateur,
            this.prenom_utilisateur});
            this.listUtili.Location = new System.Drawing.Point(748, 97);
            this.listUtili.Name = "listUtili";
            this.listUtili.ReadOnly = true;
            this.listUtili.RowHeadersVisible = false;
            this.listUtili.Size = new System.Drawing.Size(301, 522);
            this.listUtili.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(745, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Liste des utilisateurs";
            // 
            // id_utilisateur
            // 
            this.id_utilisateur.HeaderText = "ID";
            this.id_utilisateur.Name = "id_utilisateur";
            this.id_utilisateur.ReadOnly = true;
            // 
            // nom_utilisateur
            // 
            this.nom_utilisateur.HeaderText = "Nom";
            this.nom_utilisateur.Name = "nom_utilisateur";
            this.nom_utilisateur.ReadOnly = true;
            // 
            // prenom_utilisateur
            // 
            this.prenom_utilisateur.HeaderText = "Prénom";
            this.prenom_utilisateur.Name = "prenom_utilisateur";
            this.prenom_utilisateur.ReadOnly = true;
            // 
            // Utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listUtili);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Utilisateur";
            this.Size = new System.Drawing.Size(1281, 730);
            this.Load += new System.EventHandler(this.Utilisateur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listUtili)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.TextBox tbMdp2;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Label erreur;
        private System.Windows.Forms.Label erreurNom;
        private System.Windows.Forms.Label erreurPrenom;
        private System.Windows.Forms.Label erreurUser;
        private System.Windows.Forms.DataGridView listUtili;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMdp1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_utilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_utilisateur;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom_utilisateur;
    }
}
