namespace Gestion_Stock_fruits
{
    partial class Connexion_Serveur
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
            this.txt_serveur = new System.Windows.Forms.TextBox();
            this.txt_BD = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_windows = new System.Windows.Forms.RadioButton();
            this.rb_sql = new System.Windows.Forms.RadioButton();
            this.btn_sav = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_serveur
            // 
            this.txt_serveur.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serveur.Location = new System.Drawing.Point(95, 31);
            this.txt_serveur.Name = "txt_serveur";
            this.txt_serveur.Size = new System.Drawing.Size(269, 22);
            this.txt_serveur.TabIndex = 0;
            // 
            // txt_BD
            // 
            this.txt_BD.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BD.Location = new System.Drawing.Point(95, 57);
            this.txt_BD.Name = "txt_BD";
            this.txt_BD.Size = new System.Drawing.Size(269, 22);
            this.txt_BD.TabIndex = 1;
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(95, 163);
            this.txt_user.Name = "txt_user";
            this.txt_user.ReadOnly = true;
            this.txt_user.Size = new System.Drawing.Size(269, 22);
            this.txt_user.TabIndex = 2;
            // 
            // txt_mdp
            // 
            this.txt_mdp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mdp.Location = new System.Drawing.Point(95, 189);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.PasswordChar = '*';
            this.txt_mdp.ReadOnly = true;
            this.txt_mdp.Size = new System.Drawing.Size(269, 22);
            this.txt_mdp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Serveur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "BD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "User :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mot de Passe";
            // 
            // rb_windows
            // 
            this.rb_windows.AutoSize = true;
            this.rb_windows.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_windows.Location = new System.Drawing.Point(95, 99);
            this.rb_windows.Name = "rb_windows";
            this.rb_windows.Size = new System.Drawing.Size(161, 19);
            this.rb_windows.TabIndex = 8;
            this.rb_windows.TabStop = true;
            this.rb_windows.Text = "Windows Authentication ";
            this.rb_windows.UseVisualStyleBackColor = true;
            this.rb_windows.CheckedChanged += new System.EventHandler(this.rb_windows_CheckedChanged);
            // 
            // rb_sql
            // 
            this.rb_sql.AutoSize = true;
            this.rb_sql.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_sql.Location = new System.Drawing.Point(95, 122);
            this.rb_sql.Name = "rb_sql";
            this.rb_sql.Size = new System.Drawing.Size(174, 19);
            this.rb_sql.TabIndex = 9;
            this.rb_sql.TabStop = true;
            this.rb_sql.Text = "Sql Server Authentification";
            this.rb_sql.UseVisualStyleBackColor = true;
            this.rb_sql.CheckedChanged += new System.EventHandler(this.rb_sql_CheckedChanged);
            // 
            // btn_sav
            // 
            this.btn_sav.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sav.Location = new System.Drawing.Point(95, 234);
            this.btn_sav.Name = "btn_sav";
            this.btn_sav.Size = new System.Drawing.Size(94, 40);
            this.btn_sav.TabIndex = 10;
            this.btn_sav.Text = "Sauvegarde Config";
            this.btn_sav.UseVisualStyleBackColor = true;
            this.btn_sav.Click += new System.EventHandler(this.btn_sav_Click);
            // 
            // btn_fermer
            // 
            this.btn_fermer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fermer.Location = new System.Drawing.Point(263, 234);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(101, 40);
            this.btn_fermer.TabIndex = 11;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // Connexion_Serveur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 295);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_sav);
            this.Controls.Add(this.rb_sql);
            this.Controls.Add(this.rb_windows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_BD);
            this.Controls.Add(this.txt_serveur);
            this.Name = "Connexion_Serveur";
            this.Text = "Connexion_Serveur";
            this.Load += new System.EventHandler(this.Connexion_Serveur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_serveur;
        private System.Windows.Forms.TextBox txt_BD;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sav;
        private System.Windows.Forms.Button btn_fermer;
        public System.Windows.Forms.RadioButton rb_windows;
        public System.Windows.Forms.RadioButton rb_sql;
    }
}