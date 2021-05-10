using System;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 10;

            float[] lista = null;
            Console.WriteLine("Passe 10 Numeros");

            lista = new float[quantidade];

            for (var i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Qual e o {i} valor ?");
                lista[i] = float.Parse(Console.ReadLine());
            }

            Array.Sort(lista);

            foreach (var item in lista)
            {
                Console.WriteLine($"O maior valor foi de {lista[9]} e o menor foi de {lista[0]}");
            }
        }
    }
}
