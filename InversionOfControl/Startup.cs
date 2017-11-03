using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(InversionOfControl.Startup))]
namespace InversionOfControl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
