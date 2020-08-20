using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EagleEye.WebMVC.Startup))]
namespace EagleEye.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
