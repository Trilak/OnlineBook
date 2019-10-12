using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Online_BookStore.Startup))]
namespace Online_BookStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
