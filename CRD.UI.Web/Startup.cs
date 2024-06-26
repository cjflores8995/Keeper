using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRD.UI.Web.Startup))]
namespace CRD.UI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
