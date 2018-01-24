using QuickstreamAPI.Exceptions;
using System.Net;
using System.Net.Http;

namespace QuickstreamAPI
{
    public class Configuration
    {
        public Environment Environment { get; set; }

        public static string APIVersion
        {
            get { return "1"; }
        }

        public string PublishableKey { get; set; }
        public string SecretKey { get; set; }

        public IWebProxy WebProxy { get; set; }

        public HttpRequestMessage HttpRequestMessageFactory { get; set; }

        private int timeout;
        public int Timeout
        {
            get { return timeout == 0 ? 60000 : timeout; }
            set { timeout = value; }
        }

        public Configuration()
        {

        }
        public Configuration( Environment environment, string supplierBusinessCode, string publishableKey, string secretKey ) : this()
        {
            if( environment == null )
            {
                throw new ConfigurationException("Environment is required.");
            }

            if( publishableKey == null )
            {
                throw new ConfigurationException("Publishable Key is required.");
            }

            if( secretKey == null )
            {
                throw new ConfigurationException("Secrety Key is required.");
            }

            Environment = environment;
            PublishableKey = publishableKey;
            SecretKey = secretKey;
        }
    }
}