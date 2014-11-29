using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AES.UniversalBank.Portal.Web.Startup))]
namespace AES.UniversalBank.Portal.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureIoC(app);

            ConfigureAuth(app);
        }
    }
}
