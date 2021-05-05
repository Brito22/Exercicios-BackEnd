using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {

            bool senhaerrada = false;

            do
            {
            Console.WriteLine("Qual o nome de usuario?");
            string usuario = Console.ReadLine().ToLower();

            Console.WriteLine("Qual a sua senha?");
            string senha = Console.ReadLine().ToLower();

            if (usuario != senha)
            {
                Console.WriteLine("Cadastrado com sucesso");
                senhaerrada = true;
            }
            else
            {
                Console.WriteLine("Voce usou mesmo nome de usuario para senha, tente novamente!!!");
            }

            } while (senhaerrada == false);
        }
    }
}
