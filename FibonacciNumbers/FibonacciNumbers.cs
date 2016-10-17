using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetNextFibNumber(n));
        }

        private static int GetNextFibNumber(int n)
        {
            int a = 1; // it not the real begining of the fibionacci number; should be 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }
    }
}
