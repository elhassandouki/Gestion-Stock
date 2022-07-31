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
    public partial class Articles : Form
    {
        app c = new app();
        //DataSet1TableAdapters.articleTableAdapter Article = new DataSet1TableAdapters.articleTableAdapter();
                 
        DataSet ds;
        public Articles()
        {
            InitializeComponent();
        }

        private void Articles_Load(object sender, EventArgs e)
        {
            btn_update.Visible = false;
            GetREF_ART(String.Empty);
        }
       
        public void GetREF_ART(String article_ref)
        {
            String query = "SELECT * FROM article";

            c.cmd =  new MySql.Data.MySqlClient.MySqlCommand(query,c.MyCon); // php
            c.MyCon.Open();
            MySqlDataReader reader = c.cmd.ExecuteReader();
            AutoCompleteStringCollection mydata = new AutoCompleteStringCollection();

            while (reader.Read())
            {
                mydata.Add(reader.GetString(0));
            }
            c.MyCon.Close();
            txt_ref.AutoCompleteCustomSource = mydata;
        }

        private void btn_add_article_Click(object sender, EventArgs e)
        {
            if(txt_ref.Text != "" && txt_desgination.Text !="")
            {
                try
                {
                    string str = "INSERT INTO article Values ('" + txt_ref.Text + "','" + txt_desgination.Text + "')";
                    c.cmd = new MySqlCommand(str, c.MyCon);
                    c.MyCon.Open();
                    c.cmd.ExecuteNonQuery();

                    MessageBox.Show("Bien Ajouter Article Réf : "+txt_ref.Text+" Désgination :"+txt_desgination.Text+"");
                    txt_ref.Text = "";
                    txt_desgination.Text = "";
                  

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
            else
            {
                MessageBox.Show("Remplir Tous Les Champs", "Remplir Tous Les Champs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }
     

        private void btn_afficher_article_Click(object sender, EventArgs e)
        {
          
         
          
           
        }
        public void GetDataByRef(String refer)
        {
            string str = "select * from article where ref = '"+refer+"'";
            ds = new DataSet();
            c.da =  new MySqlDataAdapter(str, c.MyCon);
            c.da.Fill(ds, "article");
            dataGrid_article.DataSource = ds.Tables[0];
            dataGrid_article.Refresh();
        }
        private void txt_ref_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_ref.Text == "")
            {
                
            }
            else
            {
                if (e.KeyCode == Keys.Enter) // 
                {
                   getArticlebyref(txt_ref.Text);
                   
                    btn_add_article.Enabled = false;
                    btn_update.Visible = false;
                    GetDataByRef(txt_ref.Text);
                    btn_update.Visible = true;
                }
            }
            
        }
        private void getArticlebyref(String cin)
        {
           

            try
            {
                String query = "select [ref] as 'Réf' , [desgination] as 'Désgination' from article where [ref] = '" + txt_ref.Text + "'";
              
                c.cmd = new MySqlCommand(query, c.MyCon); // php
                c.MyCon.Open();
                MySqlDataReader reader = c.cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_ref.Text = reader["Réf"].ToString();
                    txt_desgination.Text = reader["Désgination"].ToString();
           

              
            
                    //panelbtn_add_update.Visible = true;
                    // Datagrid_afficher.Visible = true;
                    txt_ref.Enabled = false;
                    txt_desgination.Enabled = false;

                }
                else if (txt_ref.Text == "")
                {
             
                    //txt_tel.Enabled = true;
                    //txt_ncompte.Enabled = true;
                    //cmb_bq.Enabled = true;
                    //txt_ncompte.Text = "";
                    //txt_rs.Text = "";
                    //txt_tel.Text = "";

                }

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

        private void dataGrid_article_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //dataGrid_article.Columns[0].ReadOnly = true;
            //dataGrid_article.Columns[2].ReadOnly = true;
            //dataGrid_article.Columns[3].ReadOnly = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           

            try
            {
                string st = "UPDATE article Set desgination ='" + txt_desgination.Text + "' where ref ='"+txt_ref.Text+"'";
                c.cmd = new MySqlCommand(st, c.MyCon);
                c.MyCon.Open();
                c.cmd.ExecuteNonQuery();
                MessageBox.Show("La Mise à Jour Bien effectuée", "La Mise à Jour", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_ref.Enabled = true;

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

        private void txt_ref_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid_article_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                //txt_ref.Enabled = true;
                //txt_ref.Clear();
                txt_desgination.Enabled = true;
                txt_desgination.Clear();
                txt_ref.Text = this.dataGrid_article.CurrentRow.Cells[0].Value.ToString();
                txt_desgination.Text = this.dataGrid_article.CurrentRow.Cells[1].Value.ToString();
            }
            catch
            {
                
                return;
            }
        }

    }
}
