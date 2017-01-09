namespace AppSyndication.Shared.Model
{
    public interface IServiceLocation
    {
        string Host { get; }

        int? Port { get; }

        string Scheme { get; }

        string Uri { get; }
    }
}