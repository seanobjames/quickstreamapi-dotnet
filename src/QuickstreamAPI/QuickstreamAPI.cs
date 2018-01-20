namespace QuickstreamAPI
{
    public virtual SupplierBusinessCode 
    {
        get { return Configuration.SupplierBusinessCode; }
        set { Configuration.SupplierBusinessCode = value; }
    }

    public virtual PublishableKey 
    {
        get { return Configuration.PublishableKey; }
        set { Configuration.PublishableKey = value; }
    }

    public virtual SecretKey  
    {
        get { return Configuration.SecretKey; }
        set { Configuration.SecretKey = value; }
    }

    public QuickstreamAPI()
    {
        Configuration = new Configuration();
    }
}