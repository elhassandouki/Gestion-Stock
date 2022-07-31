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
    public partial class Détail_Bon_Livraison : Form
    {
        app c = new app();
        //SqlConnection conx = new SqlConnection(Connection.getCS());
        //DataSet1TableAdapters.detail_venteTableAdapter detail = new DataSet1TableAdapters.detail_venteTableAdapter();
        public Détail_Bon_Livraison()
        {
            InitializeComponent();
        }

        private void panel_detailBL_center_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void Détail_Bon_Livraison_Load(object sender, EventArgs e)
        {
            txt_CL.Enabled = false;
            txt_Date.Enabled = false;
            txt_montant.Enabled = false;
            txt_NBL.Enabled = false;
            MaximizeBox = false;

           // txt_CL.Text = detail.GetDataByid(Convert.ToInt32(txt_NBL.Text)).Rows[0].ToString();
           // MessageBox.Show(detail.GetDataByid(Convert.ToInt32(txt_NBL.Text)).Rows[0].ToString());
        }

        private void Détail_Bon_Livraison_Load_1(object sender, EventArgs e)
        {
           

           
        }

        private void btn_imprimer_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                DataSet ds = new DataSet();
                c.da = new MySqlDataAdapter("select * from printBL where id_vente ='" + txt_NBL.Text + "'", c.MyCon);
               
                c.da.Fill(ds, "rp");
                BL rapport = new BL();
                FRM_IMP frm = new FRM_IMP();
                rapport.SetDataSource(ds.Tables["rp"]);
                frm.crystalReportViewer1.ReportSource = rapport;
                frm.MdiParent = this.MdiParent;
                frm.ShowDialog();
                this.Cursor = Cursors.Default;
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
