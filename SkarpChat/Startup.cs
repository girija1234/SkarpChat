using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkarpChat.Startup))]
namespace SkarpChat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
