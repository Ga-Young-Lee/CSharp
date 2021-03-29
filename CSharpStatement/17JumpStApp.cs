using System;

namespace Statement
{
    class JumpStApp
        //메소드의 실행을 종료하고 호출한 메소드(caller)에게 제어를 넘겨주는 문장.return 문의 형태

    {
        static int sum(int s, int i)
        {
            return s + i;
        }
        static void Main(string[] args)
        {
            int n, s, i;
            for (; ; )
            {
                Console.Write("Enter a number : ");
                n = Int32.Parse(Console.ReadLine());
                if (n == 0) break;
                else if (n < 0) continue;
                for (s = 0, i = 1; i <= n; ++i)
                    s = sum(s, i);
                Console.WriteLine("n = {0}, sum = {1}", n, s);
            }
            Console.WriteLine("End of Main");





        }
    }
}
