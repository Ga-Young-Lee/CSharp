using System;
using Shape;


namespace Derived_Class__Interface__Generic__Exception
{
    class NamespaceApp
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.width = 10;
            rect.height = 20;
            Console.WriteLine("rect : " + rect);
        }
    }
}
