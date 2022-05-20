using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Projeto2.Startup))]
namespace Projeto2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
