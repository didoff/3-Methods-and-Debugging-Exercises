using System;

namespace PriceChecker
{
    class PrimeChecker // 87/100 in JUDGE!!! :O
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(n));
        }

        private static bool IsPrime(ulong n)
        {

            if (n <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                //if (n % i == 0 && i != n)
                //{
                //    return false;
                //}
                if ((int)n % i == 0)
                {
                    return false;

                }
            
            }
            return true;
        }
    }
}
