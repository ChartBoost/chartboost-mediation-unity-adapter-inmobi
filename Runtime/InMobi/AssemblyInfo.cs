using System.Runtime.CompilerServices;
using Chartboost.Mediation.InMobi;
using UnityEngine.Scripting;

[assembly: AlwaysLinkAssembly]
[assembly: InternalsVisibleTo(AssemblyInfo.InMobiAssemblyInfoAndroid)]
[assembly: InternalsVisibleTo(AssemblyInfo.InMobiAssemblyInfoIOS)]

namespace Chartboost.Mediation.InMobi
{
    internal class AssemblyInfo
    {
        public const string InMobiAssemblyInfoAndroid = "Chartboost.Mediation.InMobi.Android";
        public const string InMobiAssemblyInfoIOS = "Chartboost.Mediation.InMobi.IOS";
    }
}
