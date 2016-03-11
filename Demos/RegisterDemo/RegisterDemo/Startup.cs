using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RegisterDemo.Startup))]
namespace RegisterDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
