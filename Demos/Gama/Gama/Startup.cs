using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gama.Startup))]
namespace Gama
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
