using System;
namespace Trabalho3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t  Macoratti .net\n\tQuase tudo para Visual Basic\n");
            char ch;
            int i = 10;
            do
            {
                Console.Write(i);
                Console.Write(" ");
                ch = (char)i;
                Console.WriteLine(ch);
                i++;
            } while (i <= 255);
            Console.ReadKey();
        }
  }
}