using System;
using _3_exercicio.classes;

namespace _3_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe cafe = new MaquinaCafe();
            bool verificacao = false;

            Console.WriteLine("Bem Vindo!!!");

            do
            {

                Console.WriteLine("O que voce deseja? \n1 - Cafe com Açucar \n2 - Café sem Açucar \n3 - Sair");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("Ok, Voce o que voce deseja? \n1 - Escolher quantidade de açucar \n2 - açucar por padrão");
                        string escolha2 = Console.ReadLine();

                        if (escolha2 == "1")
                        {
                            Console.WriteLine("Ok, Quantas Gramas de açucar voce deseja?");
                            int quantidade = int.Parse(Console.ReadLine());
                            cafe.FazerCafe(1);
                            cafe.AcucarDisponivel = cafe.AcucarDisponivel - quantidade;
                            Console.WriteLine($"A maquina tem {cafe.AcucarDisponivel} gramas restante!!!");
                        }
                        else if (escolha2 == "2")
                        {
                            cafe.FazerCafe(1);
                            cafe.AcucarDisponivel = cafe.AcucarDisponivel - 10;
                            Console.WriteLine($"A maquina tem {cafe.AcucarDisponivel} gramas restante!!!, obs: 10 gramas por café!!! ");
                        }
                        break;

                    case "2":
                        cafe.FazerCafe("2");
                        break;

                    case "3":
                        Console.WriteLine("Ok, Volte Sempre!!!");
                        verificacao = true;
                        break;

                    default:
                        Console.WriteLine("Valor Incorreto, Tente Novamente");
                        break;
                }
            } while (verificacao == false);
        }
    }
}
