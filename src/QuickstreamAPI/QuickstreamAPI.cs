namespace QuickstreamAPI
{
    public class QuickstreamAPI : IQuickstreamAPI
    {
        public virtual string PublishableKey 
        {
            get { return Configuration.PublishableKey; }
            set { Configuration.PublishableKey = value; }
        }

        public virtual string SecretKey  
        {
            get { return Configuration.SecretKey; }
            set { Configuration.SecretKey = value; }
        }

        public Configuration Configuration { get; set; }

        public QuickstreamAPI(Environment environment, string publishableKey, string secretKey)
        {
            Configuration = new Configuration(environment, publishableKey, secretKey);
        }
    }
}