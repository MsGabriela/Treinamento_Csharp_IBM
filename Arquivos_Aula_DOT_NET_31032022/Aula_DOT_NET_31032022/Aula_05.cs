using Topico_POO.Modelos;
using System;

/*
 * Referências:
 * https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/polymorphism
 */

namespace Topico_POO
{
    class Aula05
    {
        static void Main(string[] args)
        {
            var paulo_executivo = new Executivo("111.111.111-11", "Paulo", 20000f, 15);
            var daniel_instrutor = new Instrutor("222.222.222-22", "Daniel", 17000f, "Ciência de Dados");
            var joao_consultor = new Consultor("333.333.333-33", "Joao", "Ciência de Dados");
            var jose_aluno = new Aluno("444.444.444-44", "Jose", "Python Fundamentos");
            var roberto_motorista = new Motorista("555.555.555-55", "Roberto", 8000f, "12343-42");

            //qualquer um que implemente a interface ILecionavel podera dar aula
            var aula = new Aula(".NET", "Webex do Gustavo", new DateTime(), paulo_executivo);
            Console.WriteLine(aula.GetInfo());

            var aula1 = new Aula(".NET", "Webex do Gustavo", new DateTime(), daniel_instrutor);
            Console.WriteLine(aula1.GetInfo());

            var aula2 = new Aula(".NET", "Webex do Gustavo", new DateTime(), joao_consultor);
            Console.WriteLine(aula2.GetInfo());

            //Aluno nao podera lecionar 
            //var aula3 = new Aula(".NET", "Webex do Gustavo", new DateTime(), jose_aluno);
            //Console.WriteLine(aula3.GetInfo());

            //Motorista tbm nao leciona
            //var aula4 = new Aula(".NET", "Webex do Gustavo", new DateTime(), roberto_motorista);
            //Console.WriteLine(aula4.GetInfo());


            Console.ReadKey();   
        }
    }
}
