using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EagleEye.MVC.Startup))]
namespace EagleEye.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
