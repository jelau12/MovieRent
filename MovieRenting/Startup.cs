using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieRenting.Startup))]
namespace MovieRenting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
