using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HttpModuleDemo.Startup))]
namespace HttpModuleDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
