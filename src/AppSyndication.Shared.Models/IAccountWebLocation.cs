namespace AppSyndication.Shared.Models
{
    public interface IAccountWebLocation : IServiceLocation
    {
        string RegisterUri { get; }
    }
}