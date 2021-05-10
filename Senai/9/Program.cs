using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] queijo = null;

            Console.WriteLine("Quantos Pacotes de Pão de queijo tem na prateleira?");
            int quantidade = int.Parse(Console.ReadLine());

            queijo = new int[quantidade];

            for (var i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Digite a quantidade de pão de queijo do " + (i + 1) + " pacote");
                queijo[i] = int.Parse(Console.ReadLine());
            }

            int q = 1;
            foreach (var item in queijo)
            {
                Console.WriteLine($"O {q} Pacote de pão de queijo tem: {item} pão de queijos");
                q++;
            }
        }
    }
}
