using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(assignment2.Startup))]
namespace assignment2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
