using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Menzy.Startup))]
namespace Menzy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
