using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YouthInitiative.Startup))]
namespace YouthInitiative
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
