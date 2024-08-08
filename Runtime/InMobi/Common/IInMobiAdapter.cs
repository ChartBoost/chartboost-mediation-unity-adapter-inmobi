using Chartboost.Mediation.Adapters;

namespace Chartboost.Mediation.InMobi.Common
{
    /// <summary>
    /// The Chartboost Mediation InMobi adapter.
    /// </summary>
    internal interface IInMobiAdapter : IPartnerAdapterConfiguration
    {
        /// <summary>
        /// Enable/disable InMobi's verbose logging.
        /// </summary>
        bool VerboseLogging { get; set; }
    }
}
