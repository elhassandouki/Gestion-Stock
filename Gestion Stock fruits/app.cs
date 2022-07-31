using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace Gestion_Stock_fruits
{
    
    public class app
    {

        public MySqlConnection MyCon = new MySqlConnection(Connection.getCS());
        //public SqlConnection MyConmaster = new SqlConnection(@"Data Source =.; Initial Catalog = g_stock; Integrated Security = True");
        public MySqlDataAdapter da;
        public MySqlCommand cmd;
        
        //public void conx(){
         
        //   if (Functions.getType() == "SQL")
        //    {
        //         MyCon = new SqlConnection(@"Serveur=" + Functions.getServerOrDB("server") +
        //              "; Initial Catalog =" + Functions.getServerOrDB("db") +
        //          "; Integrated Security = false" + "; User ID = " + Functions.getUserName() +
        //          "; Password = " + Functions.getPassword() + "");
        //    }
        //    else
        //    {
        //        MyCon = new SqlConnection(@"Serveur=" + Functions.getServerOrDB("server") +
        //           "; Initial Catalog =" + Functions.getServerOrDB("db") +
        //       "; Integrated Security = true");
        //    }
           
        //}

        //public void Open()
        //{
        //    if (MyCon.State != ConnectionState.Open)
        //    {
        //        MyCon.Open();
        //    }
        //}

        //public void Close()
        //{
        //    if (MyCon.State != ConnectionState.Closed)
        //    {
        //        MyCon.Close();
        //    }
        //}
        
    }
}
