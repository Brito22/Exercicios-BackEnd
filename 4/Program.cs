using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome Nadador?");
            string name = Console.ReadLine();

            Console.WriteLine("Bem Vindo " + name);

            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade == 5)
            {
                Console.WriteLine("Você pertence ao grupo INFANTIL A");
            }
            else if (idade == 6)
            {
                Console.WriteLine("Você pertence ao grupo INFANTIL A");
            }
            else if (idade == 7)
            {
                Console.WriteLine("Você pertence ao grupo INFANTIL A");
            }


            else if (idade == 8)
            {
                Console.WriteLine("Você pertence ao grupo INFANTIL B");
            }
            else if (idade == 9)
            {
                Console.WriteLine("Você pertence ao grupo INFANTIL B");
            }
            else if (idade == 10)
            {
                Console.WriteLine("Você pertence ao grupo INFANTIL B");
            }

            
            else if (idade == 11)
            {
                Console.WriteLine("Você pertence ao grupo JUVENIL A");
            }
            else if (idade == 12)
            {
                Console.WriteLine("Você pertence ao grupo JUVENIL A");
            }
            else if (idade == 13)
            {
                Console.WriteLine("Você pertence ao grupo JUVENIL A");
            }


            else if (idade == 14)
            {
                Console.WriteLine("Você pertence ao grupo JUVENIL B");
            }
            else if (idade == 15)
            {
                Console.WriteLine("Você pertence ao grupo JUVENIL B");
            }
            else if (idade == 16)
            {
                Console.WriteLine("Você pertence ao grupo JUVENIL B");
            }
            else if (idade == 17)
            {
                Console.WriteLine("Você pertence ao grupo JUVENIL B");
            }


            else if (idade >= 18)
            {
                Console.WriteLine("Você pertence ao grupo SÊNIOR");
            }
            else
            {
                Console.WriteLine("Voçê não pertence a nenhum grupo");
            }
        }
    }
}
