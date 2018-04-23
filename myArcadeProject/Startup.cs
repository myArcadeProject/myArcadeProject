using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myArcadeProject.Startup))]
namespace myArcadeProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
