using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnAutofac.Web.Startup))]
namespace LearnAutofac.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
