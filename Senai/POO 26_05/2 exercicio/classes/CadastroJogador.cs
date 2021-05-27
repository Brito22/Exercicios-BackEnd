using System;

namespace _2_exercicio.classes
{
    public class CadastroJogador
    {
        public string nome;
        public int data;
        public string nacionalidade;
        public float altura;
        public float peso;

        public string Informar()
        {
return $@"O seu nome é {nome}
A sua data de nascimento é {data}
A sua nacionalidade é {nacionalidade}
A sua altura é  {altura}
O seu peso é {peso}";
        }

        public int idade()
        {
            int idadejogador = DateTime.Now.Year - data;
            return idadejogador;
        }

        public int JOGADORDEFESA = 40;
        public int JOGADORATAQUE = 35;
        public int JOGADORMEIO_CAMPO = 38;
    }
}