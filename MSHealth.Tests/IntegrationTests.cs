using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSHealth.Data;

namespace MSHealth.Tests
{
    [TestClass]
    public class IntegrationTests
    {
        private readonly string token = "Bearer EwCwAvF0BAAUkWhN6f8bO0%2bg89MA1fmZueWyRkQAATpTO8NJdE3xvQ%2boIR942ENeTAbKEHegJ8qN4RTPyhHeChy59c4ry8HC61WpEkvQsADw5F4jJj1eY2%2bflwne7dPtYfO8i19Pe/cmTrptKyt9QYhGFZrrSjiJcQKk8Reld1%2bjHZmA1G//BI6E659RlA9gXVq3Gdt0eadAQcXeNunWQ0mPcH6COpbwFcaskY8y19CZ5THYjfU1oHz3hLCQjrXakyTXW7Kw79qSKubaHIpD4hfiVM8Y5O3GweA/InTXMmPlC9V/9lrByl4d7lxXRjK50UKbpXPUTCugIuKlR7UlpoAXGTgeUXLVe9yIu1cXVdpRZQ5DynOOm6S6cpVITJgDZgAACDz0sZwLSUKTgAGoaKCOou64UfM98%2bnU332Xy7XPNwJ4rTFVX8UINfWYqXy2UkxIgW0C7wAx9WBh/D%2bo2p/7Uq1QdVtErnPBkqwNNcg/nrKm8C8r0G/h6lXb%2bjJ/IL8r32rRgQZnfHDYf7wocbX1h/PsumKQB39%2bq0aNyKp%2b4/cd9/1DcXFBxWyyLMu30k9AkcKrL11Ku8Ux4q0xQRJDSDeN6txfr8QCxfI2N8Ghd9pXSNelq9Peb6poOfPkqXKjc9KAF67cof/eH79EPLa8YX1%2bWPPfjl/jEKwyQ%2b3xTjjaZxjy%2bqiSqjOwpKHKyLmRNV0AnHVdEvcOm%2bbF7%2bDjiZj9tKUKLpiQU%2bN9Am8fsH%2b700DSt056E7h1MBA8ecWUi1qiHZG%2boQTWyPMysB5kOXag9zgM9OqhfZJF2WMv%2brwhH2pVgyi5hvvI/OhGBl%2bYteOOYOq3qX3fe6g0EA/0LeIhm0go2vfF2UIw2MFlWpLjM7W0Cn2emKOsxDtCIDl1%2bl1CoDCluM/eFiSGAQ%3d%3d";

        [TestMethod]
        public void CanGetActivities()
        {
            var act = Activities.getActivites(token);
            Assert.IsNotNull(act);
        }

        [TestMethod]
        public void CanGetDevices()
        {
            var devices = Devices.getDevices(token);
            Assert.IsNotNull(devices);
        }

        [TestMethod]
        public void CanGetProfile()
        {
            var profile = Profile.getProfile(token);
            Assert.IsNotNull(profile);
        }


        [TestMethod]
        public void CanGetSummaryHourly()
        {
            var summary = Summary.getSummaries(token, "hourly");
            Assert.IsNotNull(summary);
        }

        [TestMethod]
        public void CanGetSummaryDaily()
        {
            var summary = Summary.getSummaries(token, "daily");
            Assert.IsNotNull(summary);
        }

    }
}
