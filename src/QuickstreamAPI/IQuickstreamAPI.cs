namespace QuickstreamAPI
{
    public interface IQuickstreamAPI
    {
        string PublishableKey { get; set; }
        string SecretKey { get; set; }
    }
}