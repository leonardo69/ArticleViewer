using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ArticleViewer.Startup))]
namespace ArticleViewer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
