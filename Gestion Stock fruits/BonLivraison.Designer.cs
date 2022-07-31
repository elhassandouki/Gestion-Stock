namespace Gestion_Stock_fruits
{
    partial class BonLivraison
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
            this.panel_etat_ = new System.Windows.Forms.Panel();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_vente = new System.Windows.Forms.DateTimePicker();
            this.cmb_regle = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel_center = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel_etat_.SuspendLayout();
            this.panel_center.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_etat_
            // 
            this.panel_etat_.Controls.Add(this.btn_rechercher);
            this.panel_etat_.Controls.Add(this.label2);
            this.panel_etat_.Controls.Add(this.label1);
            this.panel_etat_.Controls.Add(this.date_vente);
            this.panel_etat_.Controls.Add(this.cmb_regle);
            this.panel_etat_.Controls.Add(this.dateTimePicker2);
            this.panel_etat_.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_etat_.Location = new System.Drawing.Point(0, 0);
            this.panel_etat_.Name = "panel_etat_";
            this.panel_etat_.Size = new System.Drawing.Size(807, 65);
            this.panel_etat_.TabIndex = 0;
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rechercher.Location = new System.Drawing.Point(692, 16);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(103, 36);
            this.btn_rechercher.TabIndex = 10;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Date Vente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Etat :";
            // 
            // date_vente
            // 
            this.date_vente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_vente.Location = new System.Drawing.Point(443, 19);
            this.date_vente.Name = "date_vente";
            this.date_vente.Size = new System.Drawing.Size(233, 26);
            this.date_vente.TabIndex = 7;
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
            this.cmb_regle.Location = new System.Drawing.Point(182, 19);
            this.cmb_regle.Name = "cmb_regle";
            this.cmb_regle.Size = new System.Drawing.Size(166, 27);
            this.cmb_regle.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(469, 21);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // panel_center
            // 
            this.panel_center.Controls.Add(this.crystalReportViewer1);
            this.panel_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_center.Location = new System.Drawing.Point(0, 65);
            this.panel_center.Name = "panel_center";
            this.panel_center.Size = new System.Drawing.Size(807, 394);
            this.panel_center.TabIndex = 1;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(807, 394);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // BonLivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 459);
            this.Controls.Add(this.panel_center);
            this.Controls.Add(this.panel_etat_);
            this.Name = "BonLivraison";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bon Livraison";
            this.Load += new System.EventHandler(this.BonLivraison_Load);
            this.panel_etat_.ResumeLayout(false);
            this.panel_etat_.PerformLayout();
            this.panel_center.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_etat_;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panel_center;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_vente;
        private System.Windows.Forms.ComboBox cmb_regle;
    }
}