using System;

namespace Parameters
{
    class Pass
    {
        public static void Value( ref int param)
        {
            Console.WriteLine($"1. in method value, param is {param}");
            param = 42;
            Console.WriteLine($"2. in method value, param is {param}");
        }
        public static void Reference(WrappedInt param)
        {
            Console.WriteLine($"3. in method reference, param is {param}");
            param.Number = 42;
            Console.WriteLine($"4. in method reference, param is {param}");
        }
    }
}
