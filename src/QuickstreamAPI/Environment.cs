using QuickstreamAPI.Exceptions;

namespace QuickstreamAPI
{
    public class Environment
    {
        public const string theDefaultDevelopmentBaseURL = "http://localhost";
        public const string theDefaultDevelopmentPort = "7001";
        public const string theDevelopmentBaseURLSysEnvName = "DEV_BASE_URL";
        public const string theDevelopmentPortSysEnvName = "DEV_PORT";

        public string EnvironmentName { get; private set; }
        public string BaseURL { get; private set; }

        public static Environment DEVELOPMENT = new Environment(DevBaseURL(), "development");
        public static Environment TEST = new Environment("https://api.quickstream.support.qvalent.com", "test");
        public static Environment PRODUCTION = new Environment("https://api.quickstream.westpac.com.au", "production");

        public Environment( string baseURL, string environmentName )
        {
            this.EnvironmentName = environmentName;
            this.BaseURL = baseURL + "/rest/v" + Configuration.APIVersion;
        }

        private static string DevBaseURL()
        {
            var baseURL = System.Environment.GetEnvironmentVariable(theDevelopmentBaseURLSysEnvName) ?? theDefaultDevelopmentBaseURL;
            var port = System.Environment.GetEnvironmentVariable(theDefaultDevelopmentPort) ?? theDefaultDevelopmentPort;
            return string.Format("{0}:{1}", baseURL, port);
        }

        public static Environment ParseEnvironment(string environment)
        {
            switch( environment )
            {
                case "development":
                    return Environment.DEVELOPMENT;
                case "test":
                    return Environment.TEST;
                case "production":
                    return Environment.PRODUCTION;
                default:
                    throw new ConfigurationException("Not a valid Environment.");
            }
        }
    }
}