# Chartboost Mediation Unity SDK - InMobi Adapter

Provides a list of externally configurable properties pertaining to the partner SDK that can be retrieved and set by publishers. 

Dependencies for the adapter are now embedded in the package, and can be found at `com.chartboost.mediation.unity.adapter.inmobi/Editor/InMobiAdapterDependencies.xml`.

# Installation

## Using the public [npm registry](https://www.npmjs.com/search?q=com.chartboost.mediation.unity.adapter.inmobi)

In order to add the Chartboost Mediation Unity SDK - InMobi Adapter to your project using the npm package, add the following to your Unity Project's ***manifest.json*** file. The scoped registry section is required in order to fetch packages from the NpmJS registry.

```json
"dependencies": {
    "com.chartboost.mediation.unity.adapter.inmobi": "5.0.0",
    ...
},
"scopedRegistries": [
{
    "name": "NpmJS",
    "url": "https://registry.npmjs.org",
    "scopes": [
    "com.chartboost"
    ]
}
]
```
## Using the public [NuGet package](https://www.nuget.org/packages/Chartboost.CSharp.Mediation.Unity.Adapter.InMobi)

To add the Chartboost Mediation Unity SDK - InMobi Adapter to your project using the NuGet package, you will first need to add the [NugetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) package into your Unity Project.

This can be done by adding the following to your Unity Project's ***manifest.json***

```json
  "dependencies": {
    "com.github-glitchenzo.nugetforunity": "https://github.com/GlitchEnzo/NuGetForUnity.git?path=/src/NuGetForUnity",
    ...
  },
```

Once <code>NugetForUnity</code> is installed, search for `Chartboost.CSharp.Mediation.Unity.Adapter.InMobi` in the search bar of Nuget Explorer window(Nuget -> Manage Nuget Packages).
You should be able to see the `Chartboost.CSharp.Mediation.Unity.Adapter.InMobi` package. Choose the appropriate version and install.

# Usage
The following code block exemplifies usage of the `InMobiAdapter.cs` configuration class.

## IPartnerAdapterConfiguration Properties

```csharp

// AdapterUnityVersion - The partner adapter Unity version, e.g: 5.0.0
Debug.Log($"Adapter Unity Version: {InMobiAdapter.AdapterUnityVersion}");

// AdapterNativeVersion - The partner adapter version, e.g: 5.10.7.4.0
Debug.Log($"Adapter Native Version: {InMobiAdapter.AdapterNativeVersion}");

// PartnerSDKVersion - The partner SDK version, e.g: 10.7.4
Debug.Log($"Partner SDK Version: {InMobiAdapter.PartnerSDKVersion}");

// PartnerIdentifier - The partner ID for internal uses, e.g: inmobi
Debug.Log($"Partner Identifier: {InMobiAdapter.PartnerIdentifier}");

// PartnerDisplayName - The partner name for external uses, e.g: InMobi
Debug.Log($"Partner Display Name: {InMobiAdapter.PartnerDisplayName}");
```

## Verbose Logging
To enable verbose logging for the InMobi adapter, the following property has been made available:

```csharp
InMobiAdapter.VerboseLogging = true;
```

# Additional Configurations

It is highly recommended that you include `ACCESS_FINE_LOCATION` to enable better ad targeting. This is not mandatory permission; however, including it will enable accurate ad targeting.

```xml
<uses-permission android:name="android.permission.ACCESS_FINE_LOCATION" />
```

For further improved targeting, you can add the `ACCESS_WIFI_STATE` and `CHANGE_WIFI_STATE` permissions to the manifest.

```xml
<uses-permission android:name="android.permission.ACCESS_WIFI_STATE" />
<uses-permission android:name="android.permission.CHANGE_WIFI_STATE" />
```

Google now requires app developers that use the Android Advertising ID (AAID) to declare the `AD_ID` permission when their apps target Android 13 or above. You can declare the `AD_ID` permission to the manifest as follow:

```xml
<uses-permission android:name="com.google.android.gms.permission.AD_ID"/>
```

## Hardware Acceleration

Hardware acceleration allows you to display HTML5 video ads. To do this, add hardwareAccelerated:true element to the application tag.

```xml
<application 
    ... 
    android:hardwareAccelerated="true" 
    ... 
>
```