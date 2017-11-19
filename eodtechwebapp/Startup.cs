using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eodtechwebapp.Startup))]
namespace eodtechwebapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
