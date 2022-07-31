namespace Gestion_Stock_fruits
{
    partial class FRM_
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.btn_caisse = new System.Windows.Forms.Button();
            this.btn_dépense = new System.Windows.Forms.Button();
            this.btn_fournisseur = new System.Windows.Forms.Button();
            this.btn_inventaire = new System.Windows.Forms.Button();
            this.btn_article = new System.Windows.Forms.Button();
            this.btn_stock = new System.Windows.Forms.Button();
            this.btn_vente = new System.Windows.Forms.Button();
            this.btn_achat = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btn_config = new System.Windows.Forms.Button();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.btn_config);
            this.panel_top.Controls.Add(this.btn_caisse);
            this.panel_top.Controls.Add(this.btn_dépense);
            this.panel_top.Controls.Add(this.btn_fournisseur);
            this.panel_top.Controls.Add(this.btn_inventaire);
            this.panel_top.Controls.Add(this.btn_article);
            this.panel_top.Controls.Add(this.btn_stock);
            this.panel_top.Controls.Add(this.btn_vente);
            this.panel_top.Controls.Add(this.btn_achat);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Margin = new System.Windows.Forms.Padding(0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(847, 70);
            this.panel_top.TabIndex = 0;
            this.panel_top.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_top_Paint);
            // 
            // btn_caisse
            // 
            this.btn_caisse.Location = new System.Drawing.Point(650, 2);
            this.btn_caisse.Name = "btn_caisse";
            this.btn_caisse.Size = new System.Drawing.Size(90, 65);
            this.btn_caisse.TabIndex = 6;
            this.btn_caisse.Text = "Caisse";
            this.btn_caisse.UseVisualStyleBackColor = true;
            this.btn_caisse.Click += new System.EventHandler(this.btn_caisse_Click);
            // 
            // btn_dépense
            // 
            this.btn_dépense.Location = new System.Drawing.Point(557, 2);
            this.btn_dépense.Name = "btn_dépense";
            this.btn_dépense.Size = new System.Drawing.Size(90, 65);
            this.btn_dépense.TabIndex = 5;
            this.btn_dépense.Text = "Dépense";
            this.btn_dépense.UseVisualStyleBackColor = true;
            // 
            // btn_fournisseur
            // 
            this.btn_fournisseur.Location = new System.Drawing.Point(464, 2);
            this.btn_fournisseur.Name = "btn_fournisseur";
            this.btn_fournisseur.Size = new System.Drawing.Size(90, 65);
            this.btn_fournisseur.TabIndex = 4;
            this.btn_fournisseur.Text = "Fournisseur";
            this.btn_fournisseur.UseVisualStyleBackColor = true;
            this.btn_fournisseur.Click += new System.EventHandler(this.btn_fournisseur_Click);
            // 
            // btn_inventaire
            // 
            this.btn_inventaire.Location = new System.Drawing.Point(371, 2);
            this.btn_inventaire.Name = "btn_inventaire";
            this.btn_inventaire.Size = new System.Drawing.Size(90, 65);
            this.btn_inventaire.TabIndex = 1;
            this.btn_inventaire.Text = "Inventaire";
            this.btn_inventaire.UseVisualStyleBackColor = true;
            this.btn_inventaire.Click += new System.EventHandler(this.btn_inventaire_Click);
            // 
            // btn_article
            // 
            this.btn_article.Location = new System.Drawing.Point(278, 2);
            this.btn_article.Name = "btn_article";
            this.btn_article.Size = new System.Drawing.Size(90, 65);
            this.btn_article.TabIndex = 3;
            this.btn_article.Text = "Article";
            this.btn_article.UseVisualStyleBackColor = true;
            this.btn_article.Click += new System.EventHandler(this.btn_article_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.Location = new System.Drawing.Point(186, 2);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(90, 65);
            this.btn_stock.TabIndex = 2;
            this.btn_stock.Text = "Stock";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // btn_vente
            // 
            this.btn_vente.Location = new System.Drawing.Point(94, 2);
            this.btn_vente.Name = "btn_vente";
            this.btn_vente.Size = new System.Drawing.Size(90, 65);
            this.btn_vente.TabIndex = 1;
            this.btn_vente.Text = "Vente";
            this.btn_vente.UseVisualStyleBackColor = true;
            this.btn_vente.Click += new System.EventHandler(this.btn_vente_Click);
            // 
            // btn_achat
            // 
            this.btn_achat.Location = new System.Drawing.Point(3, 2);
            this.btn_achat.Name = "btn_achat";
            this.btn_achat.Size = new System.Drawing.Size(90, 65);
            this.btn_achat.TabIndex = 0;
            this.btn_achat.Text = "Achat";
            this.btn_achat.UseVisualStyleBackColor = true;
            this.btn_achat.Click += new System.EventHandler(this.btn_achat_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 70);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 429);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Visible = false;
            // 
            // btn_config
            // 
            this.btn_config.Location = new System.Drawing.Point(745, 2);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(90, 65);
            this.btn_config.TabIndex = 7;
            this.btn_config.Text = "Config";
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // FRM_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 499);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_top);
            this.IsMdiContainer = true;
            this.Name = "FRM_";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Stock Fruits ";
            this.Load += new System.EventHandler(this.FRM__Load);
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button btn_caisse;
        private System.Windows.Forms.Button btn_dépense;
        private System.Windows.Forms.Button btn_fournisseur;
        private System.Windows.Forms.Button btn_inventaire;
        private System.Windows.Forms.Button btn_article;
        private System.Windows.Forms.Button btn_stock;
        private System.Windows.Forms.Button btn_vente;
        private System.Windows.Forms.Button btn_achat;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_config;
    }
}

