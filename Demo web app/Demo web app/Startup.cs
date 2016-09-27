using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Demo_web_app.Startup))]
namespace Demo_web_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
