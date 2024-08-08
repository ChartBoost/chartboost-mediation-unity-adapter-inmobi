using Chartboost.Logging;
using Chartboost.Mediation.InMobi;
using Chartboost.Tests.Runtime;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class InMobiAdapterTests
    {
        [SetUp]
        public void SetUp()
            => LogController.LoggingLevel = LogLevel.Debug;

        [Test]
        public void AdapterNativeVersion()
            => TestUtilities.TestStringGetter(() => InMobiAdapter.AdapterNativeVersion);

        [Test]
        public void PartnerSDKVersion()
            => TestUtilities.TestStringGetter(() => InMobiAdapter.PartnerSDKVersion);

        [Test]
        public void PartnerIdentifier()
            => TestUtilities.TestStringGetter(() => InMobiAdapter.PartnerIdentifier);

        [Test]
        public void PartnerDisplayName()
            => TestUtilities.TestStringGetter(() => InMobiAdapter.PartnerDisplayName);
        
        [Test]
        public void VerboseLogging()
            => TestUtilities.TestBooleanAccessor(() => InMobiAdapter.VerboseLogging, value => InMobiAdapter.VerboseLogging = value);
    }
}
