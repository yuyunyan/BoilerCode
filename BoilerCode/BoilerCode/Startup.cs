using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BoilerCode.Startup))]
namespace BoilerCode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
