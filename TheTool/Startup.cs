using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheTool.Startup))]
namespace TheTool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
