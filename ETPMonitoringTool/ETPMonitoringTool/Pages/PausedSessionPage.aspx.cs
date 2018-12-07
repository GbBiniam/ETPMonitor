using Monitor.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ETPMonitoringTool.Pages
{
    public partial class PausedSessionPage : System.Web.UI.Page
    {
        IOpenedSession _bl = new OpenedSessionImpl();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindToGrid();
            }
        }

        private void BindToGrid()
        {
            var item = _bl.GetAllOpenSession(Convert.ToDateTime("2018-11-28 00:00:00"),6);
            gvOpenedSession.DataSource = item;
            gvOpenedSession.DataBind();
        }
    }
}