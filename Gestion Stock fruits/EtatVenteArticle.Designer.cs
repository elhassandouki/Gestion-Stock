namespace Gestion_Stock_fruits
{
    partial class EtatVenteArticle
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
            this.panel_Etatvente_top = new System.Windows.Forms.Panel();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.date_max = new System.Windows.Forms.DateTimePicker();
            this.date_min = new System.Windows.Forms.DateTimePicker();
            this.txt_article = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Etatvente_center = new System.Windows.Forms.Panel();
            this.dataGrid_EtatVenteArticle = new System.Windows.Forms.DataGridView();
            this.panel_Etatvente_top.SuspendLayout();
            this.panel_Etatvente_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_EtatVenteArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Etatvente_top
            // 
            this.panel_Etatvente_top.Controls.Add(this.btn_rechercher);
            this.panel_Etatvente_top.Controls.Add(this.date_max);
            this.panel_Etatvente_top.Controls.Add(this.date_min);
            this.panel_Etatvente_top.Controls.Add(this.txt_article);
            this.panel_Etatvente_top.Controls.Add(this.label3);
            this.panel_Etatvente_top.Controls.Add(this.label2);
            this.panel_Etatvente_top.Controls.Add(this.label1);
            this.panel_Etatvente_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Etatvente_top.Location = new System.Drawing.Point(0, 0);
            this.panel_Etatvente_top.Name = "panel_Etatvente_top";
            this.panel_Etatvente_top.Size = new System.Drawing.Size(813, 79);
            this.panel_Etatvente_top.TabIndex = 0;
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rechercher.Location = new System.Drawing.Point(673, 28);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(103, 32);
            this.btn_rechercher.TabIndex = 6;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // date_max
            // 
            this.date_max.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_max.Location = new System.Drawing.Point(400, 45);
            this.date_max.Name = "date_max";
            this.date_max.Size = new System.Drawing.Size(233, 26);
            this.date_max.TabIndex = 5;
            this.date_max.ValueChanged += new System.EventHandler(this.date_max_ValueChanged);
            // 
            // date_min
            // 
            this.date_min.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_min.Location = new System.Drawing.Point(400, 9);
            this.date_min.Name = "date_min";
            this.date_min.Size = new System.Drawing.Size(233, 26);
            this.date_min.TabIndex = 4;
            this.date_min.ValueChanged += new System.EventHandler(this.date_min_ValueChanged);
            // 
            // txt_article
            // 
            this.txt_article.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_article.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_article.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_article.Location = new System.Drawing.Point(86, 28);
            this.txt_article.Name = "txt_article";
            this.txt_article.Size = new System.Drawing.Size(206, 26);
            this.txt_article.TabIndex = 3;
            this.txt_article.TextChanged += new System.EventHandler(this.txt_article_TextChanged);
            this.txt_article.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_article_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Fin :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Début :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Article :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_Etatvente_center
            // 
            this.panel_Etatvente_center.Controls.Add(this.dataGrid_EtatVenteArticle);
            this.panel_Etatvente_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Etatvente_center.Location = new System.Drawing.Point(0, 79);
            this.panel_Etatvente_center.Name = "panel_Etatvente_center";
            this.panel_Etatvente_center.Size = new System.Drawing.Size(813, 403);
            this.panel_Etatvente_center.TabIndex = 1;
            // 
            // dataGrid_EtatVenteArticle
            // 
            this.dataGrid_EtatVenteArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_EtatVenteArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_EtatVenteArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid_EtatVenteArticle.Location = new System.Drawing.Point(0, 0);
            this.dataGrid_EtatVenteArticle.Name = "dataGrid_EtatVenteArticle";
            this.dataGrid_EtatVenteArticle.Size = new System.Drawing.Size(813, 403);
            this.dataGrid_EtatVenteArticle.TabIndex = 0;
            // 
            // EtatVenteArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 482);
            this.Controls.Add(this.panel_Etatvente_center);
            this.Controls.Add(this.panel_Etatvente_top);
            this.Name = "EtatVenteArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etat Vente Article";
            this.Load += new System.EventHandler(this.EtatVenteArticle_Load);
            this.panel_Etatvente_top.ResumeLayout(false);
            this.panel_Etatvente_top.PerformLayout();
            this.panel_Etatvente_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_EtatVenteArticle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Etatvente_top;
        private System.Windows.Forms.DateTimePicker date_max;
        private System.Windows.Forms.DateTimePicker date_min;
        private System.Windows.Forms.TextBox txt_article;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Etatvente_center;
        private System.Windows.Forms.DataGridView dataGrid_EtatVenteArticle;
        private System.Windows.Forms.Button btn_rechercher;
    }
}