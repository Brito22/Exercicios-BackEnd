using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool nomevazio = false;
            bool idadeerrada = false;
            bool salariozero = false;
            bool estadocivil = false;

            do
            {

            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();

            if (nome != "")
            {
                nomevazio = true;
            }
            else 
            {
                Console.WriteLine("Campo Vazio, Tente novamente!!!");
            }

            } while (nomevazio == false);

            do
            {

            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 150)
            {
                idadeerrada = true;
            }
            else 
            {
                Console.WriteLine("Idade não corresponde, Tente Novamente!!!");
            }

            } while (idadeerrada == false);

            do
            {
            Console.WriteLine("Qual seu salario?");
            decimal salario = decimal.Parse(Console.ReadLine());

            if (salario > 0)
            {
                salariozero = true;
            }
            else
            {
                Console.WriteLine("Salario Não Corresponde, Tente Novamente!!!");
            }

            } while (salariozero == false);

            do
            {
            Console.WriteLine("Qual seu Estado Civil? 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a))");
            string estado = Console.ReadLine().ToLower();

            if (estado == "s" || estado == "c" || estado == "v" || estado == "d")   
            {
                Console.WriteLine("Parabens Verificação Concluida");
                estadocivil = true;
            }
            else
            {
                Console.WriteLine("Estado civil Não corresponde, Tente Novamente");
            }
                
            } while (estadocivil == false);

        }
    }
}
