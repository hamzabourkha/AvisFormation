using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AvisFormations.WebUI.Startup))]
namespace AvisFormations.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
