using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CS
{
    class Exercicio13_Structs
    {
       static void MMain(string[] args)
        {
            Curso curso;

            curso.nome = "C# Fundamentos";
            curso.valor = 123.45f;
            curso.instrutor = "Andre Camillo";
            curso.matricula = 15;

            //Console.WriteLine("O curso " + curso.nome + " possui valor de " + curso.valor);

            Console.WriteLine(curso);
        }
    }

    public struct Curso
    {
        public string nome;
        public float valor;
        public string instrutor;
        public int matricula;


        public override string ToString()
        {
            return "O curso " + nome + " possui o valor " + valor;
        }
    }
}
