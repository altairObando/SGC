using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SGC___Vista.Startup))]
namespace SGC___Vista
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
