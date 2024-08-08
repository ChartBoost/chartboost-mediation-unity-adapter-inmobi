# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.0.0 *(2024-08-08)*

First version of the Chartboost Mediation Unity SDK - InMobi Adapter.

#Added
- Support for the following `InMobi` dependencies. Notice adapter dependencies are optimistic and any patches and hot-fixes will be automatically picked up.:
    * Android: `com.chartboost:chartboost-mediation-adapter-inmobi:5.10.7.+`
    * iOS: `ChartboostMediationAdapterInMobi ~> 5.10.7.0`
    
- `InMobiAdapter.cs` with Configuration Properties for `InMobi`.
- The following properties have been added in `InMobiAdapter.cs`
    * `string AdapterUnityVersion`
    * `string AdapterNativeVersion`
    * `string PartnerSDKVersion`
    * `string PartnerIdentifier`
    * `string PartnerDisplayName`
    * `bool VerboseLogging`