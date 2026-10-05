using Chartboost.Editor;
using Chartboost.Mediation.InMobi;
using NUnit.Framework;

namespace Chartboost.Tests.Editor
{
    internal class VersionValidator
    {
        private const string UnityPackageManagerPackageName = "com.chartboost.mediation.unity.adapter.inmobi";
        private const string NuGetPackageName = "Chartboost.CSharp.Mediation.Unity.Adapter.InMobi";
        
        [Test]
        public void ValidateVersion() 
            => VersionCheck.ValidateVersions(UnityPackageManagerPackageName, NuGetPackageName, InMobiAdapter.AdapterUnityVersion);
    }
}
