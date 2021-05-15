using System;

namespace Calculadora_Modificada
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 5;

            double[] Num;
            Num = new double[quantidade];

            string[] operacao;
            operacao = new string[quantidade];

            double Somar;
            double Subtrair;
            double Multiplicacao;
            double Divisao;

            Console.WriteLine("Quantos Numeros deseja Calcular");
            quantidade = int.Parse(Console.ReadLine());

            for (var i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Ok, Qual e o {Num[i + 1]}");
                Num[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("Escolha o Sinal para a operação \n1 - Somar \n2 - subtrair \n3 - Multiplicação \n4 - Divisão");
                operacao[i] = Console.ReadLine();

                switch (operacao[i])
                {
                    case "1":
                        Somar = Num[i] + Num[i];
                        break;
                    case "2":
                        Subtrair = Num[i] - Num[i];
                        break;
                    case "3":
                        Multiplicacao = Num[i] * Num[i];
                        break;
                    case "4":
                        Divisao = Num[i] / Num[i];
                        break;

                    default:
                        Console.WriteLine("Valor Invalido, Por Favor, Tente Novamente!!!");
                        break;
                }
                
            }
            Console.WriteLine($"O resultado foi{Num[quantidade]}");
        }
    }
}
