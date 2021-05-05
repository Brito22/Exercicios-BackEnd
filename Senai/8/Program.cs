using System;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int x = 1, y = 0, z = 0;
            n = int.Parse(Console.ReadLine());
            for (int fibonacci = 0; fibonacci <= 500; fibonacci++)
            {
                z = x + y;
                Console.WriteLine("Fibonacci " + z);
                y = x;
                x = z;
            }
            Console.ReadLine();
        }
    }
}
