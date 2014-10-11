using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClimateChallenge.Startup))]
namespace ClimateChallenge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
