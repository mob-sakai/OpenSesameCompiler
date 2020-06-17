using System;

namespace OSCTestLib
{
    /// <summary>
    /// フガフガ
    /// </summary>
    public class PublicClass
    {
        /// <summary>
        /// ホゲホゲ
        /// </summary>
        private string privateStringField = "privateStringField";

        /// <summary>
        /// フガフガ
        /// </summary>
        public static void PublicStaticMethod()
        {
            Console.WriteLine("PublicClass.PublicStaticMethod is called.");
            Console.WriteLine(new PublicClass().privateStringField);
        }
    }

    /// <summary>
    /// フガフガ
    /// </summary>
    internal class InternalClass
    {

        /// <summary>
        /// ホゲホゲ
        /// </summary>
        private string privateStringField = "privateStringField";

        /// <summary>
        /// フガフガ
        /// </summary>
        public static void PublicStaticMethod()
        {
            Console.WriteLine("InternalClass.PublicStaticMethod is called.");
            Console.WriteLine(new InternalClass().privateStringField);
        }
    }
}
