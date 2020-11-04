using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClothBazer.web.Startup))]
namespace ClothBazer.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
