
using System;





namespace Derived_Class__Interface__Generic__Exception
{
    class SystemHandlerApp

    {
        public static void Main()
        {
            int[] vector = { 1, 2, 3 };
            try
            {
                Console.WriteLine("Here: 1");
                vector[4] = 4;
                Console.WriteLine("Here: 2");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("System Exception is occurred!!!");
            }
            Console.WriteLine("Here: 3");
        }
    }
}
