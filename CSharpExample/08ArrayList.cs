using System;
using System.Collections;


namespace CSharpExample
{

    class ArrayList
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList a = new System.Collections.ArrayList();
            Random r = new Random();
            PrintValues(a);
            for (int i = 0; i < 10; i++)
                a.Add(r.Next(100));
            PrintValues(a);
            a.Sort();
            PrintValues(a);
            a.RemoveAt(3);
            PrintValues(a);
        }
        private static void PrintValues(System.Collections.ArrayList a)
        {
            Console.WriteLine("Print Values in ArrayList");
            Console.WriteLine(" Count = {0}", a.Count);
            Console.WriteLine(" Capacity = {0}", a.Capacity);
            foreach (var i in a)
                Console.Write(" {0}", i);
            Console.WriteLine();
        }
    }


}



