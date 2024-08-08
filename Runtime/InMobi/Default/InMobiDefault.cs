using Chartboost.Mediation.InMobi.Common;

namespace Chartboost.Mediation.InMobi.Default
{
    internal class InMobiDefault : IInMobiAdapter
    {
        /// <inheritdoc/>
        public string AdapterNativeVersion => InMobiAdapter.AdapterUnityVersion;

        /// <inheritdoc/>
        public string PartnerSDKVersion => InMobiAdapter.AdapterUnityVersion;
        
        /// <inheritdoc/>
        public string PartnerIdentifier => "inmobi";
        
        /// <inheritdoc/>
        public string PartnerDisplayName => "InMobi";
        
        /// <inheritdoc/>
        public bool VerboseLogging { get; set; }
    }
}
