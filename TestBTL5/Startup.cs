using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestBTL5.Startup))]
namespace TestBTL5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
