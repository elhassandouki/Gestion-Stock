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
    public partial class Fournisseur : Form
    {
        app c = new app();
        DataSet ds;
       // SqlConnection conx = new SqlConnection(Connection.getCS());

        public Fournisseur()
        {
            InitializeComponent();
        }

        private void Fournisseur_Load(object sender, EventArgs e)
        {
            GestRSFRS(String.Empty);
        }
        public void InsertQuery_FRs()
        {
            try
            {
                String str = "INSERT INTO `fournisseur`(name_fr,tel_fr,adresee_fr,ville_fr) VALUES ('" + txt_frs.Text + "','" +
                txt_frs_tel.Text + "','" + txt_frs_adresse.Text + "','" + txt_frs_ville.Text + "')";
                c.cmd = new MySqlCommand(str, c.MyCon);
                c.MyCon.Open();
                c.cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
            }
            finally
            {
                c.MyCon.Close();
            }
           
        

        }
        private void btn_add_frs_Click(object sender, EventArgs e)
        {
            if (txt_frs.Text != "" && txt_frs_adresse.Text != "" && txt_frs_tel.Text != "" && txt_frs_ville.Text != "")
            {
                try
                {
                    //DataSet1TableAdapters.fournisseurTableAdapter frs = new DataSet1TableAdapters.fournisseurTableAdapter();
                    InsertQuery_FRs();
                    MessageBox.Show("Bien Ajouter Fournisseur :"+txt_frs.Text);
                    txt_frs.Text = "";
                    txt_frs_adresse.Text = "";
                    txt_frs_tel.Text = "";
                    txt_frs_ville.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                  

                }
            }
            else
            {
                MessageBox.Show("Remplir Tous Les Champs", "Remplir Tous Les Champs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void GestRSFRS(String FRs)
        {
            String query = "SELECT name_fr FROM fournisseur";
            c.cmd = new MySqlCommand (query,c.MyCon ); // php
            c.MyCon.Open();
            MySqlDataReader reader = c.cmd.ExecuteReader();
            AutoCompleteStringCollection mydata = new AutoCompleteStringCollection();

            while (reader.Read())
            {
                mydata.Add(reader.GetString(0));
            }
            c.MyCon.Close();
            txt_frs.AutoCompleteCustomSource = mydata;
        }
        private void getFourByname(String four)
        {
            

            try
            {
                String query = "select name_fr as 'frs',tel_fr as 'tel',adresee_fr as 'adesse',ville_fr as 'ville' from fournisseur where name_fr = '" + txt_frs.Text + "'";

                c.cmd = new MySqlCommand(query, c.MyCon); // php
                c.MyCon.Open();
                MySqlDataReader reader = c.cmd.ExecuteReader();
                if (reader.Read())
                {
                    txt_frs.Text = reader["frs"].ToString();
                    txt_frs_adresse.Text = reader["adesse"].ToString();
                    txt_frs_tel.Text = reader["tel"].ToString();
                    txt_frs_ville.Text = reader["ville"].ToString();



                    //btn_afficher_article.Visible = true;
                    //panelbtn_add_update.Visible = true;
                    // Datagrid_afficher.Visible = true;
                    txt_frs.Enabled = false;
                    txt_frs_adresse.Enabled = false;
                    txt_frs_tel.Enabled = false;
                    txt_frs_ville.Enabled = false;

                }
                else if (txt_frs.Text == "")
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

        private void txt_frs_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_frs.Text == "")
            {
                //MessageBox.Show("vied", "vied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (e.KeyCode == Keys.Enter) // 
                {
                    getFourByname(txt_frs.Text);
                    //MessageBox.Show("Enter");
                    //.Visible = false;
                    btn_add_frs.Enabled = false;
               
                    charge();
                    btn_frs_update.Visible = true;


               
                    // dataGrid_article.Visible = false;
                }
            }
        }
        private void charge()
        {
            try
            {
                ds = new DataSet();
                dataGridFRS.Enabled = true;
                String Str = "select * from fournisseur where name_fr='" + txt_frs.Text + "'";
                c.da = new MySqlDataAdapter(Str, c.MyCon);
                c.da.Fill(ds, "frs");
                dataGridFRS.DataSource = ds.Tables["frs"];
                dataGridFRS.Refresh();

            }
            catch (Exception ex)
            {

                MessageBox.Show("/nErourr" + ex.Message);
            }
            finally
            {
             
            }
        }

        private void btn_frs_update_Click(object sender, EventArgs e)
        {
           // DataSet1TableAdapters.fournisseurTableAdapter upfrs = new DataSet1TableAdapters.fournisseurTableAdapter();
           // upfrs.UpdateQueryFRSs(dataGridFRS.Rows[0].Cells[1].Value.ToString(), dataGridFRS.Rows[0].Cells[2].Value.ToString(), dataGridFRS.Rows[0].Cells[3].Value.ToString(), dataGridFRS.Rows[0].Cells[4].Value.ToString(), dataGridFRS.Rows[0].Cells[0].Value, txt_frs.Text, txt_frs_tel.Text, txt_frs_adresse.Text, txt_frs_ville.Text, dataGridFRS.Rows[0].Cells[0].Value);
          
           
        }

    }
}
