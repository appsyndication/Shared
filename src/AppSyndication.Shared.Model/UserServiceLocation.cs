using Microsoft.AspNetCore.Hosting;

namespace AppSyndication.Shared.Model
{
    public class UserServiceLocation : ServiceLocation, IUserServiceLocation
    {
        private IHostingEnvironment _environment;

        public UserServiceLocation(IHostingEnvironment env) : 
            base(env.EnvironmentName, ServiceLocationConstants.UserServiceDevelopmentPort, ServiceLocationConstants.UserServiceProductionHostname)
        {
            this.UserClaimsUri = this.Uri + "user/claims/";

            this.VersionUri = this.Uri + "version/";
        }

        public string UserClaimsUri { get; }

        public string VersionUri { get; }
    }
}
