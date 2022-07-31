namespace Gestion_Stock_fruits
{
    partial class FRM_RESTORE
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
            this.btn_fermer = new System.Windows.Forms.Button();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.btn_local = new System.Windows.Forms.Button();
            this.txt_lieu = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "La restauration d\'une sauvegarde réservée.";
            // 
            // btn_fermer
            // 
            this.btn_fermer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fermer.Location = new System.Drawing.Point(461, 86);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(96, 29);
            this.btn_fermer.TabIndex = 8;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restore.Location = new System.Drawing.Point(313, 86);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(142, 29);
            this.btn_Restore.TabIndex = 7;
            this.btn_Restore.Text = "Restore ";
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // btn_local
            // 
            this.btn_local.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_local.Location = new System.Drawing.Point(461, 41);
            this.btn_local.Name = "btn_local";
            this.btn_local.Size = new System.Drawing.Size(96, 29);
            this.btn_local.TabIndex = 6;
            this.btn_local.Text = "...";
            this.btn_local.UseVisualStyleBackColor = true;
            this.btn_local.Click += new System.EventHandler(this.btn_local_Click);
            // 
            // txt_lieu
            // 
            this.txt_lieu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lieu.Location = new System.Drawing.Point(12, 41);
            this.txt_lieu.Name = "txt_lieu";
            this.txt_lieu.ReadOnly = true;
            this.txt_lieu.Size = new System.Drawing.Size(443, 26);
            this.txt_lieu.TabIndex = 5;
            this.txt_lieu.TextChanged += new System.EventHandler(this.txt_lieu_TextChanged);
            // 
            // FRM_RESTORE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 135);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_Restore);
            this.Controls.Add(this.btn_local);
            this.Controls.Add(this.txt_lieu);
            this.Name = "FRM_RESTORE";
            this.Text = "FRM_RESTORE";
            this.Load += new System.EventHandler(this.FRM_RESTORE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.Button btn_local;
        private System.Windows.Forms.TextBox txt_lieu;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}