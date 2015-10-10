using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Orneholm.ApplicationInsights.Web.Startup))]
namespace Orneholm.ApplicationInsights.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}