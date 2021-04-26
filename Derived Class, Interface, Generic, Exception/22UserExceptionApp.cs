
using System;





namespace Derived_Class__Interface__Generic__Exception
{
    class UserErrException : ApplicationException
    {
        public UserErrException(string s) : base(s) { }
    }
    class UserExceptionApp

    {
        public static void Main()
        {
            try
            {
                throw new UserErrException("throw a exception with a message");
            }
            catch (UserErrException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

}
