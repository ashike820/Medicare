using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, a = 5;
            string b = "5";
            c = Convert.ToInt32(b);
            int d = a + c;
            Console.WriteLine("Hello World!" + d);
        }
    }
}
