using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _201735018EMS
{
    class aducs
    {
        public static bool ADUC(string sql,SqlCommand command)
        {
            if(databases.conn.State==ConnectionState.Closed)
            {
                databases.conn.Open();
            }
            command.Connection = databases.conn;
            command.CommandText = sql;
            command.ExecuteNonQuery();
            try
            {
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                databases.conn.Close();
            }
        }
        public static DataTable List(string sql)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter adtr = new SqlDataAdapter(sql,databases.conn);
            adtr.Fill(tbl);
            return tbl;
        }
    }
}
