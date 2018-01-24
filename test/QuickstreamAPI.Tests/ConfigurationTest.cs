using NUnit.Framework;
using QuickstreamAPI.Exceptions;
using System;

namespace QuickstreamAPI.Tests
{
    [TestFixture]
    public class ConfigurationTest
    {
        [Test]
        public static void ConfigurationMissingParameters_ThrowsConfigurationException()
        {
            Assert.Throws<ConfigurationException>(() => new Configuration(null, "", ""));
        }
    }
}