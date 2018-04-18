using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ARSimulator.Startup))]
namespace ARSimulator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
