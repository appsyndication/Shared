namespace AppSyndication.Shared.Models
{
    public interface IIdentityServiceLocation : IServiceLocation
    {
        string TokenUri { get; }
    }
}