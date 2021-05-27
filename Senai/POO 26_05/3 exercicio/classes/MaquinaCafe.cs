using System;

namespace _3_exercicio.classes
{
    public class MaquinaCafe
    {
        public int AcucarDisponivel = 50;

        public void FazerCafe(int ComAcucar)
        {
            if (AcucarDisponivel <= 0)
            {
                Console.WriteLine("A maquina Não tem Açucar!!!");
            }
            else
            {
            Console.WriteLine("Maquina Tem Açucar, Fazendo Café");
            Console.WriteLine("Cafe Pronto!!!");
            }
        }
        public void FazerCafe(string SemAcucar)
        {
            Console.WriteLine("Ok Fazendo Cafe sem açucar");
            Console.WriteLine("Cafe Pronto!!!");
        }
    }
}