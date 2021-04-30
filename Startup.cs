using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prak_PBO___Exam.Startup))]
namespace Prak_PBO___Exam
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
