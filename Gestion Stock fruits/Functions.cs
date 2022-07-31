using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Security.Cryptography;

namespace Gestion_Stock_fruits
{
    class Functions
    {
        // ---------------- GET type ------------------
        public static string getType()
        {
            return ConfigurationManager.AppSettings["type"].ToString();
        }

        // -------------------- SAVE Type -------------------------
        public static void saveType(string type)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("type");
            config.AppSettings.Settings.Add("type",type);
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        // ---------------- GET Password ------------------
        public static string getPassword()
        {
            //dcrypt wla nta kat3rf ghir dik encrypt safi :D hhhhhhh 
            // fin ghadi tdar had function ta3 decryp..
            // wakhdmaaa m3ak nta
            return ConfigurationManager.AppSettings["pw"].ToString();
        }

        // -------------------- SAVE PASSWORD -------------------------
        public static void savePassword(string password)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("pw");
            config.AppSettings.Settings.Add("pw", GetMD5(password));
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        // -------------------- SAVE USER NAME -------------------------
        public static void saveUserName(string user)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("user");
            config.AppSettings.Settings.Add("user", user);
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        // ---------------- GET UserName ------------------
        public static string getUserName()
        {
            return ConfigurationManager.AppSettings["user"].ToString();
        }



        // ---------------- GET SERVER OR DB ------------------
        public static string getServerOrDB(string serverORdb)
        {
            return ConfigurationManager.AppSettings[serverORdb].ToString();
        }

        // -------------------- SAVE SERVER OR DB -------------------------
        public static void saveServerOrDB(string serverORdb, string serverOrdbName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(serverORdb);
            config.AppSettings.Settings.Add(serverORdb, serverOrdbName);
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static string GetMD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder st = new StringBuilder();
            for (int i = 1; i < result.Length; i++)
            {
                st.Append(result[i].ToString("x2"));
            }
            return st.ToString();
        }

        
    }
}
