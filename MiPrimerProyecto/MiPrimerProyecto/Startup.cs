using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiPrimerProyecto.Startup))]
namespace MiPrimerProyecto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
