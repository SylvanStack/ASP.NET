using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFMvc.Startup))]
namespace EFMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
