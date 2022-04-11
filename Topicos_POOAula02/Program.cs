using System;
using Topicos_POOAula02.Models;

namespace Topicos_POOAula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            //p.Nome = "Joao";

            //p.Nascimento = new DateTime(2000, 01, 01);


            Conta01 conta = new Conta01("Joao Silva",1000000000);
            
            //conta.NomeTitular = "Joao";


            Console.WriteLine( conta.NomeTitular + " " + conta.Saldo);

            Console.ReadKey();
        }
    }
}
