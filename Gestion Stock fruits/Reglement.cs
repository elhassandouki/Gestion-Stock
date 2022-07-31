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
    public partial class Reglement : Form
    {
        app c = new app();
        DataSet ds;
        //DataSet1TableAdapters.ReglementTableAdapter reglement = new DataSet1TableAdapters.ReglementTableAdapter();
        //DataSet1TableAdapters.venteTableAdapter vente = new DataSet1TableAdapters.venteTableAdapter();
        //DataSet1TableAdapters.printBLTableAdapter p = new DataSet1TableAdapters.printBLTableAdapter();
        public Reglement()
        {
            InitializeComponent();
            this.ControlBox = false;
            MaximizeBox = false;

        }

        private void Reglement_Load(object sender, EventArgs e)
        {
            
           
        }

        public void InsertQueryReglement()
        {
            String str = "INSERT INTO reglement(date_regle,id_BLvente,montant,mode_regl,etat,note) VALUES ('"+
                date_regl.Value.ToShortDateString()+"','"+Convert.ToInt32(txt_NBL.Text)+"','"+
                Convert.ToDecimal(txt_montantBL.Text)+"','"+cmb_mode.Text+"','"+cmb_regl.Text+"','"+txt_note.Text+"')";
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
        private void btn_valider_regl_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_montantBL.Text != "" && txt_NBL.Text != ""
                    && cmb_mode.Text != "" && cmb_regl.Text != "")
                {
                    InsertQueryReglement();
                    MessageBox.Show("Bien Ajouter Réglement BL N° : " + txt_NBL.Text);
                    
                    this.Hide();
                    this.Cursor = Cursors.WaitCursor;
                    int print = Convert.ToInt32(GETIDByPrint());
                    DataSet ds = new DataSet();
                    c.da = new  MySqlDataAdapter("select * from printBL where id_vente ='" + print + "'", c.MyCon);
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
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {

            }
        }
    }
}
