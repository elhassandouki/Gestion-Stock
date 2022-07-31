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
    public partial class FRM_RESTORE : Form
    {
        app c = new app();
        //SqlConnection conx = new SqlConnection(Connection.getCS());
     
        public FRM_RESTORE()
        {
            InitializeComponent();
        }

        private void txt_lieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_local_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_lieu.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "ALTER DATATBASE g_stock SET OFFLINE WITH ROLLBACK IMMEDIATE;Restore DataBase g_stock From Disk = '" + txt_lieu.Text + "'";
                c.cmd = new MySqlCommand(str, c.MyCon);
                c.MyCon.Open();
                c.cmd.ExecuteNonQuery();
                c.MyCon.Close();
                MessageBox.Show("Bien");
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

        private void FRM_RESTORE_Load(object sender, EventArgs e)
        {

        }
    }
}
