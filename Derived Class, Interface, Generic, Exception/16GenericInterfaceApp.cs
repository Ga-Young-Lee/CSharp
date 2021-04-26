using System;



namespace Derived_Class__Interface__Generic__Exception
{
    interface IGenericInterface<T>
    {
        void setValue(T x);
        string getValueType();
    }
    class GenericClass<T> : IGenericInterface<T>
    {
        private T value;
        public void setValue(T x)
        {
            value = x;
        }
        public string getValueType()
        {
            return value.GetType().ToString();
        }
    }
    public class GenericInterfaceApp
    {
        public static void Main()
        {
            GenericClass<Int32> gInteger = new GenericClass<Int32>();
            GenericClass<String> gString = new GenericClass<String>();
            gInteger.setValue(10);
            gString.setValue("Text");
            Console.WriteLine(gInteger.getValueType());
            Console.WriteLine(gString.getValueType());
        }
    }
}
