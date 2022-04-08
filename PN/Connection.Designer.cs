
namespace GestionPret.PN
{
    partial class Connection
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pToolBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btCnx = new System.Windows.Forms.Button();
            this.erreur = new System.Windows.Forms.Label();
            this.erreurUser = new System.Windows.Forms.Label();
            this.pToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pToolBar
            // 
            this.pToolBar.BackColor = System.Drawing.Color.LightCyan;
            this.pToolBar.Controls.Add(this.label1);
            this.pToolBar.Controls.Add(this.btClose);
            this.pToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pToolBar.Location = new System.Drawing.Point(0, 0);
            this.pToolBar.Margin = new System.Windows.Forms.Padding(4);
            this.pToolBar.Name = "pToolBar";
            this.pToolBar.Size = new System.Drawing.Size(607, 35);
            this.pToolBar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serge | Connexion";
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.LightCyan;
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Image = global::GestionPret.Properties.Resources.close;
            this.btClose.Location = new System.Drawing.Point(567, 0);
            this.btClose.Margin = new System.Windows.Forms.Padding(4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(40, 35);
            this.btClose.TabIndex = 0;
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(141, 128);
            this.user.MaxLength = 15;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(231, 27);
            this.user.TabIndex = 2;
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_KeyPress);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(141, 216);
            this.password.MaxLength = 300;
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(231, 27);
            this.password.TabIndex = 3;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(137, 105);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(93, 20);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "ID utilisateur";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(137, 193);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(98, 20);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Mot de passe";
            // 
            // btCnx
            // 
            this.btCnx.BackgroundImage = global::GestionPret.Properties.Resources.cnx;
            this.btCnx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCnx.Location = new System.Drawing.Point(432, 135);
            this.btCnx.Name = "btCnx";
            this.btCnx.Size = new System.Drawing.Size(100, 99);
            this.btCnx.TabIndex = 6;
            this.btCnx.UseVisualStyleBackColor = true;
            this.btCnx.Click += new System.EventHandler(this.btCnx_Click);
            // 
            // erreur
            // 
            this.erreur.AutoSize = true;
            this.erreur.ForeColor = System.Drawing.Color.Red;
            this.erreur.Location = new System.Drawing.Point(141, 262);
            this.erreur.Name = "erreur";
            this.erreur.Size = new System.Drawing.Size(50, 20);
            this.erreur.TabIndex = 7;
            this.erreur.Text = "label2";
            // 
            // erreurUser
            // 
            this.erreurUser.AutoSize = true;
            this.erreurUser.ForeColor = System.Drawing.Color.Red;
            this.erreurUser.Location = new System.Drawing.Point(141, 158);
            this.erreurUser.Name = "erreurUser";
            this.erreurUser.Size = new System.Drawing.Size(50, 20);
            this.erreurUser.TabIndex = 8;
            this.erreurUser.Text = "label2";
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(607, 326);
            this.Controls.Add(this.erreurUser);
            this.Controls.Add(this.erreur);
            this.Controls.Add(this.btCnx);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.pToolBar);
            this.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.Connection_Load);
            this.pToolBar.ResumeLayout(false);
            this.pToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pToolBar;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button btCnx;
        private System.Windows.Forms.Label erreur;
        private System.Windows.Forms.Label erreurUser;
    }
}