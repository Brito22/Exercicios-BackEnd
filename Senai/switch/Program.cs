using System;

namespace SWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um numero de 1 a 10 em numeros romanos");
            Console.WriteLine("Exemplo: \nI\nII\nIII\nIV\nV");
            string numero = Console.ReadLine().ToUpper();

            switch (numero)
            {
                case "I":
                    Console.WriteLine("O valor " + numero + " equivale a 1 em Indo-Arábicos");
                    break;

                case "II":
                    Console.WriteLine("O valor " + numero + " equivale a 2 em Indo-Arábicos");
                    break;

                case "III":
                    Console.WriteLine("O valor " + numero + " equivale a 3 em Indo-Arábicos");
                    break;

                case "IV":
                    Console.WriteLine("O valor " + numero + " equivale a 4 em Indo-Arábicos");
                    break;

                case "V":
                    Console.WriteLine("O valor " + numero + " equivale a 5 em Indo-Arábicos");
                    break;

                case "VI":
                    Console.WriteLine("O valor " + numero + " equivale a 6 em Indo-Arábicos");
                    break;

                case "VII":
                    Console.WriteLine("O valor " + numero + " equivale a 7 em Indo-Arábicos");
                    break;

                case "VIII":
                    Console.WriteLine("O valor " + numero + " equivale a 8 em Indo-Arábicos");
                    break;

                case "IX":
                    Console.WriteLine("O valor " + numero + " equivale a 9 em Indo-Arábicos");
                    break;

                case "X":
                    Console.WriteLine("O valor " + numero + " equivale a 10 em Indo-Arábicos");
                    break;

                default:
                    Console.WriteLine("Valor Invalido, Tente novamente!!!");
                    break;
            }
            
        }
    }
}
