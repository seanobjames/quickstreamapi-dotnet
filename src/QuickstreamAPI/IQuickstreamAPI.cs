namespace QuickstreamAPI
{
    public interface IQuickstreamAPI
    {
        string SupplierBusinessCode { get; set; }
        string PublishableKey { get; set; }
        string SecretKey { get; set; }
    }
}