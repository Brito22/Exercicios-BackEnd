using System;

namespace Sistema_de_Produtos
{
    class Program
    {
        static int c = 0;
        static string[] nome = new string[10];
        static float[] preco = new float[nome.Length];
        static string[] promocao = new string[nome.Length];
        static string promo;
        static void Main(string[] args)
        {
            string respostamenu;
            bool verificacao = false;

            do
            {
                MostrarMenu();
                respostamenu = Console.ReadLine();

                switch (respostamenu)
                {
                    case "1":
                        CadastrarProduto();
                        break;

                    case "2":
                        ListarProdutos();
                        break;

                    case "0":
                        Console.WriteLine("Ok, Muito Obrigado!!!, Volte Sempre!!!");
                        verificacao = true;
                        break;

                    default:
                        Console.WriteLine("Valor Invalido, Tente Novamente");
                        break;
                }
            } while (verificacao == false);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Bem Vindo!!!, o que voce deseja hoje? \n1 - Cadastrar Produto \n2 - Listar Produtos \n0 - Sair");
            //string respostamenu = Console.ReadLine();
        }

        static void CadastrarProduto()
        {
            string resposta = null;

            //Console.WriteLine("Quantos Produtor Voce deseja Cadastrar?");
            //quantidade = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"Ainda Faltam {nome.Length - c} Produtos");
                Console.WriteLine($"Qual o {c + 1} produto?");
                nome[c] = Console.ReadLine();

                Console.WriteLine($"QUal o valor do {c + 1} produto?");
                preco[c] = float.Parse(Console.ReadLine());

                Console.WriteLine($"O {c + 1} Esta em promoção? (sim/não)");
                promocao[c] = Console.ReadLine().ToLower();

                c++;

                Console.WriteLine("Deseja Cadastrar outro produto? \n1 - Sim \n2 - Não");
                resposta = Console.ReadLine();

                if (resposta == "1")
                {

                }
                else
                {
                    break;
                }

            } while (c <= nome.Length);
            Console.WriteLine("Ok, Produtos Cadastrados com sucesso!!!");
        }
        static void ListarProdutos()
        {
            for (var i = 0; i < c; i++)
            {
                    Console.WriteLine($"\nVoce Cadastrou o produto {nome[i]} | no Valor de R${preco[i]} | {promocao[i]} Esta em Promoção!!!\n");
                    Console.WriteLine("Valor Não Corresponde, Nenhuma das opções");
            }
        }
    }
}
