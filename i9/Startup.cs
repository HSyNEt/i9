using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(i9.Startup))]
namespace i9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
