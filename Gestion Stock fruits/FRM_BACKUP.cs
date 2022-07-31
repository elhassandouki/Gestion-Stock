using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Gestion_Stock_fruits
{
    public partial class FRM_BACKUP : Form
    {
        app c = new app();
        //SqlConnection conx = new SqlConnection(Connection.getCS());
        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void btn_local_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()== DialogResult.OK)
            {
                txt_lieu.Text = folderBrowserDialog1.SelectedPath;

            }
          
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = txt_lieu.Text + "\\g_stock_DB" + DateTime.Now.ToShortDateString().Replace('/', '-')
                       + "-" + DateTime.Now.ToLongTimeString().Replace(':', '-');
                string strQuery = "Backup Database g_stock to Disk='" + filename + ".bak'";
                c.cmd = new MySqlCommand(strQuery, c.MyCon);
                c.MyCon.Open();
                c.cmd.ExecuteNonQuery();
                c.MyCon.Close();
                MessageBox.Show("Il a été créé avec succès une sauvegarde", "Le processus de création d'une sauvegarde", MessageBoxButtons.OK, MessageBoxIcon.Information);﻿
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                c.MyCon.Close();
            }
        }

        private void FRM_BACKUP_Load(object sender, EventArgs e)
        {

        }
    }
}
