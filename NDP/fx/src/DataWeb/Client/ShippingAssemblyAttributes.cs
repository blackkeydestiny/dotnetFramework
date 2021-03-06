//---------------------------------------------------------------------
// <copyright file="ShippingAssemblyAttributes.cs" company="Microsoft">
//      Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// <summary>
//      Declares assembly-level attributes.
// </summary>
//---------------------------------------------------------------------

[assembly: System.Security.SecurityCritical]

#if ASTORIA_LIGHT 
// 

[assembly: System.Reflection.AssemblyVersion(ThisAssembly.Version)]
[assembly: System.Reflection.AssemblyFileVersion(ThisAssembly.InformationalVersion)]
[assembly: System.Reflection.AssemblyInformationalVersion(ThisAssembly.InformationalVersion)]
[assembly: System.Resources.SatelliteContractVersion(ThisAssembly.Version)]

internal static class ThisAssembly
{
    internal const string Version = "2.0.5.0";
    internal const string InformationalVersion = "2.0.40216.0";
}

internal static class AssemblyRef
{
    internal const string MicrosoftSilverlightPublicKeyToken                    = "b03f5f7f11d50a3a";
}

#endif
