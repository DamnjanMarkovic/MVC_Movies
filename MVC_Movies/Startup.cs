using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Movies.Startup))]
namespace MVC_Movies
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
