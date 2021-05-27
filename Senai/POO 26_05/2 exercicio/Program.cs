using System;
using _2_exercicio.classes;

namespace _2_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            CadastroJogador cadastro = new CadastroJogador();

            string posicao;

            int calculo1;
            int calculo2;
            int calculo3;

            Console.WriteLine("Bem Vindo!!!");

            Console.WriteLine("Qual o seu nome?");
            cadastro.nome = Console.ReadLine();

            Console.WriteLine("Qual o seu ano de nascimento?");
            cadastro.data = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua nascionalidade?");
            cadastro.nacionalidade = Console.ReadLine();

            Console.WriteLine("Qual a sua altura?");
            cadastro.altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu peso?");
            cadastro.peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Ok Obrigado pelas informações");
            Console.WriteLine(cadastro.Informar());

            Console.WriteLine("Você tem " + cadastro.idade() + " Anos");

            do
            {
                Console.WriteLine("Em qual Posição voce joga? \n1 - Ataque \n2 - Defesa \n3 - Meio de Campo");
                posicao = Console.ReadLine();

                switch (posicao)
                {
                    case "1":
                        calculo1 = cadastro.JOGADORATAQUE - cadastro.idade();
                        Console.WriteLine($"Você tem {cadastro.idade()} anos, e Você pode se aposentar com 35 anos");
                        if (calculo1 >= 35)
                        {
                            Console.WriteLine("Você Ja pode se aposentar!!!");
                        }
                        else
                        {
                            Console.WriteLine($"Ainda Faltam {calculo1} anos para voce se aposentar");
                        }
                        break;

                    case "2":
                        calculo2 = cadastro.JOGADORDEFESA - cadastro.idade();
                        Console.WriteLine($"Você tem {cadastro.idade()} anos, e Você pode se aposentar com 40 anos");
                        if (calculo2 >= 40)
                        {
                            Console.WriteLine("Você Ja pode se aposentar!!!");
                        }
                        else
                        {
                            Console.WriteLine($"Ainda Faltam {calculo2} anos para voce se aposentar");
                        }
                        break;

                    case "3":
                        calculo3 = cadastro.JOGADORMEIO_CAMPO - cadastro.idade();
                        Console.WriteLine($"Você tem {cadastro.idade()} anos, e Você pode se aposentar com 38 anos");
                        if (calculo3 >= 38)
                        {
                            Console.WriteLine("Você Ja pode se aposentar!!!");
                        }
                        else
                        {
                            Console.WriteLine($"Ainda Faltam {calculo3} anos para voce se aposentar");
                        }
                        break;

                    default:
                        Console.WriteLine("Valor Invalido, Tente Novamente");
                        break;
                }
            } while (posicao != "1" && posicao != "2" && posicao != "3");
        }
    }
}
