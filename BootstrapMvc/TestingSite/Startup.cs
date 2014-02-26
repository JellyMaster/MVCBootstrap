using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingSite.Startup))]
namespace TestingSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
