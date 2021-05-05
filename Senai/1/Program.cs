using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            string name = Console.ReadLine();

            Console.WriteLine("Bem Vindo " + name + "!!!");

            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            int idade_meses = idade * 12 ;

            int idade_dias = idade * 365;

            int idade_horas = idade * (24 * 365);

            int idade_minutos = idade * (1440 * 365);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("A sua idade em Meses e de " + idade_meses + " meses\n");
            Console.WriteLine("A sua idade em dias e de " + idade_dias + " dias\n");
            Console.WriteLine("A sua idade em horas e de " + idade_horas + " horas\n");
            Console.WriteLine("A sua idade em minutos e de " + idade_minutos + " minutos\n");
        }
    }
}
