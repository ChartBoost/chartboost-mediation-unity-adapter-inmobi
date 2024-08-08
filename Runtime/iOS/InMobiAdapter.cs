using System.Runtime.InteropServices;
using Chartboost.Constants;
using Chartboost.Mediation.InMobi.Common;
using UnityEngine;

namespace Chartboost.Mediation.InMobi.IOS
{
    internal class InMobiAdapter : IInMobiAdapter
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            InMobi.InMobiAdapter.Instance = new InMobiAdapter();
        }

        /// <inheritdoc/>
        public string AdapterNativeVersion => _CBMInMobiAdapterAdapterVersion();
        
        /// <inheritdoc/>
        public string PartnerSDKVersion => _CBMInMobiAdapterPartnerSDKVersion();
        
        /// <inheritdoc/>
        public string PartnerIdentifier => _CBMInMobiAdapterPartnerId();
        
        /// <inheritdoc/>
        public string PartnerDisplayName => _CBMInMobiAdapterPartnerDisplayName();
        
        /// <inheritdoc/>
        public bool VerboseLogging
        {
            get => _verboseLogging;
            set
            {
                _CBMInMobiExchangeAdapterSetVerboseLogging(value);
                _verboseLogging = value;
            }
        }

        // TODO - iOS does not provide getters for properties, keeping track of it on Unity for the time being. NOT IDEAL.
        private bool _verboseLogging;
        
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMInMobiAdapterAdapterVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMInMobiAdapterPartnerSDKVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMInMobiAdapterPartnerId();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMInMobiAdapterPartnerDisplayName();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMInMobiExchangeAdapterSetVerboseLogging(bool verboseLogging);
    }
}
