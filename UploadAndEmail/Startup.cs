using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UploadAndEmail.Startup))]
namespace UploadAndEmail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
