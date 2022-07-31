namespace Gestion_Stock_fruits
{
    partial class Articles
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_article = new System.Windows.Forms.Label();
            this.txt_ref = new System.Windows.Forms.TextBox();
            this.txt_desgination = new System.Windows.Forms.TextBox();
            this.dataGrid_article = new System.Windows.Forms.DataGridView();
            this.btn_add_article = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_article)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Réf :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Désignation :";
            // 
            // lbl_article
            // 
            this.lbl_article.AutoSize = true;
            this.lbl_article.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_article.Location = new System.Drawing.Point(179, 12);
            this.lbl_article.Name = "lbl_article";
            this.lbl_article.Size = new System.Drawing.Size(158, 29);
            this.lbl_article.TabIndex = 2;
            this.lbl_article.Text = "Les Articles";
            // 
            // txt_ref
            // 
            this.txt_ref.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_ref.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_ref.Location = new System.Drawing.Point(86, 61);
            this.txt_ref.Name = "txt_ref";
            this.txt_ref.Size = new System.Drawing.Size(178, 20);
            this.txt_ref.TabIndex = 3;
            this.txt_ref.TextChanged += new System.EventHandler(this.txt_ref_TextChanged);
            this.txt_ref.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_ref_KeyUp);
            // 
            // txt_desgination
            // 
            this.txt_desgination.Location = new System.Drawing.Point(86, 90);
            this.txt_desgination.Name = "txt_desgination";
            this.txt_desgination.Size = new System.Drawing.Size(397, 20);
            this.txt_desgination.TabIndex = 4;
            // 
            // dataGrid_article
            // 
            this.dataGrid_article.AllowUserToAddRows = false;
            this.dataGrid_article.AllowUserToDeleteRows = false;
            this.dataGrid_article.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_article.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_article.Location = new System.Drawing.Point(9, 156);
            this.dataGrid_article.Name = "dataGrid_article";
            this.dataGrid_article.ReadOnly = true;
            this.dataGrid_article.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_article.Size = new System.Drawing.Size(474, 207);
            this.dataGrid_article.TabIndex = 5;
            this.dataGrid_article.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_article_CellClick);
            this.dataGrid_article.DoubleClick += new System.EventHandler(this.dataGrid_article_DoubleClick);
            // 
            // btn_add_article
            // 
            this.btn_add_article.Location = new System.Drawing.Point(377, 116);
            this.btn_add_article.Name = "btn_add_article";
            this.btn_add_article.Size = new System.Drawing.Size(104, 34);
            this.btn_add_article.TabIndex = 6;
            this.btn_add_article.Text = "Ajouter";
            this.btn_add_article.UseVisualStyleBackColor = true;
            this.btn_add_article.Click += new System.EventHandler(this.btn_add_article_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(393, 379);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(90, 32);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Modifier";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Articles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 423);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add_article);
            this.Controls.Add(this.dataGrid_article);
            this.Controls.Add(this.txt_desgination);
            this.Controls.Add(this.txt_ref);
            this.Controls.Add(this.lbl_article);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Articles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articles";
            this.Load += new System.EventHandler(this.Articles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_article)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_article;
        private System.Windows.Forms.TextBox txt_ref;
        private System.Windows.Forms.TextBox txt_desgination;
        private System.Windows.Forms.DataGridView dataGrid_article;
        private System.Windows.Forms.Button btn_add_article;
        private System.Windows.Forms.Button btn_update;
    }
}