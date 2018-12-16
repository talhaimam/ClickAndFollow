using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClickAndFollowApp.HelperMethods
{
    public class DbOptions
    {
        public DbOptions()
        {

        }

        public static string GetAppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static MySqlConnection ConnectToMySQLDb()
        {
            MySqlConnection conn = null;
            
            try
            {
                conn = new MySqlConnection("server = " + GetAppSetting("DbHost") + "; uid = " + GetAppSetting("DbUser") + "; pwd=" 
                    + GetAppSetting("DbPassword") + ";database=" + GetAppSetting("DbName"));
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection, try again later.");
            }

            return conn;
        }

        public static SqlConnection ConnectToSQLServerDb()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=" + GetAppSetting("DbHost") + ";Initial Catalog="
                + GetAppSetting("DbName") + ";User ID=" + GetAppSetting("DbUser") + ";Password=" + GetAppSetting("DbPassword"));
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection, try again later.");
            }

            return conn;
        }
    }
}
