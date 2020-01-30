using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kohvimasin.Startup))]
namespace Kohvimasin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
