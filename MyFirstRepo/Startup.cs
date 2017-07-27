using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyFirstRepo.Startup))]
namespace MyFirstRepo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
