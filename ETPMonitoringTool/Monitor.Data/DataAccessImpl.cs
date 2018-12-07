using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor.Data
{
    public class DataAccessImpl : IDataAccess
    {
        public bool ExecuteNonQuery(string query)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ECXTradeConnectionString"].ConnectionString;
            var con = new SqlConnection(connectionString); con.Open(); bool IsExecuted = false;
            var cmd = new SqlCommand(query, con);
            cmd.CommandTimeout = 0;
            try
            {
                IsExecuted = cmd.ExecuteNonQuery() > 0;
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
            finally
            {
                con.Close();
            }
            return IsExecuted;
        }

        public DataTable ExecuteQuery(string query)
        {
            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ECXTradeConnectionString"].ConnectionString);
            var cmd = new SqlCommand(query, con);
            cmd.CommandTimeout = 0;
            var adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            try
            {
                cmd.Dispose();
                con.Dispose();
                con.Close();
            }
            catch
            {
            }
            return dt;
        }

        public int ExecuteScalerQuery(string query)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ECXTradeConnectionString"].ConnectionString;
            var con = new SqlConnection(connectionString); con.Open();
            int count = 0;
            var cmd = new SqlCommand(query, con)
            { CommandTimeout = 0 };
            try
            {
                count = (int)cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString(), ex);
            }
            finally
            {
                con.Close();
            }
            return count;
        }
    }
}
