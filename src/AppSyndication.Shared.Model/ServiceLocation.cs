using System;
using Microsoft.AspNetCore.Hosting;

namespace AppSyndication.Shared.Model
{
    public abstract class ServiceLocation : IServiceLocation
    {
        protected ServiceLocation(string environmentName, int developmentPort, string productionHostname, int? productionPort = null)
        {
            if (environmentName.Equals(EnvironmentName.Development, StringComparison.OrdinalIgnoreCase))
            {
                this.Scheme = ServiceLocationConstants.DevelopmentScheme;
                this.Host = ServiceLocationConstants.DevelopmentHostname;
                this.Port = developmentPort;
            }
            else if (environmentName.Equals(EnvironmentName.Staging, StringComparison.OrdinalIgnoreCase))
            {
                throw new NotImplementedException();
            }
            else if (environmentName.Equals(EnvironmentName.Production, StringComparison.OrdinalIgnoreCase))
            {
                this.Scheme = "https";
                this.Host = productionHostname;
                this.Port = productionPort;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(environmentName), $"Unknown environment: {environmentName}");
            }

            this.Uri = this.Scheme + "://" + this.Host;

            if (this.Port.HasValue)
            {
                this.Uri += ":" + this.Port.Value;
            }

            this.Uri += "/";
        }

        public string Host { get; }

        public int? Port { get; }

        public string Scheme { get; }

        public string Uri { get; }
    }
}
