using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RetailManagementTool.WebMVC.Startup))]
namespace RetailManagementTool.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}
