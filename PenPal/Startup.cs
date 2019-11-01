using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PenPal.Startup))]
namespace PenPal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
