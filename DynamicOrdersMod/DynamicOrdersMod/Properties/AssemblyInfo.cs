using System.Reflection;
using System.Runtime.InteropServices;
using MelonLoader;

// SDK-style csproj auto-generates AssemblyTitle/Version/etc., so this file only
// carries MelonLoader-specific attributes and the COM-visible GUID.

[assembly: ComVisible(false)]
[assembly: Guid("4821dce2-9c1f-403d-a822-656e43ede965")]

[assembly: MelonInfo(typeof(DynamicOrdersMod.Core.ModEntry), "DynamicOrdersMod", "3.0.0", "akosmlnr", "Dynamic order scaling, dead drops, tolerance, wholesale, and events")]
[assembly: MelonGame("TVGS", "Schedule I")]
[assembly: AssemblyMetadata("NexusModID", "799")]
