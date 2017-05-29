using AppSyndication.Shared.Models;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceLocationExtensions
    {
        public static IServiceCollection AddAccountWebLocation(this IServiceCollection services)
        {
            services.TryAdd(ServiceDescriptor.Singleton<IAccountWebLocation, AccountWebLocation>());
            return services;
        }

        public static IServiceCollection AddIdentityServiceLocation(this IServiceCollection services)
        {
            services.TryAdd(ServiceDescriptor.Singleton<IIdentityServiceLocation, IdentityServiceLocation>());
            return services;
        }

        public static IServiceCollection AddUserServiceLocation(this IServiceCollection services)
        {
            services.TryAdd(ServiceDescriptor.Singleton<IUserServiceLocation, UserServiceLocation>());
            return services;
        }
    }
}
