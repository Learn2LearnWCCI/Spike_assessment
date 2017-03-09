using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SurveyPractice.Startup))]
namespace SurveyPractice
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
