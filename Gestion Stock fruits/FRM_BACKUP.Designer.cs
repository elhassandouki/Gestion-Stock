namespace Gestion_Stock_fruits
{
    partial class FRM_BACKUP
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
            this.txt_lieu = new System.Windows.Forms.TextBox();
            this.btn_local = new System.Windows.Forms.Button();
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // txt_lieu
            // 
            this.txt_lieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lieu.Location = new System.Drawing.Point(12, 53);
            this.txt_lieu.Name = "txt_lieu";
            this.txt_lieu.ReadOnly = true;
            this.txt_lieu.Size = new System.Drawing.Size(532, 26);
            this.txt_lieu.TabIndex = 0;
            // 
            // btn_local
            // 
            this.btn_local.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_local.Location = new System.Drawing.Point(550, 53);
            this.btn_local.Name = "btn_local";
            this.btn_local.Size = new System.Drawing.Size(96, 29);
            this.btn_local.TabIndex = 1;
            this.btn_local.Text = "...";
            this.btn_local.UseVisualStyleBackColor = true;
            this.btn_local.Click += new System.EventHandler(this.btn_local_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.Location = new System.Drawing.Point(402, 122);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(142, 29);
            this.btn_backup.TabIndex = 2;
            this.btn_backup.Text = "BackUp";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_fermer
            // 
            this.btn_fermer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fermer.Location = new System.Drawing.Point(550, 122);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(96, 29);
            this.btn_fermer.TabIndex = 3;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Créer une sauvegarde complète de base de données (BACKUP) :";
            // 
            // FRM_BACKUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 167);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_backup);
            this.Controls.Add(this.btn_local);
            this.Controls.Add(this.txt_lieu);
            this.Name = "FRM_BACKUP";
            this.Text = "FRM_BACKUP";
            this.Load += new System.EventHandler(this.FRM_BACKUP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_lieu;
        private System.Windows.Forms.Button btn_local;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}