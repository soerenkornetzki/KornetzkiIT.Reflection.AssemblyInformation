using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: Guid("4ee3d577-3c6e-41bf-a897-5d61fa2338de")]

[assembly: AssemblyProduct("KornetzkiIT.Reflection.AssemblyInformation")]
[assembly: AssemblyTitle("KornetzkiIT.Reflection.AssemblyInformation.UnitTest")]
[assembly: AssemblyDescription("Unit tests for KornetzkiIT.Reflection.AssemblyInformation")]
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

[assembly: ComVisible(false)]
[assembly: CLSCompliant(false)]

[assembly: AssemblyVersion("0.1.0.2")]
[assembly: AssemblyFileVersion("0.1.0.2")]
[assembly: AssemblyInformationalVersion("0.1.0-alpha.2")]
