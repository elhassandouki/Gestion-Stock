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
    public partial class EtatVenteArticle : Form
    {
        app c = new app();
        //SqlConnection conx = new SqlConnection(Connection.getCS());
        DataSet ds;
        //DataSet1TableAdapters.articleTableAdapter article = new DataSet1TableAdapters.articleTableAdapter();
        //DataSet1TableAdapters.Etat_Vente_ArticleTableAdapter EtatVente = new DataSet1TableAdapters.Etat_Vente_ArticleTableAdapter();

        public EtatVenteArticle()
        {
            InitializeComponent();
        }

        private void EtatVenteArticle_Load(object sender, EventArgs e)
        {
            GetREF_ART(String.Empty);
        }

        private void txt_article_TextChanged(object sender, EventArgs e)
        {

        }
        public void GetREF_ART(String article_ref)
        {
            String query = "SELECT * FROM article";
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
          
            try
            {
              
                if (e.KeyCode == Keys.Enter && txt_article.Text != string.Empty) 
                {
                   
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            try
            {

                if (date_min.Value.ToShortDateString() == "" &&  date_max.Value.ToShortDateString()=="")
                {
                    MessageBox.Show("Date Début Supérieur a Date Fin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    if(txt_article.Text=="*")
                    {}
                else
                {
                    dataGrid_EtatVenteArticle.DataSource = null;

                    c.da = new MySqlDataAdapter("select * from Etat_Vente_Article where Article ='" +
                        txt_article.Text + "' and [Date Vente] >= '" +
                        date_min.Value.ToShortDateString() +
                        "' AND [Date Vente] <= '" + date_max.Value.ToShortDateString() + "'", c.MyCon);

                    c.da.Fill(ds, "Etat");
                    dataGrid_EtatVenteArticle.DataSource = ds.Tables["Etat"];
                    dataGrid_EtatVenteArticle.Refresh();

                    date_min.Visible = true;
                    date_max.Visible = true;
                    btn_rechercher.Visible = true;
                    txt_article.Clear();
                    txt_article.Focus();
                }
              

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void date_max_ValueChanged(object sender, EventArgs e)
        {

        }

        private void date_min_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
