using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Core.Provider
{
    public class Database
    {
        public static string getConfigurationConnect()
        {
            return ConfigurationManager.AppSettings.Get("CONNECT_STRING");
        }

        public static bool excute(Action<SqlConnection, SqlTransaction> context)
        {
            string conStr = getConfigurationConnect();
            SqlConnection con = new SqlConnection(conStr);

            con.Open();
            SqlTransaction tran = con.BeginTransaction();

            try
            {
                context(con, tran);
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                tran.Rollback();
            }
            con.Close();

            return false;
        }

        public static bool excuteQuery(Action<SqlConnection> excute)
        {
            string conStr = getConfigurationConnect();

            SqlConnection con = new SqlConnection(conStr);

            con.Open();
            try
            {
                excute(con);
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.Close();
            return false;
        }
    }
}
