using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectCeeLearnAndDo.Startup))]
namespace ProjectCeeLearnAndDo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
