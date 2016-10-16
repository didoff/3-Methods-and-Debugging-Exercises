using System;


namespace HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string yourName = Console.ReadLine();
            printName(yourName);
        }

        private static void printName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
