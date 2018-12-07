using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor.Service.Services
{
    public interface IOpenedSession
    {
        DataTable GetAllOpenSession(DateTime date,int status);
    }
}
