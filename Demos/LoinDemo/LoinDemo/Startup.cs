using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoginDemo.Startup))]
namespace LoginDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
