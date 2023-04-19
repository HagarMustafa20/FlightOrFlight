using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppWithFacebookLogIn.Startup))]
namespace WebAppWithFacebookLogIn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
