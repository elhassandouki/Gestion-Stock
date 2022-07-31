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
    public partial class Achat : Form
    {
        app c = new app();
        DataSet ds;
        //DataSet1TableAdapters.achatTableAdapter achat = new DataSet1TableAdapters.achatTableAdapter();
        //DataSet1TableAdapters.articleTableAdapter dsarticle = new DataSet1TableAdapters.articleTableAdapter();
        //DataSet1TableAdapters.fournisseurTableAdapter frs = new DataSet1TableAdapters.fournisseurTableAdapter();
        //DataSet1TableAdapters.ligne_achatTableAdapter l_a = new DataSet1TableAdapters.ligne_achatTableAdapter();

        public Achat()
        {
            InitializeComponent();
            this.Text = " Facture Achat N° : " + txt_NFA.Text;
        }
        private void calculesum()
        {
            if (txt_prix.Text != string.Empty && txt_pd.Text != string.Empty)
            {
                txt_sum.Text = (Convert.ToDouble(txt_pd.Text) * Convert.ToDouble(txt_prix.Text)).ToString();
            }
        }
        private void Ajouter_Achat_Load(object sender, EventArgs e)
        {
            txt_NFA.CharacterCasing = CharacterCasing.Upper;
            txt_art.CharacterCasing = CharacterCasing.Upper;
            GetArticle(String.Empty);
            chargecmbfr();

            // datatable
        
            dt.Columns.Add("Article");
            dt.Columns.Add("Qté");
            dt.Columns.Add("Poids");
            dt.Columns.Add("Prix");
            dt.Columns.Add("Total");

            MaximizeBox = false;

        }
        public void chargecmbfr()
        {
            ds = new DataSet();
            c.da = new MySqlDataAdapter("select * from fournisseur",c.MyCon);
            c.da.Fill(ds, "fr");
            cmb_frs.DataSource = ds.Tables[0];
            cmb_frs.DisplayMember = "name_fr";
            cmb_frs.ValueMember = "id_fr";
            cmb_frs.Refresh();
        }
    
        private void btn_add_achat_Click(object sender, EventArgs e)
        {
           // DataSet1TableAdapters.fournisseurTableAdapter frs = new DataSet1TableAdapters.fournisseurTableAdapter();
            try
            {
                if(cmb_frs.Text != string.Empty && txt_NFA.Text != string.Empty)
                {
                    btn_add_achat.Enabled = false;
                    MessageBox.Show(" Continuer ... ");
                    cmb_frs.Enabled = false;
                    txt_NFA.Enabled = false;
                    date_achat.Enabled = false;
                    txt_art.Enabled = true;
                    txt_qt.Enabled = true;
                    txt_pd.Enabled = true;
                    txt_prix.Enabled = true;
                    txt_art.Focus();
                }
                else
                {
                    MessageBox.Show("Remplir Tous Les Champs","Remplir Tous Les Champs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void GetArticle(String Article)
        {
            String query = "SELECT ref FROM article";
          
            c.cmd = new MySqlCommand(query, c.MyCon);
            c.MyCon.Open();
            MySqlDataReader reader = c.cmd.ExecuteReader();
            AutoCompleteStringCollection mydata = new AutoCompleteStringCollection();
            while (reader.Read())
            {
                mydata.Add(reader.GetString(0));
            }
            c.MyCon.Close();
            txt_art.AutoCompleteCustomSource = mydata;
        }

     
        private void panel_achat_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGrid_achat_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }
      

        private void dataGrid_achat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_pd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_art_TextChanged(object sender, EventArgs e)
        {
            if (txt_art.Text == "")
            {
                txt_qt.Text = "";
                txt_pd.Text = "";
                txt_prix.Text = "";
            }
        }

        private void txt_qt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }

        }

        private void txt_pd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void txt_prix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void txt_NFA_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txt_NFA_TextChanged(object sender, EventArgs e)
        {
            this.Text = "  Facture Achat N° : " + txt_NFA.Text;
        }

        private void txt_prix_KeyUp(object sender, KeyEventArgs e)
        {
            calculesum();
        }

        private void txt_pd_KeyUp(object sender, KeyEventArgs e)
        {
            calculesum();
        }

        DataTable dt = new DataTable();
        //public int QteArticleByRef(string refe)
        //{
         
        //    ds = new DataSet();
        //    c.da = new SqlDataAdapter("select count(*) from article where ref = '"+refe+"'", c.MyCon);
        //    c.da.Fill(ds, "count");


        //    //return Convert.ToInt32(ds.Tables[0]);

        //}
        private void txt_pd_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txt_prix_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               // int countarticle = QteArticleByRef(txt_art.Text);
                if (txt_art.Text != "" && txt_qt.Text != "" && txt_pd.Text != "" && txt_prix.Text != "")
                {
                    
                    
                    for (int i = 0; i < dataGrid_achat.Rows.Count -1; i++)
                    {
                        if (dataGrid_achat.Rows[i].Cells[0].Value.ToString() == txt_art.Text)
                        {
                            MessageBox.Show("Déjà Choisi " + txt_art.Text, "Déjà Choisi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                      
                    }
                    dataGrid_achat.DataSource = dt;
                    DataRow r = dt.NewRow();
                    r[0] = txt_art.Text;
                    r[1] = txt_qt.Text;
                    r[2] = txt_pd.Text;
                    r[3] = txt_prix.Text;
                    r[4] = txt_sum.Text;
                    dt.Rows.Add(r);

                    dataGrid_achat.DataSource = dt;
                    txt_art.Text = "";
                    txt_qt.Text = "";
                    txt_pd.Text = "";
                    txt_prix.Text = "";
                    txt_sum.Text = "";
                    txt_art.Focus();
                    btn_tr.Enabled = true;
                    txt_total.Text =
                        (
                        from DataGridViewRow row in dataGrid_achat.Rows
                        where row.Cells[4].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
                    txt_art.Focus();
                }
                else
                {
                    //if (countarticle == 0)
                    //{
                    //    MessageBox.Show("cet Article : "+txt_art.Text+" n'existe pas");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Remplir tous les Champs");
                    //}
                   
                }

            }
        }

        private void btn_tr_Click(object sender, EventArgs e)
        {


            if (dataGrid_achat.Rows.Count-1 == 0 && txt_NFA.Text != string.Empty && cmb_frs.Text != string.Empty)
            {
                MessageBox.Show("Aucun Article", "Aucun Article",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                btn_add_lignevente.Enabled = true;
                btn_delete.Enabled = true;
                txt_art.Enabled = false;
                txt_qt.Enabled = false;
                txt_pd.Enabled = false;
                txt_prix.Enabled = false;
                btn_tr.Enabled = false;
            }
        }

        private void dataGrid_achat_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }
        public int NewIDAchat()
        {
            ds = new DataSet();
            c.da = new MySqlDataAdapter("select max(n_achat)+1 from achat",c.MyCon);
           
            return c.da.Fill(ds,"NewIDAchat");

        }

        private void btn_add_lignevente_Click(object sender, EventArgs e)
        {
            string str;
            string str2;

            if (c.MyCon.State == ConnectionState.Closed)
            {
                c.MyCon.Open();
            }
            MySqlTransaction mytrans = c.MyCon.BeginTransaction();
            try
            {


                if (dataGrid_achat.Rows.Count - 1 == 0)
                {

                    MessageBox.Show("Aucun Article", "Aucun Article", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MySqlCommand mycmd = c.MyCon.CreateCommand();
                    mycmd.Transaction = mytrans;
                    str = "INSERT INTO achat Values ('" + NewIDAchat() + "','" + txt_NFA.Text +
                        "','" + date_achat.Value.ToShortDateString() + "','" + cmb_frs.SelectedValue + "')";
                    mycmd.CommandText = str;
                    mycmd.ExecuteNonQuery();
           

                    for (int i = 0; i < dataGrid_achat.Rows.Count - 1; i++)
                    {
                        str2 = "INSERT INTO ligne_achat VALUES ("+NewIDAchat()+",'"+dataGrid_achat.Rows[i].Cells[0].Value+
                            "','"+Convert.ToDecimal(dataGrid_achat.Rows[i].Cells[3].Value)+"','"+
                            Convert.ToInt32(dataGrid_achat.Rows[i].Cells[1].Value)+"','"+
                            Convert.ToDouble(dataGrid_achat.Rows[i].Cells[2].Value)+"','"+
                            Convert.ToDecimal(dataGrid_achat.Rows[i].Cells[4].Value)+"')";
                             MySqlCommand cm1 = c.MyCon.CreateCommand();
                              cm1.CommandText = str2;
                              cm1.Transaction = mytrans;
                              cm1.ExecuteNonQuery();
                      
                    }
                    mytrans.Commit();
                    MessageBox.Show("Bien Ajouter La Facture N° : " + txt_NFA.Text);
                    this.Close();
                }
            }
            catch (Exception)
            {
                mytrans.Rollback();
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                c.MyCon.Close();

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGrid_achat_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txt_total.Text =
                      (
                      from DataGridViewRow row in dataGrid_achat.Rows
                      where row.Cells[4].FormattedValue.ToString() != string.Empty
                      select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_art.Focus();
        }

        private void dataGrid_achat_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txt_art.Text = dataGrid_achat.CurrentRow.Cells[0].Value.ToString();
                txt_qt.Text = dataGrid_achat.CurrentRow.Cells[1].Value.ToString();
                txt_pd.Text = dataGrid_achat.CurrentRow.Cells[2].Value.ToString();
                txt_prix.Text = dataGrid_achat.CurrentRow.Cells[3].Value.ToString();
                txt_sum.Text = dataGrid_achat.CurrentRow.Cells[4].Value.ToString();
                dataGrid_achat.Rows.RemoveAt(dataGrid_achat.CurrentRow.Index);
                txt_qt.Focus();
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
