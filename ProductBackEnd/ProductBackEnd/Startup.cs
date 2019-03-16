using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductBackEnd.Startup))]
namespace ProductBackEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
