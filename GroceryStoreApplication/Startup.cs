using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GroceryStoreApplication.Startup))]
namespace GroceryStoreApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
