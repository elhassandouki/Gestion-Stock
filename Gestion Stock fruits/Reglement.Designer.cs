namespace Gestion_Stock_fruits
{
    partial class Reglement
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
            this.btn_valider_regl = new System.Windows.Forms.Button();
            this.txt_NBL = new System.Windows.Forms.TextBox();
            this.txt_montantBL = new System.Windows.Forms.TextBox();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.date_regl = new System.Windows.Forms.DateTimePicker();
            this.cmb_mode = new System.Windows.Forms.ComboBox();
            this.cmb_regl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_valider_regl
            // 
            this.btn_valider_regl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider_regl.Location = new System.Drawing.Point(296, 264);
            this.btn_valider_regl.Name = "btn_valider_regl";
            this.btn_valider_regl.Size = new System.Drawing.Size(87, 33);
            this.btn_valider_regl.TabIndex = 0;
            this.btn_valider_regl.Text = "Valider";
            this.btn_valider_regl.UseVisualStyleBackColor = true;
            this.btn_valider_regl.Click += new System.EventHandler(this.btn_valider_regl_Click);
            // 
            // txt_NBL
            // 
            this.txt_NBL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NBL.Location = new System.Drawing.Point(120, 44);
            this.txt_NBL.Name = "txt_NBL";
            this.txt_NBL.Size = new System.Drawing.Size(263, 26);
            this.txt_NBL.TabIndex = 1;
            // 
            // txt_montantBL
            // 
            this.txt_montantBL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_montantBL.Location = new System.Drawing.Point(120, 80);
            this.txt_montantBL.Name = "txt_montantBL";
            this.txt_montantBL.Size = new System.Drawing.Size(263, 26);
            this.txt_montantBL.TabIndex = 2;
            // 
            // txt_note
            // 
            this.txt_note.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_note.Location = new System.Drawing.Point(120, 187);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(263, 71);
            this.txt_note.TabIndex = 3;
            // 
            // date_regl
            // 
            this.date_regl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_regl.Location = new System.Drawing.Point(120, 12);
            this.date_regl.Name = "date_regl";
            this.date_regl.Size = new System.Drawing.Size(263, 26);
            this.date_regl.TabIndex = 4;
            // 
            // cmb_mode
            // 
            this.cmb_mode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mode.FormattingEnabled = true;
            this.cmb_mode.Items.AddRange(new object[] {
            "En Espèce",
            "à Crédit",
            "En Cheque",
            "En Effet",
            "Bons d\'achat"});
            this.cmb_mode.Location = new System.Drawing.Point(120, 115);
            this.cmb_mode.Name = "cmb_mode";
            this.cmb_mode.Size = new System.Drawing.Size(263, 27);
            this.cmb_mode.TabIndex = 5;
            // 
            // cmb_regl
            // 
            this.cmb_regl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_regl.FormattingEnabled = true;
            this.cmb_regl.Items.AddRange(new object[] {
            "Régle",
            "Non Régle"});
            this.cmb_regl.Location = new System.Drawing.Point(120, 152);
            this.cmb_regl.Name = "cmb_regl";
            this.cmb_regl.Size = new System.Drawing.Size(263, 27);
            this.cmb_regl.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "N° BL :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Montant BL :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mode  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Etat :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Note :";
            // 
            // Reglement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 311);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_regl);
            this.Controls.Add(this.cmb_mode);
            this.Controls.Add(this.date_regl);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.txt_montantBL);
            this.Controls.Add(this.txt_NBL);
            this.Controls.Add(this.btn_valider_regl);
            this.Name = "Reglement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reglement";
            this.Load += new System.EventHandler(this.Reglement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_valider_regl;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.ComboBox cmb_mode;
        private System.Windows.Forms.ComboBox cmb_regl;
        public System.Windows.Forms.TextBox txt_NBL;
        public System.Windows.Forms.TextBox txt_montantBL;
        public System.Windows.Forms.DateTimePicker date_regl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}