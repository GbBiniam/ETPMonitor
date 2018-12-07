using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor.Data
{
    public interface IDataAccess
    {
        bool ExecuteNonQuery(string query);
        DataTable ExecuteQuery(string query);
        int ExecuteScalerQuery(string query);
    }
}
