using Microsoft.AspNetCore.Hosting;

namespace AppSyndication.Shared.Models
{
    public class AccountWebLocation : ServiceLocation, IAccountWebLocation
    {
        private IHostingEnvironment _environment;

        public AccountWebLocation(IHostingEnvironment env) :
            base(env.EnvironmentName, ServiceLocationConstants.AccountWebDevelopmentPort, ServiceLocationConstants.AccountWebProductionHostname)
        {
            this.RegisterUri = this.Uri + "register/";
        }

        public string RegisterUri { get; }
    }
}
