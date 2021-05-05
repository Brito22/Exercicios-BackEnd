using System;

namespace _4_a
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";

                Console.WriteLine("Qual o seu nome Nadador?");
                string name = Console.ReadLine();

                Console.WriteLine("Bem Vindo " + name);

            do
            {
                Console.WriteLine("Qual a sua idade?");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 5 && idade <= 7)
                {
                    Console.WriteLine("Você pertence ao grupo INFANTIL A");
                }

                else if (idade >= 8 && idade <= 10)
                {
                    Console.WriteLine("Você pertence ao grupo INFANTIL B");
                }

                else if (idade >= 11 && idade <= 13)
                {
                    Console.WriteLine("Você pertence ao grupo JUVENIL A");
                }

                else if (idade >= 14 && idade <= 17)
                {
                    Console.WriteLine("Você pertence ao grupo JUVENIL B");
                }

                else
                {
                    Console.WriteLine("Voçê não pertence a nenhum grupo");
                }

                Console.WriteLine("Voce deseja fazer uma nova consulta? s/n");
                resposta = Console.ReadLine().ToLower();
    
            } while (resposta == "s");
        }
    }
}