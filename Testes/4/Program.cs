using System;
namespace Trabalho5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t  Macoratti .net\n\tQuase tudo para Visual Basic\n");

            int numero;
            double soma=0;
            double x;
            Console.WriteLine("Informe o intervalor de valores a exibir para série :\n1*^x + 2*x^2 + 3*x^3 + 4*x^4 + 5*x^5 + … + n*x^n");
            numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                Console.Write(i + "*x^" + i );
                if (i < numero)	
                    Console.Write(" + ");
                x = (double)i;
                soma = soma +(i * Math.Pow(x,x));
            }
            
            Console.WriteLine("\nA soma da série é : " + soma);
            Console.ReadKey();
        }
    }
}