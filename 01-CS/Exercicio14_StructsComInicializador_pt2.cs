using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CS
{
    class Exercicio14_StructsComInicializador_pt2
    {
        public struct Formacao
        {
            public string nome;
            public float valor;
            public string instrutor;
            public int matriculas;


           public Formacao(string pNome, float pValor, string pInstrutor)
            {
                nome = pNome;
                valor = pValor;
                instrutor = pInstrutor;
                matriculas = 0;
            }
            //structs nao pode ter construtores padroes e sem parametros
        }
       static void NotMain(string[] args)
        {
            Formacao f = new Formacao("C# Fundamentos", 123.45f, "Andre Camillo");
            Console.WriteLine(f.nome);
        }
    }

   
}
