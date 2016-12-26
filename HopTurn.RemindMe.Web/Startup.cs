using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HopTurn.RemindMe.Web.Startup))]
namespace HopTurn.RemindMe.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
