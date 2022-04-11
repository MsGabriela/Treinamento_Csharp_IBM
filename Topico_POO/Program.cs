using System;
using Topico_POO.Models;

namespace Topico_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa1 p = new Pessoa1();

            p.nome = "Joao";
            p.sobrenome = "Silva";
            p.idade = 15;

           //p = null;

            Pessoa1 p2 = new Pessoa1();

            p2.nome = p.nome;

            Console.WriteLine(p.getNomeCompleto());
            Console.ReadKey();

        }
    }
}
