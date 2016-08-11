using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PoorAndNeed.Startup))]
namespace PoorAndNeed
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
