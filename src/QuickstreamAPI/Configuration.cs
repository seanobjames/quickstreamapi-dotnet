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

        public static string ClientLibraryVersion
        {
            get { return "0.1"; }
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
        public Configuration( Environment environment, string publishableKey, string secretKey )
        {
            if( environment == null )
            {
                throw new ConfigurationException("environment must be set");
            }

            if( publishableKey == null )
            {
                throw new ConfigurationException("publishableKey must be set");
            }

            if( secretKey == null )
            {
                throw new ConfigurationException("secretKey must be set");
            }

            Environment = environment;
            PublishableKey = publishableKey;
            SecretKey = secretKey;
        }
    }
}