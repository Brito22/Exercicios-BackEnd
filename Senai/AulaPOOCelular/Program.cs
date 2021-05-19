using System;

namespace AulaPOOCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validacao = false;
            bool validacao2 = false;
            Console.WriteLine("Bem Vindo!!!");
            Celular classe = new Celular();

            do
            {
                Console.WriteLine("Qual o Modelo do celular?");
                classe.modelo = Console.ReadLine();

                Console.WriteLine($"Qual a cor do {classe.modelo}?");
                classe.cor = Console.ReadLine();

                Console.WriteLine($"Qual o Tamanho do {classe.modelo}?");
                classe.tamanho = double.Parse(Console.ReadLine());

                Console.WriteLine($"Ok, você escolheu o {classe.modelo} voce deseja liga-lo? (s/n)");
                string ligar = Console.ReadLine().ToLower();

                if (ligar == "s")
                {
                    classe.ligado = true;
                }
                else if (ligar == "n")
                {
                    classe.ligado = false;
                }
                else
                {
                    Console.WriteLine("Valor Incorreto, Por Favor Tente Novamente!!!");
                }

                do
                {


                    if (classe.ligado == true)
                    {
                        Console.WriteLine($"Ok, Você Ligou o {classe.modelo} o que você deseja? \n1 - ligação \n2 - enviar mensagem \n3 - Desligar o {classe.modelo}");
                        string ativo = Console.ReadLine();
                        switch (ativo)
                        {
                            case "1":
                                Console.WriteLine("Você decidiu fazer uma ligação, escreva o numero de telefone para fazer a ligação!");
                                string number = Console.ReadLine();
                                break;

                            case "2":
                                Console.WriteLine("Você decidiu Mandar uma mensagem, escreva o nome e a mensagem para a pessoa desejada!");
                                string mensagem = Console.ReadLine();
                                break;

                            case "3":
                                validacao2 = true;
                                break;

                            default:
                                Console.WriteLine("Valor Incorreto, Por Favor Tente Novamente!!!");
                                break;
                        }
                    }
                } while (validacao2 == false);

                Console.WriteLine("Ok, O que você deseja? \n1 - Cadastrar outro celular \n2 - Sair");
                string escolha = Console.ReadLine();

                if (escolha == "1")
                {
                    Console.WriteLine("Ok, Você escolheu cadastrar outro celular!!!");
                }
                else if (escolha == "2")
                {
                    Console.WriteLine("Ok, Volte sempre!!!");
                    validacao = true;
                }

                else if (classe.ligado == false)
                {
                    Console.WriteLine("Ok, O que você deseja? \n1 - Cadastrar outro celular \n2 - Sair");
                    escolha = Console.ReadLine();

                    if (escolha == "1")
                    {
                        Console.WriteLine("Ok, Você escolheu cadastrar outro celular!!!");
                    }
                    else if (escolha == "2")
                    {
                        Console.WriteLine("Ok, Volte sempre!!!");
                        validacao = true;
                    }
                }
            } while (validacao == false);
        }
    }
}
