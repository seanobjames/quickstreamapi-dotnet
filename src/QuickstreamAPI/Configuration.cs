namespace QuickstreamAPI
{
    public class Configuration
    {
        public Environment Environment { get; set; }

        public string APIVersion
        {
            get { return "1"; }
        }

        public Configuration()
        {
        }
    }
}