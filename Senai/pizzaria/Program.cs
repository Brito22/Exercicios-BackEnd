using System;

namespace pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo a Pizzaria!!!");
            Console.WriteLine("Deseja Fazer Login/Cadastrar?  \n1 - Login  \n2 - Cadastro  \n3 - Não");
            int resposta = int.Parse(Console.ReadLine());

            if (resposta == 1)
            {
                Console.WriteLine("Qual o usuario?");
                string usuario = Console.ReadLine();

                Console.WriteLine("Qual a senha?");
                string senha = Console.ReadLine();
            }
            else if (resposta == 2)
            {
                Console.WriteLine("Cadastrar usuario?");
                string usuario = Console.ReadLine();

                Console.WriteLine("Cadastrar senha?");
                string senha = Console.ReadLine();

                Console.WriteLine("Em que ano voce nasceu?");
                int data = int.Parse(Console.ReadLine());
            }
            else if (resposta == 3)
            {
                Console.WriteLine("Ok Vamos Continuar!!");
            }
            else
            {
                Console.WriteLine("Valor Não corresponde, Pfv Tente Novamente");
            }

            Console.WriteLine("Então " + "usuario" + "o que deseja hoje? \n1 - Pizzas Salgadas  \n2 - Pizzas Doces  \n3 - Esfihas");
            int comida = int.Parse(Console.ReadLine());

            if (comida == 1)
            {
                Console.WriteLine("Voce Escolheu Pizzas Salgadas \n1 - Pizza de Calabresa  \n2 - Pizza de Mussarela  \n3 - Metade Calabresa/Metade Mussarela");
                int tipo = int.Parse(Console.ReadLine());

                if (tipo == 1)
                {
                    Console.WriteLine("Voce Escolheu a pizza de calabresa - o preço da pizza e de R$25, Deseja Continuar ? \n1 - Sim  \n2 - Não");
                    int confirmar = int.Parse(Console.ReadLine());

                    if (confirmar == 1)
                    {
                        Console.WriteLine("Informe o local para a entrega");
                        string local = Console.ReadLine();
                    }
                }

                if (tipo == 2)
                {
                    Console.WriteLine("Voce Escolheu a pizza de Mussarela - o preço da pizza e de R$25, Deseja Continuar ? \n1 - Sim  \n2 - Não");
                    int confirmar = int.Parse(Console.ReadLine());

                    if (confirmar == 1)
                    {
                        Console.WriteLine("Informe o local para a entrega");
                        string local = Console.ReadLine();
                    }
                }

                if (tipo == 3)
                {
                    Console.WriteLine("Voce Escolheu a pizza de metade calabresa/ metade mussarela - o preço da pizza e de R$25, Deseja Continuar ? \n1 - Sim  \n2 - Não");
                    int confirmar = int.Parse(Console.ReadLine());

                    if (confirmar == 1)
                    {
                        Console.WriteLine("Informe o local para a entrega");
                        string local = Console.ReadLine();
                    }
                }


            else if (comida == 2)
                {
                    Console.WriteLine("Voce Escolheu Pizzas Doces \n1 - Pizza de Brigadeiro  \n2 - Pizza de Banana  \n3 - Pizza de Limão");

                    if (tipo == 1)
                {
                    Console.WriteLine("Voce Escolheu a pizza de Brigadeiro - o preço da pizza e de R$35, Deseja Continuar ? \n1 - Sim  \n2 - Não");
                    int confirmar = int.Parse(Console.ReadLine());

                    if (confirmar == 1)
                    {
                        Console.WriteLine("Informe o local para a entrega");
                        string local = Console.ReadLine();
                    }
                }

                if (tipo == 2)
                {
                    Console.WriteLine("Voce Escolheu a pizza de Banana - o preço da pizza e de R$35, Deseja Continuar ? \n1 - Sim  \n2 - Não");
                    int confirmar = int.Parse(Console.ReadLine());

                    if (confirmar == 1)
                    {
                        Console.WriteLine("Informe o local para a entrega");
                        string local = Console.ReadLine();
                    }
                }

                if (tipo == 3)
                {
                    Console.WriteLine("Voce Escolheu a pizza de Limão - o preço da pizza e de R$35, Deseja Continuar ? \n1 - Sim  \n2 - Não");
                    int confirmar = int.Parse(Console.ReadLine());

                    if (confirmar == 1)
                    {
                        Console.WriteLine("Informe o local para a entrega");
                        string local = Console.ReadLine();
                    }
                }


                else if (comida == 3)
                {
                    Console.WriteLine("Voce Escolheu Esfihas");
                }


                else
                {
                    Console.WriteLine("Valor Não corresponde, Pfv Tente Novamente");
                }
            }
        }
    }
}
}