using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BeatMyGrades.Startup))]
namespace BeatMyGrades
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
