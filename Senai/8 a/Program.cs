using System;

namespace _8_a
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibonacci = 0;
            int fibonacciTwo = 1;
            int total = 0;

            for (total = 0; total <= 610; total = fibonacci + fibonacciTwo)
            {
                fibonacci = fibonacciTwo;

                fibonacciTwo = total;

                Console.WriteLine("Contador Fibonacci: " + total);
            }
        }
    }
}
