using Monitor.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitor.Service.Services
{
    public class OpenedSessionImpl : IOpenedSession
    {
        IDataAccess _db = new DataAccessImpl();
        public DataTable GetAllOpenSession(DateTime date, int status)
        {
            string sql = @"SELECT     dbo.tblSession.Name AS Name,  dbo.tblSession.Description, 
                                                  dbo.tblSession.TradeDate,  dbo.tblSession.OnlineStartTime, dbo.tblOnlineSessionStatus.Name AS StatusName
                            FROM         dbo.tblOnlineSessionStatus INNER JOIN
                                                  dbo.tblSession ON dbo.tblOnlineSessionStatus.Id = dbo.tblSession.OnlineStatusId
                            WHERE     (dbo.tblSession.TradeDate >= CONVERT(DATETIME, '2018-04-28 00:00:00', 102) and dbo.tblSession.OnlineStatusId='6')
                            ORDER BY dbo.tblSession.TradeDate DESC";
           return  _db.ExecuteQuery(sql);

        }
    }
}
