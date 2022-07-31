namespace Gestion_Stock_fruits
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel_login_top = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_auth = new System.Windows.Forms.Label();
            this.panel_login_bottom = new System.Windows.Forms.Panel();
            this.lblErour = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_mdp = new System.Windows.Forms.TextBox();
            this.btn_conx = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_login_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_login_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_login_top
            // 
            this.panel_login_top.Controls.Add(this.pictureBox1);
            this.panel_login_top.Controls.Add(this.label_auth);
            this.panel_login_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_login_top.Location = new System.Drawing.Point(0, 0);
            this.panel_login_top.Name = "panel_login_top";
            this.panel_login_top.Size = new System.Drawing.Size(379, 68);
            this.panel_login_top.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_auth
            // 
            this.label_auth.AutoSize = true;
            this.label_auth.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_auth.Location = new System.Drawing.Point(132, 21);
            this.label_auth.Name = "label_auth";
            this.label_auth.Size = new System.Drawing.Size(215, 29);
            this.label_auth.TabIndex = 0;
            this.label_auth.Text = "Authentification";
            this.label_auth.Click += new System.EventHandler(this.label_auth_Click);
            // 
            // panel_login_bottom
            // 
            this.panel_login_bottom.Controls.Add(this.lblErour);
            this.panel_login_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_login_bottom.Location = new System.Drawing.Point(0, 206);
            this.panel_login_bottom.Name = "panel_login_bottom";
            this.panel_login_bottom.Size = new System.Drawing.Size(379, 47);
            this.panel_login_bottom.TabIndex = 1;
            // 
            // lblErour
            // 
            this.lblErour.AutoSize = true;
            this.lblErour.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErour.Location = new System.Drawing.Point(12, 16);
            this.lblErour.Name = "lblErour";
            this.lblErour.Size = new System.Drawing.Size(39, 13);
            this.lblErour.TabIndex = 0;
            this.lblErour.Text = "label1";
            this.lblErour.Visible = false;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(137, 104);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(210, 20);
            this.txt_login.TabIndex = 2;
            // 
            // txt_mdp
            // 
            this.txt_mdp.Location = new System.Drawing.Point(137, 131);
            this.txt_mdp.Name = "txt_mdp";
            this.txt_mdp.PasswordChar = '*';
            this.txt_mdp.Size = new System.Drawing.Size(210, 20);
            this.txt_mdp.TabIndex = 3;
            // 
            // btn_conx
            // 
            this.btn_conx.Location = new System.Drawing.Point(150, 170);
            this.btn_conx.Name = "btn_conx";
            this.btn_conx.Size = new System.Drawing.Size(75, 23);
            this.btn_conx.TabIndex = 4;
            this.btn_conx.Text = "Connexion";
            this.btn_conx.UseVisualStyleBackColor = true;
            this.btn_conx.Click += new System.EventHandler(this.btn_conx_Click);
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(243, 170);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_fermer.TabIndex = 5;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom d\'utilisateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mot de passe";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(379, 253);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_conx);
            this.Controls.Add(this.txt_mdp);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.panel_login_bottom);
            this.Controls.Add(this.panel_login_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel_login_top.ResumeLayout(false);
            this.panel_login_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_login_bottom.ResumeLayout(false);
            this.panel_login_bottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_login_top;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_auth;
        private System.Windows.Forms.Panel panel_login_bottom;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_mdp;
        private System.Windows.Forms.Button btn_conx;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Label lblErour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}