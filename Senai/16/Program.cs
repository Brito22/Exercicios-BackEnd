using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 10;

            string[] lista = null;
            Console.WriteLine("Passe 10 Nomes");

            lista = new string[quantidade];

            for (var i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Qual e o {i} Nome ?");
                lista[i] = Console.ReadLine();
            }

            foreach (var item in lista)
            {
                Console.WriteLine("Fale mais um nome para ver se existe ou não:");
                string resposta = Console.ReadLine();

                if (resposta == item)
                {
                    Console.WriteLine("ACHEI SEU NOME");
                }
                else
                {
                    Console.WriteLine("NÃO ACHEI SEU NOME");
                }
            }

        }
    }
}