using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            double calculodesconto;
            double final;
            double valor;

            Console.WriteLine("Qual produto você deseja?");
            string nome = Console.ReadLine();

            Console.WriteLine($"Quantos produtos você deseja de {nome}?");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual o preço do produto {nome}?");
            double preco = double.Parse(Console.ReadLine());

            if (quantidade <= 5)
            {
                valor = quantidade * preco;
                calculodesconto = valor * 0.02;
                final = valor - calculodesconto;
                Console.WriteLine($"Voce escolheu o produto {nome}! \nVoce quis {quantidade} {nome}! \nE o valor foi de R${final}!");
            }
            else if (quantidade > 5 && quantidade <= 10)
            {
                valor = quantidade * preco;
                calculodesconto = valor * 0.03;
                final = valor - calculodesconto;
                Console.WriteLine($"Voce escolheu o produto {nome}! \nVoce quis {quantidade} {nome}! \nE o valor foi de R${final}!");
            }
            else if (quantidade > 10)
            {
                valor = quantidade * preco;
                calculodesconto = valor * 0.05;
                final = valor - calculodesconto;
                Console.WriteLine($"Voce escolheu o produto {nome}! \nVoce quis {quantidade} {nome}! \nE o valor foi de R${final}!");
            }
        }
    }
}
