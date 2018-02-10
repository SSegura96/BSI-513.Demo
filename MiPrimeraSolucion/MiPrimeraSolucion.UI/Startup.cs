using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiPrimeraSolucion.UI.Startup))]
namespace MiPrimeraSolucion.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
