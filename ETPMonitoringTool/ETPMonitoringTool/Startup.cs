using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ETPMonitoringTool.Startup))]
namespace ETPMonitoringTool
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
