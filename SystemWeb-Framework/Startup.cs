using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SystemWeb_Framework.Startup))]
namespace SystemWeb_Framework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
