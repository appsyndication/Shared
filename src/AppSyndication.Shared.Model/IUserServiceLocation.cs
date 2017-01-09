namespace AppSyndication.Shared.Model
{
    public interface IIdentityServiceLocation : IServiceLocation
    {
        string TokenUri { get; }
    }
}