using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gestion_Stock_fruits
{
    public partial class Etat_Vente : Form
    {
        app c = new app();
        DataSet ds;
        //DataSet1TableAdapters.ReglementTableAdapter regl = new DataSet1TableAdapters.ReglementTableAdapter();
        //DataSet1TableAdapters.vente_ligneTableAdapter vente_l = new DataSet1TableAdapters.vente_ligneTableAdapter();
        //DataSet1TableAdapters.detail_venteTableAdapter detail = new DataSet1TableAdapters.detail_venteTableAdapter();
    
        public Etat_Vente()
        {
            InitializeComponent();
        }

        private void btn_afficher_ETATVENTE_Click(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet();

                if (cmb_regle.Text != "")
                {
                    c.da = new MySqlDataAdapter("SELECT * FROM detail_vente WHERE Mode_Réglement ='"+cmb_regle.Text+"' AND Date_Vente ='"+date_vente.Value.ToShortDateString()+"'", c.MyCon);
                    c.da.Fill(ds, "detail");
                    dataGridEatavente.DataSource = ds.Tables[0];
                    
                   // dataGridEatavente.DataSource = detail.GetDataByDate_Etat(cmb_regle.Text, date_vente.Value.ToShortDateString());
                   // dataGridEatavente.DataSource = regl.GetDataByReglement(cmb_regle.Text, date_vente.Value.ToShortDateString());
                   dataGridEatavente.Refresh();

                   c.da = new MySqlDataAdapter("SELECT sum(Montant) FROM detail_vente WHERE Mode_Réglement ='" + cmb_regle.Text + "' AND Date_Vente ='" + date_vente.Value.ToShortDateString() + "'", c.MyCon);
                   c.da.Fill(ds, "regl");
                 MessageBox.Show(ds.Tables["regl"].ToString()+" Dhs", "Vente : " + cmb_regle.Text + " Date : " + date_vente.Value.ToShortDateString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                 label_total.Text = ds.Tables["regl"].ToString() + " Dhs";
                }
                else
                {
                    MessageBox.Show("Remplir Tous Les Champs", "Remplir Tous Les Champs", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Etat_Vente_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void dataGridEatavente_Click(object sender, EventArgs e)
        {
            
                dataGridEatavente.Visible = true;
                Détail_Bon_Livraison myfr = new Détail_Bon_Livraison();

                ds = new DataSet();
                myfr.txt_NBL.Text = dataGridEatavente.CurrentRow.Cells[2].Value.ToString();
                myfr.txt_montant.Text = dataGridEatavente.CurrentRow.Cells[6].Value.ToString();
                myfr.txt_Date.Text=dataGridEatavente.CurrentRow.Cells[0].Value.ToString();
                myfr.txt_CL.Text = dataGridEatavente.CurrentRow.Cells[1].Value.ToString();
                c.da = new MySqlDataAdapter("SELECT * FROM `etat_vente_article` WHERE etat_vente_article.N° BL ='" + myfr.txt_NBL.Text + "'", c.MyCon);
                c.da.Fill(ds,"vente");
                myfr.dataGridDetailVente.DataSource =ds.Tables["vente"];
                myfr.ShowDialog();
               //MessageBox.Show(detail.GetDataByid(Convert.ToInt32(myfr.txt_NBL.Text)).ToString());
           
        }
    }
}
