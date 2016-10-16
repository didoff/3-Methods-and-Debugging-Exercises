using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());
            int numberC = int.Parse(Console.ReadLine());

            GetMax(numberA, numberB, numberC);
        }

        private static void GetMax(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (a > b && c > a)
            {
                Console.WriteLine(c);
            }
            else if (a < b && c < b)
            {
                Console.WriteLine(b);
            }
            
        }

            
    }
}
