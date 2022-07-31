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
    public partial class EtatAchatArticle : Form
    {
        DataSet ds;
        app c = new app();
        //SqlConnection conx = new SqlConnection(Connection.getCS());
        //DataSet1TableAdapters.articleTableAdapter article = new DataSet1TableAdapters.articleTableAdapter();
        //DataSet1TableAdapters.Etat_Achat_ArticleTableAdapter EtatAchat = new DataSet1TableAdapters.Etat_Achat_ArticleTableAdapter();


        public EtatAchatArticle()
        {
            InitializeComponent();
        }

        private void EtatAchatArticle_Load(object sender, EventArgs e)
        {

            GetREF_ART(String.Empty);
        }
        public void GetREF_ART(String article_ref)
        {
            String query = "SELECT * FROM article";
           // SqlConnection conx = new SqlConnection(Connection.getCS());

            c.cmd = new MySqlCommand(query, c.MyCon); // php
            c.MyCon.Open();
            MySqlDataReader reader = c.cmd.ExecuteReader();
            AutoCompleteStringCollection mydata = new AutoCompleteStringCollection();

            while (reader.Read())
            {
                mydata.Add(reader.GetString(0));
            }
            c.MyCon.Close();
            txt_article.AutoCompleteCustomSource = mydata;
        }

        private void txt_article_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_article.Text == "")
            {

            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
              
                }
            }
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_rechercher_Click_1(object sender, EventArgs e)
        {
            ds = new DataSet();
            try
            {

                if (date_min.Value.ToShortDateString() == "" && date_max.Value.ToShortDateString() == "")
                {
                    MessageBox.Show("Date Début Supérieur a Date Fin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                 if(txt_article.Text=="*")
                 {
                     //dataGridEtatAchat.DataSource = null;
                     c.da = new MySqlDataAdapter("select * from Etat_Achat_Article where [Date Achat] >= '" +
                        date_min.Value.ToShortDateString() +
                        "' AND [Date Achat] <= '" + date_max.Value.ToShortDateString() + "'", c.MyCon);
                     c.da.Fill(ds, "ETAT2");
                     dataGridEtatAchat.DataSource = ds.Tables["ETAT2"];
                     dataGridEtatAchat.Refresh();
                     txt_article.Text = "";
                     
                 }
                else
                {

                    dataGridEtatAchat.DataSource = null;

                    c.da = new MySqlDataAdapter("select * from Etat_Achat_Article where Article ='" +
                        txt_article.Text + "' and [Date Achat] >= '" +
                        date_min.Value.ToShortDateString() +
                        "' AND [Date Achat] <= '" + date_max.Value.ToShortDateString() + "'", c.MyCon);
                    c.da.Fill(ds, "Etat");
                    dataGridEtatAchat.DataSource = ds.Tables["Etat"];
                    dataGridEtatAchat.Refresh();
                    txt_article.Text = "";
                    txt_article.Enabled = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
