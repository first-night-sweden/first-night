using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstNightSweden.Startup))]
namespace FirstNightSweden
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
