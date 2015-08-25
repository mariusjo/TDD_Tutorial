using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TDD_Tutorial.Startup))]
namespace TDD_Tutorial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
