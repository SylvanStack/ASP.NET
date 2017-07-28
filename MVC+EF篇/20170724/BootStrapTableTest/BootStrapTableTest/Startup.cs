using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootStrapTableTest.Startup))]
namespace BootStrapTableTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
