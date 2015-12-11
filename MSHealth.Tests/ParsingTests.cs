using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MSHealth.Data;


namespace MSHealth.Tests
{
    [TestClass]
    public class ParsingTests
    {
        [TestMethod]
        public void CanParseActivities()
        {
            var activities = File.ReadAllText(@".\JsonResponses\Activities.json");
            var acts = Activities.ParseActivitiesResponse(activities);

            Assert.AreEqual(acts.NextPage, "string");
            Assert.AreEqual(acts.BikeActivities.Count(), 1);
            Assert.AreEqual(acts.FreePlayActivities .Count(), 1);
            Assert.AreEqual(acts.SleepActivities.First().ActivitySegments.First().DayId.Date, DateTime.Parse("2015-12-08T16:58:59.531Z").Date);
        }

        [TestMethod]
        public void CanParseDevices()
        {
            var device = File.ReadAllText(@".\JsonResponses\Device.json");
            var dev = Device.ParseDevicesResponse(device);

            Assert.AreEqual(dev.CreatedDate.Date, DateTime.Parse("2015-12-08T16:58:59.585Z").Date);
            Assert.AreEqual(dev.Id, "string");
            Assert.AreEqual(dev.HardwareVersion, "string");
        }

        [TestMethod]
        public void CanParseProfile()
        {
            var profile = File.ReadAllText(@".\JsonResponses\Profile.json");
            var prof = Profile.ParseProfileResponse(profile);

            Assert.AreEqual(prof.BirthDate.Date, DateTime.Parse("2015-12-08T16:58:59.591Z").Date);
            Assert.AreEqual(prof.Height, 0);
            Assert.AreEqual(prof.PreferredLocale, "string");
        }

        [TestMethod]
        public void CanParseSummary()
        {
            var summary = File.ReadAllText(@".\JsonResponses\Summaries.json");
            var sum = Summaries.ParseSummaryResponse(summary);

            Assert.AreEqual(sum.ItemCount, 0);
            Assert.AreEqual(sum.Summaries.First().StepsTaken, 0);
            Assert.AreEqual(sum.Summaries.First().DistanceSummary.ElevationGain, 0);
        }

        [TestMethod]
        public void CanGetActiviitesAsync()
        {
            var token =
                "Bearer EwCwAvF0BAAUkWhN6f8bO0%2bg89MA1fmZueWyRkQAARNLWoTUr1ezPuPDzr/J6CdQ1vUhHLEedYtSa3yUWAljJt5tZ8d8kqj6J8KtLtM0fhHdPRvjNoLUnFHW7m2AUdH3jVa6univy1Hlu/ztSszeKYgT%2bIXnSHwL8G4GcJF6lqd/1snHB/NmVWyITOQsjQfyd7%2bY7cV7cLykM1%2baApqHHoRQ9n/tLJRlO2IkXoGJHSNIs2pSgxlEiVcv/8QggbLDJdsa%2b6MRQcqoqG3fsva3UKpCUWT5X1llIjPNWIe1yDgNw5B%2b2wRFMNSQQxvYyyLHLlBqptk142q3ujaGJg2JBOdy9c45lV%2bbyrdvMTO6GdANIr5gzjqaNYLu4pgkhJUDZgAACMN2GZ5jQfEBgAHw1VXmh3V9nU/uBoN8U4xsGH7g841yvDv5Ba6ZQbaPuz8RgS6Ijp6lFrX54Vcx6znnTGoxyuSOTkYFXJ9PjfLXezGm5oRDZSq6lV9xvDU5w0fTzFb3e/fCwnm6F5J73ZOUJqoMV82w7oBvkY/DqXITiAIzyb8vITtrWgy1GBLcYMp3loc8kKJh4PLpDPekVFmyOwpN02SKNZM48Mk5akEUZ8j1IjGlvKUZd6wUdsqpd9GHQzuQTYqe9x3wc4wJyUrC7bc518mMOXjUNwvZz4iYJxZjQwtrvVybcdetCljZk/dfI8qJ3OE1sWQLlRCLzlM8LPS1K1lLVOOVsXtZ2ioXtCDGqi310uGBWH2BeE/TGlgOK9MMBQFHybWSqQSjLGZd2hFpJtoUHqDkJygt1f4%2bTBJW2aVEVmUEWchCCW3GwGEVz3VIt6m26i2UD4CkHFAwrZS4ayoijkWkKXVhYEgeutPxl9UoPnJgeGC22LYn50g6GQlKam5wi6ZVWYFoUcSGAQ%3d%3d";
            var devices = Main.GetDevices(token).Result;

            Assert.AreEqual(devices.);

        }
    }
}
