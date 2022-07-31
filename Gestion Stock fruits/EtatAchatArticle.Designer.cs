namespace Gestion_Stock_fruits
{
    partial class EtatAchatArticle
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
            this.panel_EtatAchat_top = new System.Windows.Forms.Panel();
            this.panel_EtatAchat_center = new System.Windows.Forms.Panel();
            this.dataGridEtatAchat = new System.Windows.Forms.DataGridView();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.date_max = new System.Windows.Forms.DateTimePicker();
            this.date_min = new System.Windows.Forms.DateTimePicker();
            this.txt_article = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_EtatAchat_top.SuspendLayout();
            this.panel_EtatAchat_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEtatAchat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_EtatAchat_top
            // 
            this.panel_EtatAchat_top.Controls.Add(this.btn_rechercher);
            this.panel_EtatAchat_top.Controls.Add(this.date_max);
            this.panel_EtatAchat_top.Controls.Add(this.date_min);
            this.panel_EtatAchat_top.Controls.Add(this.txt_article);
            this.panel_EtatAchat_top.Controls.Add(this.label3);
            this.panel_EtatAchat_top.Controls.Add(this.label2);
            this.panel_EtatAchat_top.Controls.Add(this.label1);
            this.panel_EtatAchat_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_EtatAchat_top.Location = new System.Drawing.Point(0, 0);
            this.panel_EtatAchat_top.Name = "panel_EtatAchat_top";
            this.panel_EtatAchat_top.Size = new System.Drawing.Size(806, 79);
            this.panel_EtatAchat_top.TabIndex = 0;
            // 
            // panel_EtatAchat_center
            // 
            this.panel_EtatAchat_center.Controls.Add(this.dataGridEtatAchat);
            this.panel_EtatAchat_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_EtatAchat_center.Location = new System.Drawing.Point(0, 79);
            this.panel_EtatAchat_center.Name = "panel_EtatAchat_center";
            this.panel_EtatAchat_center.Size = new System.Drawing.Size(806, 405);
            this.panel_EtatAchat_center.TabIndex = 1;
            // 
            // dataGridEtatAchat
            // 
            this.dataGridEtatAchat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEtatAchat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEtatAchat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridEtatAchat.Location = new System.Drawing.Point(0, 0);
            this.dataGridEtatAchat.Name = "dataGridEtatAchat";
            this.dataGridEtatAchat.Size = new System.Drawing.Size(806, 405);
            this.dataGridEtatAchat.TabIndex = 0;
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rechercher.Location = new System.Drawing.Point(678, 27);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(103, 32);
            this.btn_rechercher.TabIndex = 13;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click_1);
            // 
            // date_max
            // 
            this.date_max.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_max.Location = new System.Drawing.Point(405, 44);
            this.date_max.Name = "date_max";
            this.date_max.Size = new System.Drawing.Size(233, 26);
            this.date_max.TabIndex = 12;
            // 
            // date_min
            // 
            this.date_min.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_min.Location = new System.Drawing.Point(405, 8);
            this.date_min.Name = "date_min";
            this.date_min.Size = new System.Drawing.Size(233, 26);
            this.date_min.TabIndex = 11;
            // 
            // txt_article
            // 
            this.txt_article.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_article.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_article.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_article.Location = new System.Drawing.Point(91, 27);
            this.txt_article.Name = "txt_article";
            this.txt_article.Size = new System.Drawing.Size(206, 26);
            this.txt_article.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date Fin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date Début :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Article :";
            // 
            // EtatAchatArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 484);
            this.Controls.Add(this.panel_EtatAchat_center);
            this.Controls.Add(this.panel_EtatAchat_top);
            this.Name = "EtatAchatArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EtatAchatArticle";
            this.Load += new System.EventHandler(this.EtatAchatArticle_Load);
            this.panel_EtatAchat_top.ResumeLayout(false);
            this.panel_EtatAchat_top.PerformLayout();
            this.panel_EtatAchat_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEtatAchat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_EtatAchat_top;
        private System.Windows.Forms.Panel panel_EtatAchat_center;
        private System.Windows.Forms.DataGridView dataGridEtatAchat;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.DateTimePicker date_max;
        private System.Windows.Forms.DateTimePicker date_min;
        private System.Windows.Forms.TextBox txt_article;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}