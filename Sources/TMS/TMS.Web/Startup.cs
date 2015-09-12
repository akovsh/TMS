using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMS.Web.Startup))]
namespace TMS.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
