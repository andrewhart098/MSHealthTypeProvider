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
            var dev = Devices.ParseDevicesResponse(device);

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
            var sum = Summary.ParseSummaryResponse(summary);

            Assert.AreEqual(sum.ItemCount, 0);
            Assert.AreEqual(sum.Summaries.First().StepsTaken, 0);
            Assert.AreEqual(sum.Summaries.First().DistanceSummary.ElevationGain, 0);
        }
    }
}
