using System;
using System.Linq.Expressions;

namespace Method_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(fibo(11));
            Console.WriteLine(fibo_2(11));
        }

        static int fibo(int n)
        {
                int[] Fibo = new int[n];

                Fibo[0] = 0;
                Fibo[1] = 1;

                for (int i = 2; i < n; i++)
                {
                    Fibo[i] = Fibo[i - 2] + Fibo[i - 1];
                }

                var result = Fibo[n - 1];
            return result;
        }

        static int fibo_2(int n)
        {
            if (n > 0)
            {
                int[] Fibo = new int[n];

                var index = n - 1;

                if (index == 0)
                {
                    return Fibo[index] = 0;
                }
                else if (index == 1)
                {
                    return Fibo[index] = 1;
                }

                return Fibo[index] = fibo_2(n - 2)+ fibo_2(n -1);                
               
            }

            return 0;
        }
    }
}
