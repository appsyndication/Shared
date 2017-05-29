using System;
using System.Security.Claims;
using IdentityModel;

namespace AppSyndication.Shared.Models
{
    public static class ClaimsPrincipalExtensions
    {
        public static bool Authenticated(this ClaimsPrincipal user)
        {
            return user?.Identity.IsAuthenticated == true;
        }

        public static Guid Id(this ClaimsPrincipal user)
        {
            Guid id;
            var subject = user?.FindFirst(JwtClaimTypes.Subject)?.Value;

            return Guid.TryParse(subject, out id) ? id : Guid.Empty;
        }

        public static string CanonicalId(this ClaimsPrincipal user)
        {
            var id = user.Id();

            return id == Guid.Empty ? null : id.ToString("N").ToLowerInvariant();
        }

        public static string Username(this ClaimsPrincipal user)
        {
            return user?.FindFirst(JwtClaimTypes.Name)?.Value ?? String.Empty;
        }

        public static string Name(this ClaimsPrincipal user)
        {
            return user?.FindFirst(JwtClaimTypes.GivenName)?.Value ?? String.Empty;
        }

        public static string FullName(this ClaimsPrincipal user)
        {
            var first = user?.FindFirst(JwtClaimTypes.GivenName)?.Value ?? String.Empty;
            var last = user?.FindFirst(JwtClaimTypes.FamilyName)?.Value ?? String.Empty;

            return String.Join(" ", first, last);
        }

        public static string Email(this ClaimsPrincipal user)
        {
            return user?.FindFirst(JwtClaimTypes.Email)?.Value ?? String.Empty;
        }
    }
}
