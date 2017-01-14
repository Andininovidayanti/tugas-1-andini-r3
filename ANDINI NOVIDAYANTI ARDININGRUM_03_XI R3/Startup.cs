using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ANDINI_NOVIDAYANTI_ARDININGRUM_03_XI_R3.Startup))]
namespace ANDINI_NOVIDAYANTI_ARDININGRUM_03_XI_R3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
