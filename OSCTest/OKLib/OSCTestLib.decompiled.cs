using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: TargetFramework(".NETStandard,Version=v2.0", FrameworkDisplayName = "")]
[assembly: AssemblyCompany("Microsoft Corporation")]
[assembly: AssemblyConfiguration("Release")]
[assembly: AssemblyCopyright("© Microsoft Corporation. All rights reserved.")]
[assembly: AssemblyFileVersion("42.42.42.42424")]
[assembly: AssemblyInformationalVersion("3.5.0-dev")]
[assembly: AssemblyProduct("OSCTestLib")]
[assembly: AssemblyTitle("OSCTestLib")]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: AssemblyVersion("42.42.42.42")]
namespace OSCTestLib
{
	public class PublicClass
	{
		private string privateStringField = "privateStringField";

		public static void PublicStaticMethod()
		{
			Console.WriteLine("PublicClass.PublicStaticMethod is called.");
			Console.WriteLine(new PublicClass().privateStringField);
		}
	}
	internal class InternalClass
	{
		private string privateStringField = "privateStringField";

		public static void PublicStaticMethod()
		{
			Console.WriteLine("InternalClass.PublicStaticMethod is called.");
		}
	}
}
