using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GridViewExample
{
    public static class ManData
    {
        public static string HOST = "localhost";
        public static string USER_NAME = "root";
        public static string PASSWORD = "";
        public static string DB_NAME = "teamtracker";


        public static MySqlConnection getConnection()
        {
            return new MySqlConnection(@"server=localhost;user id=root;database=teamtracker;Convert Zero Datetime=True");
        }

        public static bool executeDeleteQuery(String table, String condition)
        {
            return executeQuery(getDeleteQuery(table,condition));
        }
        private static string getDeleteQuery(String table, String condition) {

            return "DELETE FROM `"+table+"` WHERE "+condition;
        }
        public static bool executeInsertQuery(Dictionary<String, String> data, String table)
        {
            return executeQuery(getInsertQuery(data, table));
        }
        public static bool executeUpdateQuery(Dictionary<String, String> data, String table, String condition)
        {
            return executeQuery(getUpdateQuery(data, table, condition));
        }

        private static Boolean executeQuery(String query)
        {
            try
            {
                MySqlConnection conn = getConnection();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (conn)
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LogWriter.LogWrite(query);
                }
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite(ex.StackTrace);
                return false;
            }

            return true;
        }

        private static string getInsertQuery(Dictionary<String, String> data, String table)
        {
            String colName = "", colValue = "";
            int length = data.Count, count = 0;

            foreach (KeyValuePair<string, string> item in data)
            {
                colName += item.Key;
                colValue += "'" + item.Value + "'";

                if (length != count + 1)
                {
                    colName += ",";
                    colValue += ",";
                }
                count++;
            }

            return "INSERT INTO " + table + " (" + colName + ") VALUES(" + colValue + ")";
        }

        private static string getUpdateQuery(Dictionary<String, String> data, String table, String condition)
        {
            String col = "";
            int length = data.Count, count = 0;

            foreach (KeyValuePair<string, string> item in data)
            {
                col += item.Key + "='" + item.Value + "'";

                if (length != count + 1)
                    col += ",";
                count++;
            }

            return "UPDATE " + table + " SET " + col + " where " + condition;
        }
        public static DataSet getDataSet(string col, string table, string condition)
        {

            MySqlConnection conn = ManData.getConnection();

            string query = "SELECT " + col + " FROM " + table + " " + (condition != null ? " where " + condition : "");

            DataSet dataSet = new DataSet();
            try
            {
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, conn);
                using (conn)
                {
                    conn.Open();
                    adpt.Fill(dataSet);
                    LogWriter.LogWrite(query);

                }
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite(ex.StackTrace);
            }

            return dataSet;
        }


        public static DataTable getDataReader(string col, string table, string condition)
        {
            MySqlConnection conn = ManData.getConnection();
            String query = "SELECT " + col + " FROM " + table + " " + (condition != null ? " where " + condition : "");
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = null;

            DataTable dataTable = new DataTable();
            var columns = new Dictionary<string,string>();
            var list  = new List< Dictionary<string, string>>();
            try
            {
                using (conn)
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    dataTable.Load(reader);
                }
                
            }
            catch (Exception ex)
            {
                LogWriter.LogWrite(ex.StackTrace);
            }

            return dataTable;
        }




    }
}

