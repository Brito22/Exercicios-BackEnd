using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = null;
            decimal[] quantidadeprodutos = null;
            decimal[] valor = null;

            Console.WriteLine("Quantos Produtos voce deseja cadastrar?");
            int quantidade = int.Parse(Console.ReadLine());

            produtos = new string[quantidade];
            quantidadeprodutos = new decimal[quantidade];
            valor = new decimal[quantidade];

            for (var i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Digite o nome dos produtos que deseja cadastrar");
                produtos[i] = Console.ReadLine();
            }

            for (var i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Quantos produtos vc deseja " + produtos[i]);
                quantidadeprodutos[i] = decimal.Parse(Console.ReadLine());
            }

            for (var i = 0; i < quantidade; i++)
            {
                Console.WriteLine("qual o valor do " + produtos[i]);
                valor[i] = decimal.Parse(Console.ReadLine());
                decimal conta = quantidadeprodutos[i] * valor[i];
            }

            int c = 1;
            foreach (var item in produtos)
            {
                Console.WriteLine($"Voce decidiu cadastrar {item}");
                c++;
            }

            int v = 1;
            foreach (var item in quantidadeprodutos)
            {
                Console.WriteLine($"Com a quantidade de {item}");
                v++;
            }

            int b = 1;
            foreach (var item in valor)
            {
                Console.WriteLine($"No valor de {item}");
                b++;
            }


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($@"
            --------------------------------------------------
            Produto             Quantidade              Valor
            --------------------------------------------------");
            for (var i = 0; i <= quantidade; i++)
            {
                foreach (var item in produtos[i] + quantidadeprodutos[i] + valor[i])
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($@"
            --------------------------------------------------
            {produtos[i]}                  {quantidadeprodutos[i]}                {valor[i]}
            --------------------------------------------------");
                }
            }
        }
    }
}
