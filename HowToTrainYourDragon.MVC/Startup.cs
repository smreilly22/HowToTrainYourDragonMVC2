using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HowToTrainYourDragon.MVC.Startup))]
namespace HowToTrainYourDragon.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
