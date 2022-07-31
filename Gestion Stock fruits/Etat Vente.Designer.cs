namespace Gestion_Stock_fruits
{
    partial class Etat_Vente
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
            this.panel_ETATvente_top = new System.Windows.Forms.Panel();
            this.btn_afficher_ETATVENTE = new System.Windows.Forms.Button();
            this.label_ETATVENTE = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_vente = new System.Windows.Forms.DateTimePicker();
            this.cmb_regle = new System.Windows.Forms.ComboBox();
            this.panel_ETATVENTE_center = new System.Windows.Forms.Panel();
            this.dataGridEatavente = new System.Windows.Forms.DataGridView();
            this.panel_ETATVENTE_bottom = new System.Windows.Forms.Panel();
            this.label_total = new System.Windows.Forms.Label();
            this.panel_ETATvente_top.SuspendLayout();
            this.panel_ETATVENTE_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEatavente)).BeginInit();
            this.panel_ETATVENTE_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ETATvente_top
            // 
            this.panel_ETATvente_top.Controls.Add(this.btn_afficher_ETATVENTE);
            this.panel_ETATvente_top.Controls.Add(this.label_ETATVENTE);
            this.panel_ETATvente_top.Controls.Add(this.label2);
            this.panel_ETATvente_top.Controls.Add(this.label1);
            this.panel_ETATvente_top.Controls.Add(this.date_vente);
            this.panel_ETATvente_top.Controls.Add(this.cmb_regle);
            this.panel_ETATvente_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ETATvente_top.Location = new System.Drawing.Point(0, 0);
            this.panel_ETATvente_top.Name = "panel_ETATvente_top";
            this.panel_ETATvente_top.Size = new System.Drawing.Size(835, 68);
            this.panel_ETATvente_top.TabIndex = 0;
            // 
            // btn_afficher_ETATVENTE
            // 
            this.btn_afficher_ETATVENTE.Location = new System.Drawing.Point(731, 9);
            this.btn_afficher_ETATVENTE.Name = "btn_afficher_ETATVENTE";
            this.btn_afficher_ETATVENTE.Size = new System.Drawing.Size(92, 51);
            this.btn_afficher_ETATVENTE.TabIndex = 5;
            this.btn_afficher_ETATVENTE.Text = "Vente";
            this.btn_afficher_ETATVENTE.UseVisualStyleBackColor = true;
            this.btn_afficher_ETATVENTE.Click += new System.EventHandler(this.btn_afficher_ETATVENTE_Click);
            // 
            // label_ETATVENTE
            // 
            this.label_ETATVENTE.AutoSize = true;
            this.label_ETATVENTE.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ETATVENTE.Location = new System.Drawing.Point(13, 18);
            this.label_ETATVENTE.Name = "label_ETATVENTE";
            this.label_ETATVENTE.Size = new System.Drawing.Size(136, 31);
            this.label_ETATVENTE.TabIndex = 4;
            this.label_ETATVENTE.Text = "Etat Vente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date Vente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Etat :";
            // 
            // date_vente
            // 
            this.date_vente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_vente.Location = new System.Drawing.Point(492, 24);
            this.date_vente.Name = "date_vente";
            this.date_vente.Size = new System.Drawing.Size(233, 26);
            this.date_vente.TabIndex = 1;
            // 
            // cmb_regle
            // 
            this.cmb_regle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_regle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_regle.FormattingEnabled = true;
            this.cmb_regle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_regle.Items.AddRange(new object[] {
            "Régle",
            "Non Régle"});
            this.cmb_regle.Location = new System.Drawing.Point(225, 23);
            this.cmb_regle.Name = "cmb_regle";
            this.cmb_regle.Size = new System.Drawing.Size(166, 27);
            this.cmb_regle.TabIndex = 0;
            // 
            // panel_ETATVENTE_center
            // 
            this.panel_ETATVENTE_center.Controls.Add(this.dataGridEatavente);
            this.panel_ETATVENTE_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ETATVENTE_center.Location = new System.Drawing.Point(0, 68);
            this.panel_ETATVENTE_center.Name = "panel_ETATVENTE_center";
            this.panel_ETATVENTE_center.Size = new System.Drawing.Size(835, 427);
            this.panel_ETATVENTE_center.TabIndex = 1;
            // 
            // dataGridEatavente
            // 
            this.dataGridEatavente.AllowUserToAddRows = false;
            this.dataGridEatavente.AllowUserToDeleteRows = false;
            this.dataGridEatavente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEatavente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEatavente.Location = new System.Drawing.Point(0, 0);
            this.dataGridEatavente.Name = "dataGridEatavente";
            this.dataGridEatavente.ReadOnly = true;
            this.dataGridEatavente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEatavente.Size = new System.Drawing.Size(835, 375);
            this.dataGridEatavente.TabIndex = 0;
            this.dataGridEatavente.Click += new System.EventHandler(this.dataGridEatavente_Click);
            // 
            // panel_ETATVENTE_bottom
            // 
            this.panel_ETATVENTE_bottom.Controls.Add(this.label_total);
            this.panel_ETATVENTE_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_ETATVENTE_bottom.Location = new System.Drawing.Point(0, 449);
            this.panel_ETATVENTE_bottom.Name = "panel_ETATVENTE_bottom";
            this.panel_ETATVENTE_bottom.Size = new System.Drawing.Size(835, 46);
            this.panel_ETATVENTE_bottom.TabIndex = 2;
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(370, 8);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(0, 24);
            this.label_total.TabIndex = 0;
            // 
            // Etat_Vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 495);
            this.Controls.Add(this.panel_ETATVENTE_bottom);
            this.Controls.Add(this.panel_ETATVENTE_center);
            this.Controls.Add(this.panel_ETATvente_top);
            this.Name = "Etat_Vente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etat Vente";
            this.Load += new System.EventHandler(this.Etat_Vente_Load);
            this.panel_ETATvente_top.ResumeLayout(false);
            this.panel_ETATvente_top.PerformLayout();
            this.panel_ETATVENTE_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEatavente)).EndInit();
            this.panel_ETATVENTE_bottom.ResumeLayout(false);
            this.panel_ETATVENTE_bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ETATvente_top;
        private System.Windows.Forms.Button btn_afficher_ETATVENTE;
        private System.Windows.Forms.Label label_ETATVENTE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_vente;
        private System.Windows.Forms.ComboBox cmb_regle;
        private System.Windows.Forms.Panel panel_ETATVENTE_center;
        private System.Windows.Forms.DataGridView dataGridEatavente;
        private System.Windows.Forms.Panel panel_ETATVENTE_bottom;
        private System.Windows.Forms.Label label_total;
    }
}