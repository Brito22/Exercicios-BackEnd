using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome?");
            string name = Console.ReadLine();

            Console.WriteLine("Bem Vindo " + name + "!!!");

            Console.WriteLine("Em que ano você nasceu?");
            int data = int.Parse(Console.ReadLine());

            int idade = 2021 - data;
            int idade_semana = data * 52;
            
            if (data > 2021)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Sua idade não pode ser calculada");
            }

            else if (data < 1870)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Sua idade não pode ser calculada");
            }
            else
            {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Sua idade é " + idade + " Anos");
            Console.WriteLine("Sua idade em semanas é " + idade_semana);
            }
        }
    }
}
