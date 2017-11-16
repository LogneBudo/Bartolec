using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bartolec.Startup))]
namespace Bartolec
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
