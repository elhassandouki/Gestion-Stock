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
    public partial class Connexion_Serveur : Form
    {
        app app = new app(); 
        public Connexion_Serveur()
        {
            InitializeComponent();

        /*
            //Functions.getPassword("pw") = txt_mdp.Text;
           // Properties.Settings.Default.database = txt_BD.Text;
           if( Properties.Settings.Default.mode ==  "SQL" )
            {
                rb_sql.Checked = true;
                Properties.Settings.Default.id = txt_user.Text;
                Properties.Settings.Default.mdp = txt_mdp.Text;
            }
            else
            {
                rb_windows.Checked = true;
                txt_user.Clear();
                txt_mdp.Clear();
                txt_mdp.ReadOnly = true;
                txt_user.ReadOnly = true;
            }
            
            Properties.Settings.Default.Save();
             
            */
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sav_Click(object sender, EventArgs e)
        { 
            try
            {
                MessageBox.Show(txt_serveur.Text + txt_BD.Text);
                Functions.saveServerOrDB("server", txt_serveur.Text);
                Functions.saveServerOrDB("db", txt_BD.Text);
                if (rb_sql.Checked == true)
                {
                   
                    Functions.saveType("SQL");
                }
                else
                {
                    Functions.saveType("Windows");
                }
                Functions.saveUserName(txt_user.Text);
                Functions.savePassword(txt_mdp.Text);
               // MessageBox.Show(app.MyCon.ConnectionString);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
          

        }

        private void Connexion_Serveur_Load(object sender, EventArgs e)
        {
            
        }

        private void rb_windows_CheckedChanged(object sender, EventArgs e)
        {
            txt_mdp.ReadOnly = true;
            txt_user.ReadOnly = true;
        }

        private void rb_sql_CheckedChanged(object sender, EventArgs e)
        {
            txt_mdp.ReadOnly = false;
            txt_user.ReadOnly = false;
        }
    }
}
