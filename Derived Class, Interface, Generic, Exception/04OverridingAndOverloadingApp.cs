using System;


namespace Derived_Class__Interface__Generic__Exception
{
    class BaseClass
    {
        public void MethodA()
        {
            Console.WriteLine("In the BaseClass ...");
        }
    }
    class DerivedClass : BaseClass
    {
        new public void MethodA()
        { // Overriding
            Console.WriteLine("In DerivedClass ... Overriding !!!");
        }
        public void MethodA(int i)
        { // Overloading
            Console.WriteLine("In DerivedClass ... Overloading !!!");
        }
    }
    class OverridingAndOverloadingApp
    {
        static void Main(string[] args)
        {
            BaseClass obj1 = new BaseClass();
            DerivedClass obj2 = new DerivedClass();
            obj1.MethodA();
            obj2.MethodA();
            obj2.MethodA(1);
        }
    }
}
