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
    public partial class Stock : Form
    {
        app c = new app();
        DataSet ds;
        //SqlConnection conx = new SqlConnection(Connection.getCS());
        //DataSet1TableAdapters.articleTableAdapter article = new DataSet1TableAdapters.articleTableAdapter();
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            GetArticle(String.Empty);
        }
        public void GetArticle(String Article)
        {
            String query = "SELECT desgination FROM article";
           
            c.cmd = new MySqlCommand(query,c.MyCon);
            c.MyCon.Open();
            MySqlDataReader reader = c.cmd.ExecuteReader();
            AutoCompleteStringCollection mydata = new AutoCompleteStringCollection();

            while (reader.Read())
            {
                mydata.Add(reader.GetString(0));
            }
            c.MyCon.Close();
            txt_article.AutoCompleteCustomSource = mydata;
        }

        private void txt_article_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_article.Text == "")
            {
                ds = new DataSet();
                c.da = new MySqlDataAdapter("select * from article ", c.MyCon);
                c.da.Fill(ds, "Fille2");
                dataGridArticle.DataSource = ds.Tables[0];
               // dataGridArticle.DataSource = article.GetData();
                dataGridArticle.Refresh();
            }
            else
            {
                if (e.KeyCode == Keys.Enter) 
                {
                    ds = new DataSet();
                    c.da = new MySqlDataAdapter("select * from article where desgination ='" + txt_article.Text + "'",c.MyCon);
                    c.da.Fill(ds, "Fille");
                    dataGridArticle.DataSource = ds.Tables[0];

                       // dataGridArticle.DataSource = article.GetDataByDesgination(txt_article.Text);
                        dataGridArticle.Refresh();
                }
            }
        }
    }
}
