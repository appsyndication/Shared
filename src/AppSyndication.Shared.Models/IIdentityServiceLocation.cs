namespace AppSyndication.Shared.Models
{
    public interface IUserServiceLocation : IServiceLocation
    {
        string UserClaimsUri { get; }

        string VersionUri { get; }
    }
}