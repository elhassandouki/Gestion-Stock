using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gestion_Stock_fruits
{
    public partial class FRM_ : Form
    {
        public FRM_()
        {
            InitializeComponent();
        }

        private void FRM__Load(object sender, EventArgs e)
        {

        }
        public void addtab()
        {
            tabControl1.Visible = true;
            EtatVenteArticle ev = new EtatVenteArticle();
            EtatAchatArticle ea = new EtatAchatArticle();
  
            TabPage tabpage = new TabPage(Text = ev.Text);
            tabpage.BorderStyle = BorderStyle.None;

            
            TabPage tabpage2 = new TabPage(Text = ea.Text);
            tabpage2.BorderStyle = BorderStyle.None;

            tabControl1.TabPages.Add(tabpage);
            tabControl1.TabPages.Add(tabpage2);

            ev.TopLevel = false;
            ev.FormBorderStyle = FormBorderStyle.None;
            ev.Parent = tabpage;
            ev.Show();
            ev.Dock = DockStyle.Fill;

            ea.TopLevel = false;
            ea.FormBorderStyle = FormBorderStyle.None;
            ea.Parent = tabpage2;
            ea.Show();
            ea.Dock = DockStyle.Fill;

   
        }

        private void btn_achat_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            tabControl1.TabPages.Clear();
            
            
            Achat frm = new Achat();
            frm.MdiParent = this;
            
           
            frm.Show();
        }

        private void btn_article_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            tabControl1.TabPages.Clear();

            Articles art = new Articles();
            art.MdiParent = this;
            art.Show();
        }

        private void btn_fournisseur_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            tabControl1.TabPages.Clear();

            Fournisseur frs = new Fournisseur();
            frs.MdiParent = this;
            frs.Show();
        }

        private void btn_vente_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            tabControl1.TabPages.Clear();

            FRM_VENTE vente = new FRM_VENTE();
            vente.MdiParent = this;
            vente.Show();
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            tabControl1.TabPages.Clear();

            Stock stock = new Stock();
            stock.MdiParent = this;
            stock.Show();
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_inventaire_Click(object sender, EventArgs e)
        {
            addtab();
           
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_caisse_Click(object sender, EventArgs e)
        {
            Etat_Vente etatv = new Etat_Vente();
            etatv.Show();
        }

        private void btn_config_Click(object sender, EventArgs e)
        {
            Connexion_Serveur cn = new Connexion_Serveur();
            cn.MdiParent = this;
            cn.Show();
        }
    }
}
