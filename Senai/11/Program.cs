using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            bool anonacismento = true;
            int data = DateTime.Now.Year;
            int ano;
            int contaidade;

            do
            {
            Console.WriteLine("Em que ano você nasceu?");
            ano = int.Parse(Console.ReadLine());

            if (ano != 0)
            {
                anonacismento = true;
            }
            else if (ano <= 1870)
            {
                Console.WriteLine("Muito velho, Por favor Tente Novamente!!!");
                anonacismento = false;
            }
            else if (ano >= data)
            {
                Console.WriteLine("Muito Novo, Por favor Tente Novamente!!!");
                anonacismento = false;
            }
            } while (anonacismento == false);

            int conta = data - ano;

            Console.WriteLine("Você ja fez aniversario esse ano? sim/nao");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "nao")
            {
                int diminuido = conta - 1;
                if (conta >= 18)
            {
                Console.WriteLine($"Obrigado, voce tem {diminuido} anos!!!");
                Console.WriteLine("Sua idade permite Votar este ano, otimo votação!!!!!!");
            }
            else if (conta >= 16 )
            {
                Console.WriteLine($"Obrigado, voce tem {diminuido} anos!!!");
                Console.WriteLine("Sua idade permite Votar,mas não e obrigatorio, fica a sua escolha!!!!!!");
            }
            else {
                Console.WriteLine($"Obrigado, voce tem {diminuido} anos!!!");
                contaidade = 18 - conta;
                Console.WriteLine($"Você ainda nao tem idade para votar, espere mais {contaidade} anos!!!");
            }
            }
            else
            {
            if (conta >= 18)
            {
                Console.WriteLine($"Obrigado, voce tem {conta} anos!!!");
                Console.WriteLine("Sua idade permite Votar este ano, otimo votação!!!!!!");
            }
            else if (conta >= 16 )
            {
                Console.WriteLine($"Obrigado, voce tem {conta} anos!!!");
                Console.WriteLine("Sua idade permite Votar,mas não e obrigatorio, fica a sua escolha!!!!!!");
            }
            else {
                Console.WriteLine($"Obrigado, voce tem {conta} anos!!!");
                contaidade = 18 - conta;
                Console.WriteLine($"Você ainda nao tem idade para votar, espere mais {contaidade} anos!!!");
            }
            }

        }
    }
}
