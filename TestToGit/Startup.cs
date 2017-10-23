using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestToGit.Startup))]
namespace TestToGit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
