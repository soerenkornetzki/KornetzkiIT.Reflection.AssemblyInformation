using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: Guid("bdd40b20-b15c-4b84-825d-39cd7c479ea8")]

[assembly: AssemblyProduct("KornetzkiIT.Reflection.AssemblyInformation")]
[assembly: AssemblyTitle("KornetzkiIT.Reflection.AssemblyInformation")]
[assembly: AssemblyDescription("A .NET Standard class for quering common assembly attributes out of an specified assembly.")]
[assembly: AssemblyCompany("Kornetzki IT")]
[assembly: AssemblyCopyright("Copyright © 2019-2020 Sören Kornetzki")]
[assembly: AssemblyTrademark("")]

[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en-US", UltimateResourceFallbackLocation.MainAssembly)]

#if DEBUG && TRACE
[assembly: AssemblyConfiguration("Debug+Trace")]
#elif DEBUG
[assembly: AssemblyConfiguration("Debug")]
#elif TRACE
[assembly: AssemblyConfiguration("Release+Trace")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: ComVisible(true)]
[assembly: CLSCompliant(true)]

[assembly: AssemblyVersion("0.1.0.2")]
[assembly: AssemblyFileVersion("0.1.0.2")]
[assembly: AssemblyInformationalVersion("0.1.0-alpha.2")]
