namespace Gestion_Stock_fruits
{
    partial class Détail_Bon_Livraison
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
            this.panel_detailBL_top = new System.Windows.Forms.Panel();
            this.txt_montant = new System.Windows.Forms.TextBox();
            this.txt_CL = new System.Windows.Forms.TextBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.txt_NBL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_detailBL_center = new System.Windows.Forms.Panel();
            this.dataGridDetailVente = new System.Windows.Forms.DataGridView();
            this.panel_detail_bottom = new System.Windows.Forms.Panel();
            this.btn_imprimer = new System.Windows.Forms.Button();
            this.panel_detailBL_top.SuspendLayout();
            this.panel_detailBL_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailVente)).BeginInit();
            this.panel_detail_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_detailBL_top
            // 
            this.panel_detailBL_top.Controls.Add(this.txt_montant);
            this.panel_detailBL_top.Controls.Add(this.txt_CL);
            this.panel_detailBL_top.Controls.Add(this.txt_Date);
            this.panel_detailBL_top.Controls.Add(this.txt_NBL);
            this.panel_detailBL_top.Controls.Add(this.label4);
            this.panel_detailBL_top.Controls.Add(this.label3);
            this.panel_detailBL_top.Controls.Add(this.label2);
            this.panel_detailBL_top.Controls.Add(this.label1);
            this.panel_detailBL_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_detailBL_top.Location = new System.Drawing.Point(0, 0);
            this.panel_detailBL_top.Name = "panel_detailBL_top";
            this.panel_detailBL_top.Size = new System.Drawing.Size(646, 72);
            this.panel_detailBL_top.TabIndex = 0;
            // 
            // txt_montant
            // 
            this.txt_montant.Enabled = false;
            this.txt_montant.Location = new System.Drawing.Point(383, 38);
            this.txt_montant.Name = "txt_montant";
            this.txt_montant.Size = new System.Drawing.Size(195, 20);
            this.txt_montant.TabIndex = 7;
            // 
            // txt_CL
            // 
            this.txt_CL.Enabled = false;
            this.txt_CL.Location = new System.Drawing.Point(383, 12);
            this.txt_CL.Name = "txt_CL";
            this.txt_CL.Size = new System.Drawing.Size(195, 20);
            this.txt_CL.TabIndex = 6;
            // 
            // txt_Date
            // 
            this.txt_Date.Enabled = false;
            this.txt_Date.Location = new System.Drawing.Point(93, 38);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(172, 20);
            this.txt_Date.TabIndex = 5;
            // 
            // txt_NBL
            // 
            this.txt_NBL.Enabled = false;
            this.txt_NBL.Location = new System.Drawing.Point(93, 12);
            this.txt_NBL.Name = "txt_NBL";
            this.txt_NBL.Size = new System.Drawing.Size(172, 20);
            this.txt_NBL.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(293, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Montant  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Client  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "BL N° :";
            // 
            // panel_detailBL_center
            // 
            this.panel_detailBL_center.Controls.Add(this.dataGridDetailVente);
            this.panel_detailBL_center.Location = new System.Drawing.Point(0, 72);
            this.panel_detailBL_center.Name = "panel_detailBL_center";
            this.panel_detailBL_center.Size = new System.Drawing.Size(646, 226);
            this.panel_detailBL_center.TabIndex = 1;
            this.panel_detailBL_center.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_detailBL_center_Paint);
            // 
            // dataGridDetailVente
            // 
            this.dataGridDetailVente.AllowUserToAddRows = false;
            this.dataGridDetailVente.AllowUserToDeleteRows = false;
            this.dataGridDetailVente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDetailVente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetailVente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridDetailVente.Location = new System.Drawing.Point(0, 0);
            this.dataGridDetailVente.Name = "dataGridDetailVente";
            this.dataGridDetailVente.ReadOnly = true;
            this.dataGridDetailVente.Size = new System.Drawing.Size(646, 226);
            this.dataGridDetailVente.TabIndex = 0;
            // 
            // panel_detail_bottom
            // 
            this.panel_detail_bottom.Controls.Add(this.btn_imprimer);
            this.panel_detail_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_detail_bottom.Location = new System.Drawing.Point(0, 298);
            this.panel_detail_bottom.Name = "panel_detail_bottom";
            this.panel_detail_bottom.Size = new System.Drawing.Size(646, 54);
            this.panel_detail_bottom.TabIndex = 2;
            // 
            // btn_imprimer
            // 
            this.btn_imprimer.Location = new System.Drawing.Point(474, 6);
            this.btn_imprimer.Name = "btn_imprimer";
            this.btn_imprimer.Size = new System.Drawing.Size(149, 45);
            this.btn_imprimer.TabIndex = 0;
            this.btn_imprimer.Text = "Imprimer";
            this.btn_imprimer.UseVisualStyleBackColor = true;
            this.btn_imprimer.Click += new System.EventHandler(this.btn_imprimer_Click);
            // 
            // Détail_Bon_Livraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 352);
            this.Controls.Add(this.panel_detail_bottom);
            this.Controls.Add(this.panel_detailBL_center);
            this.Controls.Add(this.panel_detailBL_top);
            this.Name = "Détail_Bon_Livraison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Détail Bon Livraison";
            this.Load += new System.EventHandler(this.Détail_Bon_Livraison_Load_1);
            this.panel_detailBL_top.ResumeLayout(false);
            this.panel_detailBL_top.PerformLayout();
            this.panel_detailBL_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetailVente)).EndInit();
            this.panel_detail_bottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_detailBL_top;
        public System.Windows.Forms.Panel panel_detailBL_center;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_montant;
        public System.Windows.Forms.TextBox txt_CL;
        public System.Windows.Forms.TextBox txt_Date;
        public System.Windows.Forms.TextBox txt_NBL;
        public System.Windows.Forms.DataGridView dataGridDetailVente;
        private System.Windows.Forms.Panel panel_detail_bottom;
        private System.Windows.Forms.Button btn_imprimer;

    }
}