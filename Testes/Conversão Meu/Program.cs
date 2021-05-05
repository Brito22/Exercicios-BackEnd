using System;

namespace Conversão_Meu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a medida que deseja converter \n C-> de centimetros para polegadas \n P-> De polegadas para centimetros \n");
            bool C = bool.Parse(Console.ReadLine());
            bool P = bool.Parse(Console.ReadLine());

            Console.WriteLine("Qual valor você deseja converter?");
            double valor = double.Parse(Console.ReadLine());

            if (valor = C)
            {
                double centimetros = valor / 2.54;
            }
            else
            {
                double polegadas = valor * 2.54;
            }
        }
    }
}
