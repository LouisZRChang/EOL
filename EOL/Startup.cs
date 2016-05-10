using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EOL.Startup))]
namespace EOL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
