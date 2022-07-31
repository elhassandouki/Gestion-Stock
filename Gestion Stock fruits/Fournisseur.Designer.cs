namespace Gestion_Stock_fruits
{
    partial class Fournisseur
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_frs = new System.Windows.Forms.TextBox();
            this.txt_frs_tel = new System.Windows.Forms.TextBox();
            this.txt_frs_adresse = new System.Windows.Forms.TextBox();
            this.txt_frs_ville = new System.Windows.Forms.TextBox();
            this.panel_FRS_top = new System.Windows.Forms.Panel();
            this.btn_add_frs = new System.Windows.Forms.Button();
            this.panel_FRS_bottom = new System.Windows.Forms.Panel();
            this.btn_frs_update = new System.Windows.Forms.Button();
            this.panel_FRS_center = new System.Windows.Forms.Panel();
            this.dataGridFRS = new System.Windows.Forms.DataGridView();
            this.panel_FRS_top.SuspendLayout();
            this.panel_FRS_bottom.SuspendLayout();
            this.panel_FRS_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFRS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion Fournisseur ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fournisseur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tel :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adresse :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ville :";
            // 
            // txt_frs
            // 
            this.txt_frs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_frs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_frs.Location = new System.Drawing.Point(84, 53);
            this.txt_frs.Name = "txt_frs";
            this.txt_frs.Size = new System.Drawing.Size(249, 20);
            this.txt_frs.TabIndex = 5;
            this.txt_frs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_frs_KeyUp);
            // 
            // txt_frs_tel
            // 
            this.txt_frs_tel.Location = new System.Drawing.Point(381, 53);
            this.txt_frs_tel.Name = "txt_frs_tel";
            this.txt_frs_tel.Size = new System.Drawing.Size(167, 20);
            this.txt_frs_tel.TabIndex = 6;
            // 
            // txt_frs_adresse
            // 
            this.txt_frs_adresse.Location = new System.Drawing.Point(84, 79);
            this.txt_frs_adresse.Name = "txt_frs_adresse";
            this.txt_frs_adresse.Size = new System.Drawing.Size(249, 20);
            this.txt_frs_adresse.TabIndex = 7;
            // 
            // txt_frs_ville
            // 
            this.txt_frs_ville.Location = new System.Drawing.Point(381, 80);
            this.txt_frs_ville.Name = "txt_frs_ville";
            this.txt_frs_ville.Size = new System.Drawing.Size(167, 20);
            this.txt_frs_ville.TabIndex = 8;
            // 
            // panel_FRS_top
            // 
            this.panel_FRS_top.Controls.Add(this.btn_add_frs);
            this.panel_FRS_top.Controls.Add(this.label1);
            this.panel_FRS_top.Controls.Add(this.txt_frs_ville);
            this.panel_FRS_top.Controls.Add(this.txt_frs);
            this.panel_FRS_top.Controls.Add(this.txt_frs_adresse);
            this.panel_FRS_top.Controls.Add(this.label2);
            this.panel_FRS_top.Controls.Add(this.txt_frs_tel);
            this.panel_FRS_top.Controls.Add(this.label3);
            this.panel_FRS_top.Controls.Add(this.label4);
            this.panel_FRS_top.Controls.Add(this.label5);
            this.panel_FRS_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_FRS_top.Location = new System.Drawing.Point(0, 0);
            this.panel_FRS_top.Name = "panel_FRS_top";
            this.panel_FRS_top.Size = new System.Drawing.Size(702, 115);
            this.panel_FRS_top.TabIndex = 9;
            // 
            // btn_add_frs
            // 
            this.btn_add_frs.Location = new System.Drawing.Point(564, 53);
            this.btn_add_frs.Name = "btn_add_frs";
            this.btn_add_frs.Size = new System.Drawing.Size(106, 47);
            this.btn_add_frs.TabIndex = 9;
            this.btn_add_frs.Text = "Ajouter";
            this.btn_add_frs.UseVisualStyleBackColor = true;
            this.btn_add_frs.Click += new System.EventHandler(this.btn_add_frs_Click);
            // 
            // panel_FRS_bottom
            // 
            this.panel_FRS_bottom.Controls.Add(this.btn_frs_update);
            this.panel_FRS_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_FRS_bottom.Location = new System.Drawing.Point(0, 347);
            this.panel_FRS_bottom.Name = "panel_FRS_bottom";
            this.panel_FRS_bottom.Size = new System.Drawing.Size(702, 56);
            this.panel_FRS_bottom.TabIndex = 10;
            // 
            // btn_frs_update
            // 
            this.btn_frs_update.Location = new System.Drawing.Point(564, 6);
            this.btn_frs_update.Name = "btn_frs_update";
            this.btn_frs_update.Size = new System.Drawing.Size(106, 42);
            this.btn_frs_update.TabIndex = 10;
            this.btn_frs_update.Text = "Modifier";
            this.btn_frs_update.UseVisualStyleBackColor = true;
            this.btn_frs_update.Click += new System.EventHandler(this.btn_frs_update_Click);
            // 
            // panel_FRS_center
            // 
            this.panel_FRS_center.Controls.Add(this.dataGridFRS);
            this.panel_FRS_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_FRS_center.Location = new System.Drawing.Point(0, 115);
            this.panel_FRS_center.Name = "panel_FRS_center";
            this.panel_FRS_center.Size = new System.Drawing.Size(702, 232);
            this.panel_FRS_center.TabIndex = 11;
            // 
            // dataGridFRS
            // 
            this.dataGridFRS.AllowUserToAddRows = false;
            this.dataGridFRS.AllowUserToDeleteRows = false;
            this.dataGridFRS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFRS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFRS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridFRS.Location = new System.Drawing.Point(0, 0);
            this.dataGridFRS.Name = "dataGridFRS";
            this.dataGridFRS.Size = new System.Drawing.Size(702, 232);
            this.dataGridFRS.TabIndex = 0;
            // 
            // Fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 403);
            this.Controls.Add(this.panel_FRS_center);
            this.Controls.Add(this.panel_FRS_bottom);
            this.Controls.Add(this.panel_FRS_top);
            this.Name = "Fournisseur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fournisseur";
            this.Load += new System.EventHandler(this.Fournisseur_Load);
            this.panel_FRS_top.ResumeLayout(false);
            this.panel_FRS_top.PerformLayout();
            this.panel_FRS_bottom.ResumeLayout(false);
            this.panel_FRS_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFRS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_frs;
        private System.Windows.Forms.TextBox txt_frs_tel;
        private System.Windows.Forms.TextBox txt_frs_adresse;
        private System.Windows.Forms.TextBox txt_frs_ville;
        private System.Windows.Forms.Panel panel_FRS_top;
        private System.Windows.Forms.Button btn_add_frs;
        private System.Windows.Forms.Panel panel_FRS_bottom;
        private System.Windows.Forms.Button btn_frs_update;
        private System.Windows.Forms.Panel panel_FRS_center;
        private System.Windows.Forms.DataGridView dataGridFRS;
    }
}