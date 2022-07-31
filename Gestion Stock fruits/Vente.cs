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
    public partial class FRM_VENTE : Form
    {
        app c = new app();
        DataSet ds;
       // DataSet1TableAdapters.articleTableAdapter Article = new DataSet1TableAdapters.articleTableAdapter();
        //DataSet1TableAdapters.venteTableAdapter vente = new DataSet1TableAdapters.venteTableAdapter();
        //DataSet1TableAdapters.clientTableAdapter client = new DataSet1TableAdapters.clientTableAdapter();
        //DataSet1TableAdapters.vente_ligneTableAdapter vente_ligne = new DataSet1TableAdapters.vente_ligneTableAdapter();
        //DataSet1TableAdapters.ReglementTableAdapter reglement = new DataSet1TableAdapters.ReglementTableAdapter();
       

       
        public FRM_VENTE()
        {
            InitializeComponent();
            this.Text = " Operation Vente - Bon Livraison N° : " +GetNewIDVente();
        }
        public String GetNewIDVente()
        {
            ds = new DataSet();
            c.da = new MySqlDataAdapter("select max(id_vente)+1 from vente", c.MyCon);
            c.da.Fill(ds, "NewID");
            return ds.Tables[0].ToString();
        }
        private void calculesum()
        {
            if (txt_prix.Text != string.Empty && txt_pd.Text != string.Empty)
            {
                txt_sum.Text = (Convert.ToDouble(txt_pd.Text) * Convert.ToDouble(txt_prix.Text)).ToString();
            }
        }
        private void Vente_Load(object sender, EventArgs e)
        {
            txt_art.CharacterCasing = CharacterCasing.Upper;
           
            GetArticle(String.Empty);
            label_NBL.Text = GetNewIDVente();
            
            MaximizeBox = false;
            ds = new DataSet();
            c.da = new MySqlDataAdapter("select * from client", c.MyCon);
            c.da.Fill(ds, "client");
            cmb_client.DataSource = ds.Tables["client"];
            cmb_client.ValueMember = "id_client";
            cmb_client.DisplayMember = "name_cleint";
            cmb_client.Refresh();
            dt.Columns.Add("Article");
            dt.Columns.Add("Qté");
            dt.Columns.Add("Poids");
            dt.Columns.Add("Prix");
            dt.Columns.Add("Total");
            cmb_regl.Enabled = false;
            cmb_mode.Enabled = false;
        }
    
        public void GetArticle(String Article)
        {
           // SqlConnection conx = new SqlConnection(Connection.getCS());

            String query = "SELECT ref FROM article where qte > 0 ";
            c.cmd = new MySqlCommand(query, c.MyCon); // php
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
        public void insertclient()
        {
            try
            {
                String str = "insert into client values ('" + cmb_client.Text + "')";
                c.cmd = new MySqlCommand(str, c.MyCon);
                c.MyCon.Open();
                c.cmd.ExecuteNonQuery();
                MessageBox.Show("Nouveau Client : " + cmb_client.Text);
            }
            catch (Exception)
            {


            }
            finally
            {
                c.MyCon.Close();
            }
        }

        public void getclient()
        {
            ds = new DataSet();
            try
            {
                String str = "select * from client";
                c.da = new MySqlDataAdapter(str, c.MyCon);
                c.da.Fill(ds, "client");
                cmb_client.DataSource = ds.Tables["client"];
                cmb_client.Refresh();
            }
            catch (Exception)
            {
            }
            finally
            {
            }
        }
        private void btn_add_Vente_Click(object sender, EventArgs e)
        {
         
            try
            {
             
               
                if (cmb_client.SelectedValue == null )
                {
                    insertclient();
                    getclient();
                    cmb_client.Enabled = false;
                    btn_add_Vente.Enabled = false;
                    date_vente.Enabled = false;
                    txt_art.Enabled = true;
                    txt_qt.Enabled = true;
                    txt_pd.Enabled = true;
                    txt_prix.Enabled = true;
                    dataGrid_vente.Enabled = true;
             
                    txt_art.Focus();


                }
                else
                {                    
                 
                    btn_add_Vente.Enabled = false;
                    cmb_client.Enabled = false;
                    date_vente.Enabled = false;
                    txt_art.Enabled = true;
                    txt_qt.Enabled = true;
                    txt_pd.Enabled = true;
                    txt_prix.Enabled = true;
                    dataGrid_vente.Enabled = true;
            
                    txt_art.Focus();

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

        private void dataGrid_vente_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
           
         
        }
     

        
        private void dataGrid_vente_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void dataGrid_vente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
          

        }

        private void dataGrid_vente_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        public String QteArticleByRef()
        {
            ds = new DataSet();
            String str = "select qte from article where ref ='" + txt_art.Text + "'";
            c.da = new MySqlDataAdapter(str, c.MyCon);
            c.da.Fill(ds, "QteArticleByRef");
            return ds.Tables["QteArticleByRef"].ToString();
        }
        public String PoidsArticleByRef()
        {
            ds = new DataSet();
            String str = "select poids from article where ref ='" + txt_art.Text + "'";
            c.da = new MySqlDataAdapter(str, c.MyCon);
            c.da.Fill(ds, "PoidsArticleByRef");
            return ds.Tables["PoidsArticleByRef"].ToString();
        }
        
        public String countArticleByref()
        {
            ds = new DataSet();
            String str = "select count(*) from article where ref ='" + txt_art.Text + "'";
            c.da = new MySqlDataAdapter(str, c.MyCon);
            c.da.Fill(ds, "countArticleByref");
            return ds.Tables["countArticleByref"].ToString();
        }

        public Boolean ArticleExists()
        {
            Boolean b = false;
            try
            {

                String query = String.Format("select count(*) as count from article where ref ='{0}'", txt_art.Text);
                MySqlCommand cmd = new MySqlCommand(query, c.MyCon);
                c.MyCon.Open();
                var count = cmd.ExecuteScalar();
                //MessageBox.Show(count.ToString());
                b = count!=null?(int)count>0:false;
                //     aji khli dakchi ndiro lih be laravel mafy ana lib9a ihrass rassi onsd3ak ta nta hhhh 
                // khass gha kifach nthkm fih nsdo bach ila bgha icopie ola chi l3ba ihssl 
                // ach glti 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                c.MyCon.Close();
            }
            return b;
        }
        
        private void txt_qt_TextChanged(object sender, EventArgs e)
        {
            


            if (txt_art.Text != "" && txt_qt.Text != "")
            {
                int qte_stock = Convert.ToInt32(QteArticleByRef());
                int qte = Convert.ToInt32(txt_qt.Text);
                if (qte > qte_stock)
                {
                    MessageBox.Show("La Qte Choisi Supérieur à La Qte De Stock :"+qte_stock);
                    txt_qt.Text = qte_stock.ToString();   
                }
            }
        }

        private void txt_pd_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //int countarticle = Convert.ToInt32(countArticleByref());

                if (!ArticleExists())
                {

                }



                if (txt_art.Text != "" && txt_pd.Text != "" && ArticleExists())
                {
                    double poids_stock = double.Parse(PoidsArticleByRef());
                    double poids = Convert.ToDouble(txt_pd.Text);
                    if (poids > poids_stock)
                    {
                        MessageBox.Show("La Poids Choisi Supérieur à La Poids De Stock :" + poids_stock);
                        txt_pd.Text = poids_stock.ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            
        }

        private void btn_addligne_Click(object sender, EventArgs e)
        {
            
             
            if(txt_art.Text != "" && txt_qt.Text !="" && txt_pd.Text !="" && txt_prix.Text !="")
            {
                for (int i = 0; i < dataGrid_vente.Rows.Count-1; i++)
                {
                    if (dataGrid_vente.Rows[i].Cells[0].Value.ToString() == txt_qt.Text)
                    {
                        MessageBox.Show("Déjà Choisi !", "Déjà Choisi : "+txt_art.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
               
              
              
               int sum = 0;
               for (int i = 0; i < dataGrid_vente.Rows.Count; ++i)
               {
                  // sum += Convert.ToDouble(dataGrid_vente.Rows[i].Cells["txt_totale"].Value);
               }
               txt_total.Text = sum.ToString();
               
            }
            else
            {
                MessageBox.Show("Rem");
            }
           
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

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
        public void InsertQueryVente()
        {
            try
            {
                String str = "INSERT INTO `vente`(id_vente,date_vente,cleint_vente,montant_vente) VALUES ('" + Convert.ToInt32(label_NBL.Text) +
                    "','" + date_vente.Value.ToShortDateString() + "','" + Convert.ToInt32(cmb_client.SelectedValue) +
                    "' ,'" + Convert.ToDecimal(txt_total.Text) + "')";
                c.cmd = new MySqlCommand(str, c.MyCon);
                c.MyCon.Open();
                c.cmd.ExecuteNonQuery();
              //  MessageBox.Show("Bien Ajouter Vnete");

            }
            catch (Exception)
            {

            }
            finally
            {
                c.MyCon.Close();
            }
        }
        public void InsertLigneVente()
        {
 
        }
        public void InsertQueryReglement()
        {
            String str = "INSERT INTO reglement(date_regle,id_BLvente,montant,mode_regl,etat,note) VALUES ('" +
                date_vente.Value.ToShortDateString() + "','" + Convert.ToInt32(label_NBL.Text) + "','" +
                Convert.ToDecimal(txt_total.Text) + "','" + cmb_mode.Text + "','" + cmb_regl.Text + "','" +null + "')";
            c.cmd = new MySqlCommand(str, c.MyCon);
            c.MyCon.Open();
            c.cmd.ExecuteNonQuery();
            c.MyCon.Close();              
        }
        public String GETIDByPrint()
        {
            ds = new DataSet();
            String str = "SELECT max(id_vente) from printbl";
            c.da = new MySqlDataAdapter(str, c.MyCon);
            c.da.Fill(ds, "GETIDByPrint");
            return ds.Tables["GETIDByPrint"].ToString();

        }
        private void btn_add_lignevente_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            try
            {
                if (dataGrid_vente.DataSource != null && cmb_mode.Text != "" && cmb_regl.Text != "")
            {
                InsertQueryVente();
                
                for (int i = 0; i < dataGrid_vente.Rows.Count; i++)
                {



                    try
                    {
                        String str = "INSERT INTO vente_ligne(Nvente_Venteligne,article_Venteligne,prix_Venteligne,qte_Venteligne,poids_Venteligne,total_Venteligne) VALUES ('" + Convert.ToInt32(label_NBL.Text) +
                            "','" + dataGrid_vente.Rows[i].Cells[0].Value.ToString() +
                            "','" + Convert.ToDecimal(dataGrid_vente.Rows[i].Cells[3].Value) +
                       "' , '" + Convert.ToInt32(dataGrid_vente.Rows[i].Cells[1].Value) +
                       "' ,'" + Convert.ToDouble(dataGrid_vente.Rows[i].Cells[2].Value) +
                       "' ,'" + Convert.ToDecimal(dataGrid_vente.Rows[i].Cells[4].Value) + "')";
                        c.cmd = new MySqlCommand(str, c.MyCon);
                        c.MyCon.Open();
                        c.cmd.ExecuteNonQuery();


                        btn_add_lignevente.Enabled = false;

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
                InsertQueryReglement();
                this.Hide();

                this.Cursor = Cursors.WaitCursor;
                int print = Convert.ToInt32(GETIDByPrint());
                c.da = new MySqlDataAdapter("select * from printBL where id_vente ='" + print + "'", Connection.getCS());
                c.da.Fill(ds, "rp");
                BL rapport = new BL();
                FRM_IMP frm = new FRM_IMP();
                rapport.SetDataSource(ds.Tables["rp"]);
                frm.crystalReportViewer1.ReportSource = rapport;
                frm.MdiParent = this.MdiParent;
                frm.ShowDialog();
                this.Cursor = Cursors.Default;

            }
            else
            {
                MessageBox.Show("Remplir tous les Champs");
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGrid_vente_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGrid_vente_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }

        DataTable dt = new DataTable();
        private void txt_prix_KeyDown(object sender, KeyEventArgs e)
        {
            //int countarticle = Convert.ToInt32(countArticleByref());
            if (e.KeyCode == Keys.Enter)
            {


                //for (int i = 0; i < dataGrid_vente.Rows.Count ; i++)
                //{
                //    if (dataGrid_vente.Rows[i].Cells[0].Value.ToString() == txt_art.Text)
                //    {
                //        MessageBox.Show("Déjà Choisi", "Déjà Choisi "+txt_art.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //        return;
                //    }
                //}


                if (txt_art.Text != "" && txt_qt.Text != "" && txt_pd.Text != "" && txt_prix.Text != "")
                {
                    for (int i = 0; i < dataGrid_vente.Rows.Count; i++)
                    {
                        if (dataGrid_vente.Rows[i].Cells[0].Value.ToString() == txt_art.Text)
                        {
                            MessageBox.Show("Déjà Choisi "+txt_art.Text,"Déjà Choisi",  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    dataGrid_vente.DataSource = dt;
                    DataRow r = dt.NewRow();
                    r[0] = txt_art.Text;
                    r[1] = txt_qt.Text;
                    r[2] = txt_pd.Text;
                    r[3] = txt_prix.Text;
                    r[4] = txt_sum.Text;
                    dt.Rows.Add(r);
                   
                    dataGrid_vente.DataSource=dt;
                    txt_art.Text = "";
                    txt_qt.Text = "";
                    txt_pd.Text = "";
                    txt_prix.Text = "";
                    txt_sum.Text = "";
                    txt_art.Focus();
                    btn_tr.Enabled = true;
                    txt_total.Text =
                        (
                        from DataGridViewRow row in dataGrid_vente.Rows
                        where row.Cells[4].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();

                }
                else
                {
                    if (!ArticleExists())
                    {
                        MessageBox.Show("cet Article : " + txt_art.Text + " n'existe pas");
                    }
                    else
                    
                    {
                        MessageBox.Show("Remplir tous les Champs");
                    }
                    
                }
           
            }
        }

        private void txt_art_KeyDown(object sender, KeyEventArgs e)
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

        private void txt_prix_KeyUp(object sender, KeyEventArgs e)
        {
            calculesum();
        }

        private void txt_pd_KeyUp(object sender, KeyEventArgs e)
        {
            calculesum();
        }

        private void txt_prix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void btn_tr_Click(object sender, EventArgs e)
        {
            if (dataGrid_vente.DataSource == null)
            {
                MessageBox.Show("Aucan Commande");
            }
            else
            {
                btn_add_lignevente.Enabled = true;
                txt_art.Enabled = false;
                txt_qt.Enabled = false;
                txt_pd.Enabled = false;
                txt_prix.Enabled = false;
                btn_tr.Enabled = false;
                cmb_mode.Enabled = true;
                cmb_regl.Enabled = true;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void dataGrid_vente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_art.Text = dataGrid_vente.CurrentRow.Cells[0].Value.ToString();
                txt_qt.Text = dataGrid_vente.CurrentRow.Cells[1].Value.ToString();
                txt_pd.Text = dataGrid_vente.CurrentRow.Cells[2].Value.ToString();
                txt_prix.Text = dataGrid_vente.CurrentRow.Cells[3].Value.ToString();
                txt_sum.Text = dataGrid_vente.CurrentRow.Cells[4].Value.ToString();
                dataGrid_vente.Rows.RemoveAt(dataGrid_vente.CurrentRow.Index);
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

        private void dataGrid_vente_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txt_total.Text =
                   (
                   from DataGridViewRow row in dataGrid_vente.Rows
                   where row.Cells[4].FormattedValue.ToString() != string.Empty
                   select Convert.ToDouble(row.Cells[4].FormattedValue)).Sum().ToString();
            txt_art.Focus();
        }

        private void txt_art_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void txt_art_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
               //  int countarticle = Convert.ToInt32(countArticleByref());
            if (!ArticleExists() && txt_art.Text != string.Empty)
            {
                MessageBox.Show("cet Article : " + txt_art.Text + " n'existe pas");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_art_TabIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
