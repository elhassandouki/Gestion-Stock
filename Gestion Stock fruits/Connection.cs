using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestion_Stock_fruits
{
    class Connection
    {
        public static string MASTER = "master";

        public static string getCS()
        {
            if(Functions.getType()=="SQL")
                //"SERVER=127.0.0.1; DATABASE=mli; UID=root; PASSWORD="
                //return string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3};Integrated Security=false"
                return string.Format("SERVER={0};DATABASE={1};Uid={2};Pwd={3}"
                    , Functions.getServerOrDB("server")
                , Functions.getServerOrDB("db")
                ,Functions.getUserName()
                ,Functions.getPassword());
            return string.Format("SERVER={0};DATABASE={1};Uid={2};Pwd={3}"
                  , Functions.getServerOrDB("server")
                , Functions.getServerOrDB("db")
                , Functions.getUserName()
                , Functions.getPassword());   
            //return string.Format("Data Source={0};Initial Catalog={1};Integrated Security=SSPI"
            //    , Functions.getServerOrDB("server")
            //    , Functions.getServerOrDB("db"));   
        }
      
    }
}
