using System;

namespace Projeto_Passagens_Aéreas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validacao = false;
            bool cadastro = false;
            int quantidade = 5;
            string repetir = null;
            string senha = null;
            string menu = null;
            int c = 0;

            string[] usuario = null;
            usuario = new string[quantidade];

            string[] origem = null;
            origem = new string[usuario.Length];

            string[] destino = null;
            destino = new string[usuario.Length];

            string[] data = null;
            data = new string[usuario.Length];

            do
            {
                Console.WriteLine("Ola, Qual a seu senha para acessar o menu?");
                senha = Console.ReadLine();

                if (senha == "123456")
                {
                    Console.WriteLine("Senha Correta!");
                    validacao = true;
                }
                else
                {
                    Console.WriteLine("senha incorreta!, por favor, tente novamente!!!");
                }
            } while (validacao == false);

            do
            {
                Console.WriteLine("\nOk, o que você deseja? \n1 - Cadastrar passagem \n2 - Listar Passagens \n0 - Sair");
                menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        while (true)
                        {
                            Console.WriteLine("\nQuantas passagens você deseja cadastrar? \nATENÇÃO Maximo de 5 passagens!!!");
                            quantidade = int.Parse(Console.ReadLine());
                            for (var i = 0; i < quantidade; i++)
                            {
                                if (quantidade > 5)
                                {
                                    Console.WriteLine("Limite de 5 passageiros");
                                    break;
                                }
                                else
                                {
                                Console.WriteLine($"\n{i + 1} Cadastro!!!");

                                Console.WriteLine("Ok, Qual o seu nome?");
                                usuario[c] = Console.ReadLine();

                                Console.WriteLine("Qual a sua origem?");
                                origem[c] = Console.ReadLine();

                                Console.WriteLine("Qual o destino?");
                                destino[c] = Console.ReadLine();

                                Console.WriteLine("Qual a data do Voo?");
                                data[c] = Console.ReadLine();

                                Console.WriteLine($"\n{i + 1} Cadastro");
                                Console.WriteLine($"O nome Cadastrado foi {usuario[c]}");
                                Console.WriteLine($"A origem Cadastrada foi {origem[c]}");
                                Console.WriteLine($"O destino Cadastrado foi {destino[c]}");
                                Console.WriteLine($"A data Cadastrada foi {data[c]}\n");

                                c++;
                                }
                            }
                            Console.WriteLine($"\nVocê deseja cadastrar uma nova passagem? ainda faltam {5 - c++} cadastro!!! \n1 - Sim \n2 - Não");
                            repetir = Console.ReadLine();

                            if (repetir == "1")
                            {
                                Console.WriteLine($"\nVoce decidiu fazer outro cadastro!!!");
                            }
                            else if (repetir == "2")
                            {
                                Console.WriteLine("Ok\n");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Valor Invalido, Por favor, Tente Novamente!!!");
                                break;
                            }
                        }
                        break;

                    case "2":
                        for (var i = 0; i < quantidade; i++)
                        {
                            Console.WriteLine($"\n{i + 1} Cadastro");
                            Console.WriteLine($"O nome Cadastrado foi {usuario[i]}");
                            Console.WriteLine($"A origem Cadastrada foi {origem[i]}");
                            Console.WriteLine($"O destino Cadastrado foi {destino[i]}");
                            Console.WriteLine($"A data Cadastrada foi {data[i]}\n");
                        }
                        break;

                    case "0":
                        Console.WriteLine("Ok, Volte Sempre!!!");
                        cadastro = true;
                        break;

                    default:
                        Console.WriteLine("Valor Incorreto, Por favor, tente novamente!!!");
                        break;
                }

            } while (cadastro == false);
        }
    }
}
