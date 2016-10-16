using System;

namespace MaxMethod
{
    class MaxMethod
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());
            int numberC = int.Parse(Console.ReadLine());
            
            int result = GetMax(numberA, numberB);
            Console.WriteLine(GetMax(result, numberC));
        }

        private static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
                return b;
        }

            
    }
}
