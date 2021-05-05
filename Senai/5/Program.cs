using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {

            bool respostaerrada = false;

            do
            {
            Console.WriteLine("Qual a sua nota? entre 0 a 10?");
            int resposta = int.Parse(Console.ReadLine());

            if (resposta >= 0 && resposta <= 10)
            {
                Console.WriteLine("Sua nota e reconhecida, Obrigado!!!");
                respostaerrada = true;
            }
            else
            {
                Console.WriteLine("Sua nota não e reconhecida, tente novamente!!");
            }

            } while (respostaerrada == false);
            
        }
    }
}
