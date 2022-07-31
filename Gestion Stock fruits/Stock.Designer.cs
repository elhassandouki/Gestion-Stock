namespace Gestion_Stock_fruits
{
    partial class Stock
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
            this.panel_stock_top = new System.Windows.Forms.Panel();
            this.txt_article = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_stock_center = new System.Windows.Forms.Panel();
            this.dataGridArticle = new System.Windows.Forms.DataGridView();
            this.panel_stock_top.SuspendLayout();
            this.panel_stock_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_stock_top
            // 
            this.panel_stock_top.Controls.Add(this.txt_article);
            this.panel_stock_top.Controls.Add(this.label1);
            this.panel_stock_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_stock_top.Location = new System.Drawing.Point(0, 0);
            this.panel_stock_top.Name = "panel_stock_top";
            this.panel_stock_top.Size = new System.Drawing.Size(583, 65);
            this.panel_stock_top.TabIndex = 0;
            // 
            // txt_article
            // 
            this.txt_article.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_article.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_article.Location = new System.Drawing.Point(197, 27);
            this.txt_article.Name = "txt_article";
            this.txt_article.Size = new System.Drawing.Size(338, 20);
            this.txt_article.TabIndex = 2;
            this.txt_article.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_article_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rechercher sur Article : ";
            // 
            // panel_stock_center
            // 
            this.panel_stock_center.Controls.Add(this.dataGridArticle);
            this.panel_stock_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_stock_center.Location = new System.Drawing.Point(0, 65);
            this.panel_stock_center.Name = "panel_stock_center";
            this.panel_stock_center.Size = new System.Drawing.Size(583, 332);
            this.panel_stock_center.TabIndex = 1;
            // 
            // dataGridArticle
            // 
            this.dataGridArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridArticle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridArticle.Location = new System.Drawing.Point(0, 0);
            this.dataGridArticle.Name = "dataGridArticle";
            this.dataGridArticle.Size = new System.Drawing.Size(583, 332);
            this.dataGridArticle.TabIndex = 0;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 397);
            this.Controls.Add(this.panel_stock_center);
            this.Controls.Add(this.panel_stock_top);
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.panel_stock_top.ResumeLayout(false);
            this.panel_stock_top.PerformLayout();
            this.panel_stock_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridArticle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_stock_top;
        private System.Windows.Forms.TextBox txt_article;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_stock_center;
        private System.Windows.Forms.DataGridView dataGridArticle;
    }
}