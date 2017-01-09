using Microsoft.AspNetCore.Hosting;

namespace AppSyndication.Shared.Model
{
    public class IdentityServiceLocation : ServiceLocation, IIdentityServiceLocation
    {
        private IHostingEnvironment _environment;

        public IdentityServiceLocation(IHostingEnvironment env) : 
            base(env.EnvironmentName, ServiceLocationConstants.IdentityServiceDevelopmentPort, ServiceLocationConstants.IdentityServiceProductionHostname)
        {
            this.TokenUri = this.Uri + "token/";
        }

        public string TokenUri { get; }
    }
}
