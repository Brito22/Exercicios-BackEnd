using System;
using _1_exercicio.classes;

namespace _1_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador();

            Console.WriteLine("Bem Vindo Morador!!!");
            Console.WriteLine(elevador.Inicializa());

            elevador.Entrar();

            Console.WriteLine("Qual elevador voce vai pegar? \n1 - social \n2 - Funcionarios");
            string tipo = Console.ReadLine();

            switch (tipo)
            {
                case "1":
                    do
                    {
                        Console.WriteLine("Ok, O que desejam? \n1 - Subir \n2 - Descer \n3 - Entrar \n4 - Sair");
                        string escolha = Console.ReadLine();

                        switch (escolha)
                        {
                            case "1":
                                if (elevador.Subir() >= elevador.TotalAndares)
                                {
                                    Console.WriteLine("Você esta no ultimo andar, Não da para subir mais!!!");
                                }
                                else
                                {
                                    elevador.Subir();
                                    Console.WriteLine($"Voce esta no Andar {elevador.Subir()}");
                                }
                                break;

                            case "2":
                                if (elevador.Descer() <= 0)
                                {
                                    Console.WriteLine("Voce esta no terreo!!!, Não da para descer mais");
                                }
                                else
                                {
                                    elevador.Descer();
                                    Console.WriteLine($"Voce esta no Andar {elevador.Descer()}");
                                }
                                break;

                            case "3":
                                if (elevador.Entrar() >= elevador.CapacidadePessoas)
                                {
                                    Console.WriteLine("Elevador Cheio!!!");
                                }
                                else
                                {
                                    elevador.Entrar();
                                    Console.WriteLine($"O elevador tem {elevador.Entrar()} pessoas");
                                }
                                break;

                            case "4":
                                elevador.Sair();
                                Console.WriteLine($"O elevador tem {elevador.Sair()} pessoas");
                                break;

                            default:
                                Console.WriteLine("Valor Invalido, Tente Novamente!!!");
                                break;
                        }
                    } while (elevador.CapacidadeAtual >= 0);
                    break;

                case "2":
                    do
                    {
                        Console.WriteLine("Ok, O que desejam? \n1 - Subir \n2 - Descer \n3 - Entrar \n4 - Sair");
                        string escolha = Console.ReadLine();

                        switch (escolha)
                        {
                            case "1":
                                if (elevador.Subir() >= elevador.TotalAndares)
                                {
                                    Console.WriteLine("Você esta no ultimo andar, Não da para subir mais!!!");
                                }
                                else
                                {
                                    elevador.Subir();
                                    Console.WriteLine($"Voce esta no Andar {elevador.Subir()}");
                                }
                                break;

                            case "2":
                                if (elevador.Descer() <= 0)
                                {
                                    Console.WriteLine("Voce esta no terreo!!!, Não da para descer mais");
                                }
                                else
                                {
                                    elevador.Descer();
                                    Console.WriteLine($"Voce esta no Andar {elevador.Descer()}");
                                }
                                break;

                            case "3":
                                if (elevador.Entrar() >= elevador.CapacidadeCaixas)
                                {
                                    Console.WriteLine("Elevador Cheio!!!");
                                }
                                else
                                {
                                    elevador.Entrar();
                                    Console.WriteLine($"O elevador tem {elevador.Entrar()} Caixas");
                                }
                                break;

                            case "4":
                                elevador.Sair();
                                Console.WriteLine($"O elevador tem {elevador.Sair()} Caixas");
                                break;

                            default:
                                Console.WriteLine("Valor Invalido, Tente Novamente!!!");
                                break;
                        }
                    } while (elevador.CapacidadeAtual >= 0);
                    break;

                default:
                    break;
            }


        }
    }
}
