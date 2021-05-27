using System;

namespace _1_exercicio.classes
{
    public class Elevador
    {
        public int TotalAndares = 10;
        public int AndarAtual = 0;
        public int CapacidadePessoas = 15;
        public int CapacidadeAtual = 0;
        public int CapacidadeCaixas = 15;

        public int ELEVADORSOCIAL;
        public int ELEVADORSERVIÇO;
        public string Inicializa()
        {
            return "Elevador Ligado";
        }

        public int Entrar()
        {
            for (int CapacidadeAtual = 0; CapacidadeAtual <= CapacidadePessoas; CapacidadeAtual++)
            {
              
            }
            return CapacidadeAtual++;
        }
        public int Sair()
        {
            return CapacidadeAtual--;
        }

        public int Subir()
        {
            return AndarAtual++;
        }
        public int Descer()
        {
            return AndarAtual--;
        }
    }
}