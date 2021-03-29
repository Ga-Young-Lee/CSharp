using System;

namespace Statement
{
    class AssingmentStApp
    {
        static void Main(string[] args)
        {
            short s; int i;
            float f; double d;
            s = 526;
            d = f = i = s; // i = s;는 가능하지만 s = i;는 안됨 
            Console.WriteLine("s = " + s + " i = " + i);
            Console.WriteLine("f = " + f + " d = " + d);

        }
    }
}
