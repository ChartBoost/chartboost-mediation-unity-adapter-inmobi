#import "CBMDelegates.h"
#import "ChartboostUnityUtilities.h"
#import <InMobiSDK/InMobiSDK-Swift.h>
#import <ChartboostMediationAdapterInMobi/ChartboostMediationAdapterInMobi-Swift.h>

extern "C" {

    const char * _CBMInMobiAdapterAdapterVersion(){
        return toCStringOrNull([InMobiAdapterConfiguration adapterVersion]);
    }

    const char * _CBMInMobiAdapterPartnerSDKVersion(){
        return toCStringOrNull([InMobiAdapterConfiguration partnerSDKVersion]);
    }

    const char * _CBMInMobiAdapterPartnerId(){
        return toCStringOrNull([InMobiAdapterConfiguration partnerID]);
    }

    const char * _CBMInMobiAdapterPartnerDisplayName(){
        return toCStringOrNull([InMobiAdapterConfiguration partnerDisplayName]);
    }

    void _CBMInMobiExchangeAdapterSetVerboseLogging(BOOL verboseLogging){
        if (verboseLogging)
            [IMSdk setLogLevel:IMSDKLogLevelDebug];
        else
            [IMSdk setLogLevel:IMSDKLogLevelNone];
    }
}
