using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCVidlyTest.Startup))]
namespace MVCVidlyTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
