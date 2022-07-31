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
    public partial class Login : Form
    {
        app c = new app();
        //SqlConnection conx = new SqlConnection(Connection.getCS());
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        public void auth()
        {
            if (txt_login.Text == "")
            {

                panel_login_bottom.Visible = true;

                lblErour.Visible = true;

                panel_login_bottom.BackColor = Color.Gray;

                lblErour.ForeColor = Color.Black;

                lblErour.Text = "Veuillez entrer votre nom d'utilisateur";

            }

            else if (txt_mdp.Text == "")
            {

                panel_login_bottom.Visible = true;

                lblErour.Visible = true;

                panel_login_bottom.BackColor = Color.Gray;

                lblErour.ForeColor = Color.Black;

                lblErour.Text = "Veuillez entrer le mot de passe";

            }

            else
            {
                FRM_ f1 = new FRM_();

                string a = Functions.GetMD5(txt_mdp.Text);

                try
                {
                  
                    c.cmd = new MySqlCommand ("select count(*) from [user] where [LOGIN]='" + txt_login.Text +
                  "' and [mdp] ='" + a.ToString() + "'", c.MyCon);
                    c.MyCon.Open();

                    int str = Convert.ToInt32(c.cmd.ExecuteScalar().ToString());

                    if (str > 0)
                    {

                        c.MyCon.Close();

                        panel_login_bottom.Visible = true;

                        lblErour.Visible = true;

                        lblErour.Text = "Bienvenue , " + txt_login.Text + " Vous êtes connecté Succès ..!";

                        panel_login_bottom.BackColor = Color.LightBlue;

                        lblErour.ForeColor = Color.DarkBlue;
                        f1.Show();
                        //pictureBox2.Visible = false;

                    }

                    else
                    {

                        panel_login_bottom.Visible = true;

                        lblErour.Visible = true;

                        lblErour.Text = "Les détails de connexion ne correspondent pas à notre base de données";

                        //pictureBox2.Visible = false;

                        panel_login_bottom.BackColor = Color.DarkGreen;

                        lblErour.ForeColor = Color.White;

                    }

                }

                catch
                {

                }
            }
        }

        private void btn_conx_Click(object sender, EventArgs e)
        {
            auth();
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_auth_Click(object sender, EventArgs e)
        {

        }

    }
}
