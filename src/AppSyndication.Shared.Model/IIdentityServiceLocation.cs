namespace AppSyndication.Shared.Model
{
    public interface IUserServiceLocation : IServiceLocation
    {
        string UserClaimsUri { get; }

        string VersionUri { get; }
    }
}