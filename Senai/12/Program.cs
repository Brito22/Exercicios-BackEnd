using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            double calculo;
            double quantidade;
            double valor;

            Console.WriteLine("Bem Vindo!!!, o que você deseja \nA - Álcool \nG - Gasolina");
            string combustivel = Console.ReadLine().ToUpper();

            if (combustivel == "A")
            {
                Console.WriteLine("Ok, quantos litros você deseja?");
                quantidade = double.Parse(Console.ReadLine());

                valor = quantidade * 4.90;

                switch (quantidade)
                {
                    case <= 20:
                        calculo = valor * 0.03;
                        Console.WriteLine($"O valor foi de R${valor - calculo}");
                        break;
                    case >= 20:
                        calculo = valor * 0.05;
                        Console.WriteLine($"O valor foi de R${valor - calculo}");
                        break;
                    default:
                        break;
                }
            }
            else if (combustivel == "G")
            {
                Console.WriteLine("Ok, quantos litros você deseja?");
                quantidade = double.Parse(Console.ReadLine());

                valor = quantidade * 5.30;

                switch (quantidade)
                {
                    case <= 20:
                        calculo = valor * 0.04;
                        Console.WriteLine($"O valor foi de R${valor - calculo}");
                        break;
                    case >= 20:
                        calculo = valor * 0.06;
                        Console.WriteLine($"O valor foi de R${valor - calculo}");
                        break;
                    default:
                        break;
                }
            }
        }


    }
}

