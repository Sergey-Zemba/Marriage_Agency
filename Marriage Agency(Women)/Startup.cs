using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Marriage_Agency_Women_.Startup))]
namespace Marriage_Agency_Women_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
