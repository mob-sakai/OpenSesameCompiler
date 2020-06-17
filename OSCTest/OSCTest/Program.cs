using System;
using OSCTestLib;

[assembly: System.Runtime.CompilerServices.IgnoresAccessChecksTo("OSCTestLib")]
namespace System.Runtime.CompilerServices
{
    [System.AttributeUsage(System.AttributeTargets.Assembly, AllowMultiple = true)]
    public class IgnoresAccessChecksToAttribute : System.Attribute
    {
        public IgnoresAccessChecksToAttribute(string assemblyName)
        {
            AssemblyName = assemblyName;
        }

        public string AssemblyName { get; }
    }
}

namespace OSCTest
{
    class Program
    {
        static void Main(string[] args)
        {
            PublicClass.PublicStaticMethod();

            Console.WriteLine(new PublicClass().privateStringField);

            InternalClass.PublicStaticMethod();

            Console.WriteLine(new InternalClass().privateStringField);
        }
    }
}

