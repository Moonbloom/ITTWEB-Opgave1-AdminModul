using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITTWEB_Opg1_AdminModul.Startup))]
namespace ITTWEB_Opg1_AdminModul
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
