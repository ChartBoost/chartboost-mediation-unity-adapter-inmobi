using Chartboost.Constants;
using Chartboost.Mediation.InMobi.Common;
using UnityEngine;

namespace Chartboost.Mediation.InMobi.Android
{
    internal sealed class InMobiAdapter : IInMobiAdapter
    {
        private const string InMobiAdapterConfiguration = "com.chartboost.mediation.inmobiadapter.InMobiAdapterConfiguration";

        private const string InMobiLogLevel = "com.inmobi.sdk.InMobiSdk$LogLevel";
        private const string InMobiLogLevelDebug = "DEBUG";
        private const string InMobiLogLevelError = "ERROR";
        
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            InMobi.InMobiAdapter.Instance = new InMobiAdapter();
        }
        
        /// <inheritdoc/>
        public string AdapterNativeVersion
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(InMobiAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetAdapterVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerSDKVersion 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(InMobiAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerSdkVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerIdentifier
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(InMobiAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerId);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerDisplayName 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(InMobiAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerDisplayName);
            }
        }
        
        /// <inheritdoc/>
        public bool VerboseLogging
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(InMobiAdapterConfiguration);
                using var logLevel = adapterConfiguration.Call<AndroidJavaObject>(SharedAndroidConstants.FunctionGetLogLevel);
                return logLevel.ToString() switch
                {
                    InMobiLogLevelDebug => true,
                    _ => false
                };
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(InMobiAdapterConfiguration);
                using var enumClass = new AndroidJavaClass(InMobiLogLevel);
                using var level = enumClass.GetStatic<AndroidJavaObject>(value ? InMobiLogLevelDebug : InMobiLogLevelError);
                adapterConfiguration.Call(SharedAndroidConstants.FunctionSetLogLevel, level);
            }
        }
    }
}
