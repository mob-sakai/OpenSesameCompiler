using OSCTestLib;
using System;

namespace OSCTest
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			PublicClass.PublicStaticMethod();
			Console.WriteLine(new PublicClass().privateStringField);
			OSCTestLib.InternalClass.PublicStaticMethod();
		}
	}
}
