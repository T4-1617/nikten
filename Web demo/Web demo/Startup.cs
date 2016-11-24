using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web_demo.Startup))]
namespace Web_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
