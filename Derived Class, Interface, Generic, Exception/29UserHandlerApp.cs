
using System;





namespace Derived_Class__Interface__Generic__Exception
{
    class UserExceptionOne : ApplicationException { }
    class UserExceptionTwo : ApplicationException { }
    class UserHandlerApp
    {
        static void Method(int i)
        {
            if (i == 1) throw new UserExceptionOne();
            else throw new UserExceptionTwo();
        }
        public static void Main()
        {
            try
            {
                Console.WriteLine("Here: 1");
                Method(2);
                Console.WriteLine("Here: 2");
            }
            catch (UserExceptionOne)
            {
                Console.WriteLine("UserExceptionOne is occurred!!!");
            }
            catch (UserExceptionTwo)
            {
                Console.WriteLine("UserExceptionTwo is occurred!!!");
            }
            Console.WriteLine("Here: 3");
        }
    }
}
