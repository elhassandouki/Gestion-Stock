namespace Gestion_Stock_fruits
{
    partial class FRM_VENTE
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
            this.panel_Vente_top = new System.Windows.Forms.Panel();
            this.label_NBL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.cmb_client = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_prix = new System.Windows.Forms.TextBox();
            this.txt_pd = new System.Windows.Forms.TextBox();
            this.txt_qt = new System.Windows.Forms.TextBox();
            this.txt_art = new System.Windows.Forms.TextBox();
            this.label_NCmd = new System.Windows.Forms.Label();
            this.date_vente = new System.Windows.Forms.DateTimePicker();
            this.label_FRS = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.btn_add_Vente = new System.Windows.Forms.Button();
            this.btn_add_lignevente = new System.Windows.Forms.Button();
            this.panel_vente_center = new System.Windows.Forms.Panel();
            this.dataGrid_vente = new System.Windows.Forms.DataGridView();
            this.panel_vente_bottom = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_tr = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_regl = new System.Windows.Forms.ComboBox();
            this.cmb_mode = new System.Windows.Forms.ComboBox();
            this.panel_Vente_top.SuspendLayout();
            this.panel_vente_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_vente)).BeginInit();
            this.panel_vente_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Vente_top
            // 
            this.panel_Vente_top.Controls.Add(this.label_NBL);
            this.panel_Vente_top.Controls.Add(this.label7);
            this.panel_Vente_top.Controls.Add(this.txt_sum);
            this.panel_Vente_top.Controls.Add(this.cmb_client);
            this.panel_Vente_top.Controls.Add(this.label4);
            this.panel_Vente_top.Controls.Add(this.label3);
            this.panel_Vente_top.Controls.Add(this.label2);
            this.panel_Vente_top.Controls.Add(this.label1);
            this.panel_Vente_top.Controls.Add(this.txt_prix);
            this.panel_Vente_top.Controls.Add(this.txt_pd);
            this.panel_Vente_top.Controls.Add(this.txt_qt);
            this.panel_Vente_top.Controls.Add(this.txt_art);
            this.panel_Vente_top.Controls.Add(this.label_NCmd);
            this.panel_Vente_top.Controls.Add(this.date_vente);
            this.panel_Vente_top.Controls.Add(this.label_FRS);
            this.panel_Vente_top.Controls.Add(this.label_date);
            this.panel_Vente_top.Controls.Add(this.btn_add_Vente);
            this.panel_Vente_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Vente_top.Location = new System.Drawing.Point(0, 0);
            this.panel_Vente_top.Name = "panel_Vente_top";
            this.panel_Vente_top.Size = new System.Drawing.Size(608, 147);
            this.panel_Vente_top.TabIndex = 3;
            // 
            // label_NBL
            // 
            this.label_NBL.AutoSize = true;
            this.label_NBL.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NBL.ForeColor = System.Drawing.Color.Crimson;
            this.label_NBL.Location = new System.Drawing.Point(70, 10);
            this.label_NBL.Name = "label_NBL";
            this.label_NBL.Size = new System.Drawing.Size(0, 22);
            this.label_NBL.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(497, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Total";
            // 
            // txt_sum
            // 
            this.txt_sum.Enabled = false;
            this.txt_sum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sum.Location = new System.Drawing.Point(501, 107);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(86, 26);
            this.txt_sum.TabIndex = 21;
            // 
            // cmb_client
            // 
            this.cmb_client.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_client.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_client.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_client.FormattingEnabled = true;
            this.cmb_client.Location = new System.Drawing.Point(246, 41);
            this.cmb_client.Name = "cmb_client";
            this.cmb_client.Size = new System.Drawing.Size(237, 27);
            this.cmb_client.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(404, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Prix Vente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(305, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Podis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(211, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Qté";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(16, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Article";
            // 
            // txt_prix
            // 
            this.txt_prix.Enabled = false;
            this.txt_prix.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prix.Location = new System.Drawing.Point(408, 107);
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.Size = new System.Drawing.Size(86, 26);
            this.txt_prix.TabIndex = 14;
            this.txt_prix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_prix_KeyDown);
            this.txt_prix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prix_KeyPress);
            this.txt_prix.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_prix_KeyUp);
            // 
            // txt_pd
            // 
            this.txt_pd.Enabled = false;
            this.txt_pd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pd.Location = new System.Drawing.Point(309, 107);
            this.txt_pd.Name = "txt_pd";
            this.txt_pd.Size = new System.Drawing.Size(86, 26);
            this.txt_pd.TabIndex = 13;
            this.txt_pd.TextChanged += new System.EventHandler(this.txt_pd_TextChanged);
            this.txt_pd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pd_KeyPress);
            this.txt_pd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_pd_KeyUp);
            // 
            // txt_qt
            // 
            this.txt_qt.Enabled = false;
            this.txt_qt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qt.Location = new System.Drawing.Point(215, 107);
            this.txt_qt.Name = "txt_qt";
            this.txt_qt.Size = new System.Drawing.Size(86, 26);
            this.txt_qt.TabIndex = 12;
            this.txt_qt.TextChanged += new System.EventHandler(this.txt_qt_TextChanged);
            this.txt_qt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qt_KeyPress);
            // 
            // txt_art
            // 
            this.txt_art.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_art.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_art.Enabled = false;
            this.txt_art.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_art.Location = new System.Drawing.Point(15, 107);
            this.txt_art.Name = "txt_art";
            this.txt_art.Size = new System.Drawing.Size(192, 26);
            this.txt_art.TabIndex = 11;
            this.txt_art.TabIndexChanged += new System.EventHandler(this.txt_art_TabIndexChanged);
            this.txt_art.TextChanged += new System.EventHandler(this.txt_art_TextChanged);
            this.txt_art.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_art_KeyDown);
            this.txt_art.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_art_KeyPress);
            this.txt_art.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_art_KeyUp);
            // 
            // label_NCmd
            // 
            this.label_NCmd.AutoSize = true;
            this.label_NCmd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NCmd.ForeColor = System.Drawing.Color.Crimson;
            this.label_NCmd.Location = new System.Drawing.Point(3, 10);
            this.label_NCmd.Name = "label_NCmd";
            this.label_NCmd.Size = new System.Drawing.Size(71, 22);
            this.label_NCmd.TabIndex = 10;
            this.label_NCmd.Text = "BL N° :";
            // 
            // date_vente
            // 
            this.date_vente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_vente.Location = new System.Drawing.Point(246, 12);
            this.date_vente.Name = "date_vente";
            this.date_vente.Size = new System.Drawing.Size(237, 26);
            this.date_vente.TabIndex = 8;
            // 
            // label_FRS
            // 
            this.label_FRS.AutoSize = true;
            this.label_FRS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FRS.ForeColor = System.Drawing.Color.Crimson;
            this.label_FRS.Location = new System.Drawing.Point(152, 49);
            this.label_FRS.Name = "label_FRS";
            this.label_FRS.Size = new System.Drawing.Size(58, 19);
            this.label_FRS.TabIndex = 3;
            this.label_FRS.Text = "Client :";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.Crimson;
            this.label_date.Location = new System.Drawing.Point(146, 19);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(94, 19);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "Date Vente :";
            // 
            // btn_add_Vente
            // 
            this.btn_add_Vente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_Vente.ForeColor = System.Drawing.Color.Crimson;
            this.btn_add_Vente.Location = new System.Drawing.Point(501, 18);
            this.btn_add_Vente.Name = "btn_add_Vente";
            this.btn_add_Vente.Size = new System.Drawing.Size(86, 40);
            this.btn_add_Vente.TabIndex = 0;
            this.btn_add_Vente.Text = "Suivant";
            this.btn_add_Vente.UseVisualStyleBackColor = true;
            this.btn_add_Vente.Click += new System.EventHandler(this.btn_add_Vente_Click);
            // 
            // btn_add_lignevente
            // 
            this.btn_add_lignevente.Enabled = false;
            this.btn_add_lignevente.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_lignevente.ForeColor = System.Drawing.Color.Crimson;
            this.btn_add_lignevente.Location = new System.Drawing.Point(414, 68);
            this.btn_add_lignevente.Name = "btn_add_lignevente";
            this.btn_add_lignevente.Size = new System.Drawing.Size(86, 39);
            this.btn_add_lignevente.TabIndex = 0;
            this.btn_add_lignevente.Text = "Valdier";
            this.btn_add_lignevente.UseVisualStyleBackColor = true;
            this.btn_add_lignevente.Click += new System.EventHandler(this.btn_add_lignevente_Click);
            // 
            // panel_vente_center
            // 
            this.panel_vente_center.Controls.Add(this.dataGrid_vente);
            this.panel_vente_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_vente_center.Location = new System.Drawing.Point(0, 0);
            this.panel_vente_center.Name = "panel_vente_center";
            this.panel_vente_center.Size = new System.Drawing.Size(608, 390);
            this.panel_vente_center.TabIndex = 5;
            // 
            // dataGrid_vente
            // 
            this.dataGrid_vente.AllowUserToAddRows = false;
            this.dataGrid_vente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_vente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_vente.Enabled = false;
            this.dataGrid_vente.Location = new System.Drawing.Point(0, 150);
            this.dataGrid_vente.Name = "dataGrid_vente";
            this.dataGrid_vente.ReadOnly = true;
            this.dataGrid_vente.Size = new System.Drawing.Size(605, 234);
            this.dataGrid_vente.TabIndex = 0;
            this.dataGrid_vente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_vente_CellClick);
            this.dataGrid_vente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_vente_CellDoubleClick);
            this.dataGrid_vente.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_vente_CellEndEdit);
            this.dataGrid_vente.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_vente_CellLeave);
            this.dataGrid_vente.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGrid_vente_CellValidating);
            this.dataGrid_vente.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_vente_CellValueChanged);
            this.dataGrid_vente.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGrid_vente_EditingControlShowing);
            this.dataGrid_vente.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGrid_vente_RowsRemoved);
            // 
            // panel_vente_bottom
            // 
            this.panel_vente_bottom.Controls.Add(this.label6);
            this.panel_vente_bottom.Controls.Add(this.label8);
            this.panel_vente_bottom.Controls.Add(this.cmb_regl);
            this.panel_vente_bottom.Controls.Add(this.cmb_mode);
            this.panel_vente_bottom.Controls.Add(this.btn_delete);
            this.panel_vente_bottom.Controls.Add(this.btn_tr);
            this.panel_vente_bottom.Controls.Add(this.label5);
            this.panel_vente_bottom.Controls.Add(this.txt_total);
            this.panel_vente_bottom.Controls.Add(this.btn_add_lignevente);
            this.panel_vente_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_vente_bottom.Location = new System.Drawing.Point(0, 390);
            this.panel_vente_bottom.Name = "panel_vente_bottom";
            this.panel_vente_bottom.Size = new System.Drawing.Size(608, 126);
            this.panel_vente_bottom.TabIndex = 4;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Crimson;
            this.btn_delete.Location = new System.Drawing.Point(506, 68);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(86, 39);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Fermer";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_tr
            // 
            this.btn_tr.Enabled = false;
            this.btn_tr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tr.ForeColor = System.Drawing.Color.Crimson;
            this.btn_tr.Location = new System.Drawing.Point(503, 16);
            this.btn_tr.Name = "btn_tr";
            this.btn_tr.Size = new System.Drawing.Size(86, 39);
            this.btn_tr.TabIndex = 17;
            this.btn_tr.Text = "Terminer";
            this.btn_tr.UseVisualStyleBackColor = true;
            this.btn_tr.Click += new System.EventHandler(this.btn_tr_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(15, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total :";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.ForeColor = System.Drawing.Color.Crimson;
            this.txt_total.Location = new System.Drawing.Point(88, 9);
            this.txt_total.Multiline = true;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(262, 30);
            this.txt_total.TabIndex = 15;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(12, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "Etat :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(10, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Mode  :";
            // 
            // cmb_regl
            // 
            this.cmb_regl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_regl.FormattingEnabled = true;
            this.cmb_regl.Items.AddRange(new object[] {
            "Régle",
            "Non Régle"});
            this.cmb_regl.Location = new System.Drawing.Point(89, 85);
            this.cmb_regl.Name = "cmb_regl";
            this.cmb_regl.Size = new System.Drawing.Size(261, 27);
            this.cmb_regl.TabIndex = 20;
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
            this.cmb_mode.Location = new System.Drawing.Point(89, 48);
            this.cmb_mode.Name = "cmb_mode";
            this.cmb_mode.Size = new System.Drawing.Size(261, 27);
            this.cmb_mode.TabIndex = 19;
            // 
            // FRM_VENTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 516);
            this.Controls.Add(this.panel_Vente_top);
            this.Controls.Add(this.panel_vente_center);
            this.Controls.Add(this.panel_vente_bottom);
            this.Name = "FRM_VENTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vente";
            this.Load += new System.EventHandler(this.Vente_Load);
            this.panel_Vente_top.ResumeLayout(false);
            this.panel_Vente_top.PerformLayout();
            this.panel_vente_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_vente)).EndInit();
            this.panel_vente_bottom.ResumeLayout(false);
            this.panel_vente_bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Vente_top;
        private System.Windows.Forms.DateTimePicker date_vente;
        private System.Windows.Forms.Label label_FRS;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Button btn_add_Vente;
        private System.Windows.Forms.Button btn_add_lignevente;
        private System.Windows.Forms.Panel panel_vente_center;
        private System.Windows.Forms.DataGridView dataGrid_vente;
        private System.Windows.Forms.Panel panel_vente_bottom;
        private System.Windows.Forms.Label label_NCmd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_prix;
        private System.Windows.Forms.TextBox txt_pd;
        private System.Windows.Forms.TextBox txt_qt;
        private System.Windows.Forms.TextBox txt_art;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.ComboBox cmb_client;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sum;
        private System.Windows.Forms.Label label_NBL;
        private System.Windows.Forms.Button btn_tr;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_regl;
        private System.Windows.Forms.ComboBox cmb_mode;
    }
}