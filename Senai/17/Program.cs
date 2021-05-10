using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
           int quantidade = 15;

            float[] lista = null;
            Console.WriteLine("Passe 15 Numeros");

            lista = new float[quantidade];

            for (var i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Qual e o {i} valor ?");
                lista[i] = float.Parse(Console.ReadLine());
            }

            Array.Reverse(lista);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
