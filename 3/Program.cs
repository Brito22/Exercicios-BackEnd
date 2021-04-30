using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome do Funcionario?");
            string name = Console.ReadLine();

            Console.WriteLine("Bem Vindo " + name);

            Console.WriteLine("Qual o seu Salario?");
            int salario = int.Parse(Console.ReadLine());

            if (salario < 500)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                var aumento = salario * 0.3;
                double salario_final = salario + aumento;
                Console.WriteLine("Você recebeu aumento!!!");
                Console.WriteLine("Seu salario agora e de R$" + salario_final);
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("O seu salario não esta disponivel para aumento!!!");
            }
        }
    }
}
