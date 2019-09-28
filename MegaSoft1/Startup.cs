using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MegaSoft1.Startup))]
namespace MegaSoft1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
