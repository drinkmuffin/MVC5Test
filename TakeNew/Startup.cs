using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TakeNew.Startup))]
namespace TakeNew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
