#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            Month first = Month.January;
            Console.WriteLine($"1. {first}, {(int) first}");
            first++;
            Console.WriteLine($"2. {first}, {(int)first}");
            first = Month.December;
            Console.WriteLine($"3. {first}, {(int)first}");
            first++;
            Console.WriteLine($"4. {first}, {(int)first}");
            first+= 60;
            Console.WriteLine($"5. {first}, {(int)first}");
            Console.WriteLine("--------------------------------------");
            Date defaultDate = new Date();
            Console.WriteLine(defaultDate);
            Date birthday = new Date(1992, Month.September, 11);
            Console.WriteLine($"birthday is {birthday}");
            Date birthdaycopy = birthday;
            Console.WriteLine($"Value of copy is {birthdaycopy}");
            birthday.AdvanceMonth();
            Console.WriteLine($"New value of birthday is {birthday}");
            Console.WriteLine($"Value of copy is still {birthdaycopy}");
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
