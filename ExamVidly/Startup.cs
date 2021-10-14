using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamVidly.Startup))]
namespace ExamVidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
