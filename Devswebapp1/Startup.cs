using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Devswebapp1.Startup))]
namespace Devswebapp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
