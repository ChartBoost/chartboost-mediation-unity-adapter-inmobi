using Chartboost.Mediation.Adapters;
using Chartboost.Mediation.InMobi.Common;
using Chartboost.Mediation.InMobi.Default;

namespace Chartboost.Mediation.InMobi
{
    /// <inheritdoc cref="IInMobiAdapter"/>
    public static class InMobiAdapter 
    {
        internal static IInMobiAdapter Instance = new InMobiDefault();
        
        /// <summary>
        /// The partner adapter Unity version.
        /// </summary>
        public const string AdapterUnityVersion = "5.0.0";
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.AdapterNativeVersion"/>
        public static string AdapterNativeVersion => Instance.AdapterNativeVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerSDKVersion"/>
        public static string PartnerSDKVersion => Instance.PartnerSDKVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerIdentifier"/>
        public static string PartnerIdentifier => Instance.PartnerIdentifier;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerDisplayName"/>
        public static string PartnerDisplayName => Instance.PartnerDisplayName;

        /// <inheritdoc cref="IInMobiAdapter.VerboseLogging"/>
        public static bool VerboseLogging
        {
            get => Instance.VerboseLogging;
            set => Instance.VerboseLogging = value;
        }
    }
}
