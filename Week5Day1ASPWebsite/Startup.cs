using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week5Day1ASPWebsite.Startup))]
namespace Week5Day1ASPWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
