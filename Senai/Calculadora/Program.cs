using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            bool nomesim = false;
            bool nomevazio = false;
            bool numerovazio = false;
            string nome = "";

            do
            {
                Console.WriteLine("\nBem vindo a TermCalculadora!!!, Qual o seu nome?");
                nome = Console.ReadLine();

                if (nome != "")
                {
                    nomevazio = true;
                }
                else
                {
                    Console.WriteLine("\nNome vazio, por favor, insira seu nome!!!");
                }

            } while (nomevazio == false);

            do
            {
                Console.WriteLine($"\nTudo bem {nome}, Quantos Numero voce deseja calcular?");
                string quantidade = Console.ReadLine();

                if (quantidade != "")
                {
                    numerovazio = true;
                }
                else if (quantidade == "0")
                {
                    Console.WriteLine("SEM NUMERO, SEM CONTA, TENTE NOVAMENTE USUARIO!!!");
                }
                else 
                {
                    Console.WriteLine("Valor vazio, por favor, insira um valor!!!");
                }

            } while (numerovazio == false);

            do
            {
                Console.WriteLine("\nQual operação deseja ser feita? \n1 - Somar \n2 - Subtrair \n3 - Multiplicar \n4 - Dividir \n5 - Potencia \n6 - Raiz Quadrada\n");
                int operacao = int.Parse(Console.ReadLine());

                if (operacao >= 1 && operacao <= 4)
                {
                    Console.WriteLine("\nQual e o Primeiro Numero?");
                    n1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nQual e o Segundo Valor");
                    n2 = double.Parse(Console.ReadLine());
                }
                else if (operacao == 5)
                {
                    Console.WriteLine("\nQual e o Primeiro Numero?");
                    n1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("\nQual o valor da potencia?");
                    n2 = double.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("\nQual e o Primeiro Numero?");
                    n1 = double.Parse(Console.ReadLine());

                    n2 = 0;
                }

                switch (operacao)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Green;
                        double valorsomar = Somar(n1, n2);
                        Console.WriteLine($"\nO Resultado foi = {valorsomar}");
                        break;

                    case 2:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Green;
                        double valordiminuir = Diminuir(n1, n2);
                        Console.WriteLine($"\nO Resultado foi = {valordiminuir}");
                        break;

                    case 3:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Green;
                        double valormultiplicar = Multiplicar(n1, n2);
                        Console.WriteLine($"\nO Resultado foi = {valormultiplicar}");
                        break;

                    case 4:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Green;
                        double valordividir = Dividir(n1, n2);
                        Console.WriteLine($"\nO Resultado foi = {valordividir}");
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Green;
                        double potencia = Potencia(n1, n2);
                        Console.WriteLine($"\nO Resultado foi = {potencia}");
                        break;

                    case 6:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Green;
                        double raizquadrada = RaizQuadrada(n1);
                        Console.WriteLine($"\nO Resultado foi = {raizquadrada}");
                        break;


                    default:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nValor Invalido, tente novamente!!!");
                        break;
                }

                Console.WriteLine($"\n{nome} Deseja fazer outra Conta? \n1 - sim \n2 - nao");
                Console.ResetColor();
                string continuar = Console.ReadLine().ToLower();

                if (continuar == "2")
                {
                    nomesim = true;
                }
                else if (continuar == "1")
                {
                    Console.WriteLine($"Ok {nome}");
                }
                else
                {
                    Console.WriteLine("\nValor Invalido, tente novamente!!!");
                }

            } while (nomesim == false);
            Console.WriteLine($"\nOk, Volte sempre {nome}!!!");
        }

        static double Somar(double primeironumero, double segundonumero)
        {

            return primeironumero + segundonumero;
        }

        static double Diminuir(double primeironumero, double segundonumero)
        {
            return primeironumero - segundonumero;
        }

        static double Multiplicar(double primeironumero, double segundonumero)
        {
            return primeironumero * segundonumero;
        }

        static double Dividir(double primeironumero, double segundonumero)
        {
            return primeironumero / segundonumero;
        }
        static double Potencia(double primeironumero, double segundonumero)
        {
            return (Math.Pow(primeironumero, segundonumero));
        }
        static double RaizQuadrada(double primeironumero)
        {
            return (Math.Sqrt(primeironumero));
        }
       // static double formula(double quantidade)
        //{
           //double[] n3 = null;

            //Console.WriteLine("$Tudo bem nome, Quantos Numero voce deseja calcular?");
            //int quantidadecontas = int.Parse(Console.ReadLine());

            //n3 = new double[quantidadecontas];

            //for (var i = 0; i < quantidadecontas; i++)
            //{
                //Console.WriteLine($"Qual e o {quantidade} numero ?");
                //n3[i] = Double.Parse(Console.ReadLine());
            //}
        //}
    }
}