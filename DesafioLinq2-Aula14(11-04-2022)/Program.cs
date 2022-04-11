
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Exercício 1:
//-Criar uma classe chama Cliente com os seguintes atributos, Nome e Salário
//- Instanciar uma lista de clientes List<Cliente> e popular a lista com vários clientes new Cliente() { XXX }
//- Exibir os clientes 3 clientes com maior salário ordenados por nome


//Exercício 2:
//-Criar 2 arrays ex:
//  int[] conjunto1 = new int[] { 10, 20, 30, 40, 50, 10 };
//int[] conjunto2 = new int[] { 10, 15, 20, 25, 30 };
//Pesquisar e utilizar os métodos Except, Intersect e Union
//Obs: Em ambos os exercícios fica livre o uso da sintaxe por método e sintaxe por consulta.
namespace DesafioLinq2
{
    public class Cliente
    {
        public string NomeCliente { get; set; }
        public decimal SalarioCliente { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 01: " );
            Console.WriteLine();

            var c = new List<Cliente>();

            c.Add
            (new Cliente 
            {
                NomeCliente = "Carlos" ,
                SalarioCliente = 1560
            });

            c.Add
            (new Cliente
            {
                NomeCliente = "Eduardo",
                SalarioCliente = 6000
            });

            c.Add
            (new Cliente
            {
                NomeCliente = "Ana",
                SalarioCliente = 4500
            });

            c.Add
            (new Cliente
            {
                NomeCliente = "Luiza",
                SalarioCliente = 6200
            });

            c.Add
            (new Cliente
            {
                NomeCliente = "Pedro",
                SalarioCliente = 15000
            });

            c.Add
            (new Cliente
            {
                NomeCliente = "Beatriz",
                SalarioCliente = 3000
            });

            var OrdenaNomes = c.OrderByDescending(x => x.SalarioCliente).Take(3).OrderBy(n => n.NomeCliente);

            foreach (var cliente in OrdenaNomes)
            {
                Console.WriteLine($"Cliente :  {cliente.NomeCliente} => Salario : {cliente.SalarioCliente}");
            }




            Console.WriteLine("");
            Console.WriteLine("Exercicio 02 ");

            Console.WriteLine("");

            int[] v1 = new int[] { 1, 2, 3, 4, 5, 9 };
            int[] v2 = new int[] { 5, 3, 7, 9, 8 };

            Console.Write("Array 1: ");
            foreach (var array in v1)
            {
                Console.Write(array);
            }

            Console.WriteLine("");

            Console.Write("Array 2: ");
            foreach (var array2 in v2)
            {
                Console.Write(array2);
            }


            Console.WriteLine(" \r\n");
            Console.WriteLine("");

            
            Console.WriteLine("Except");
            var except = from conjunto in v1.Except(v2)
                         select conjunto;

            foreach (var i in except)
            {
                Console.WriteLine($"Valor =>  {i}");

            }
            Console.WriteLine("");

            Console.WriteLine("Intersect");
            Console.WriteLine("");


            var intersect = from conjunto in v1.Intersect(v2)
                            select conjunto;

            foreach (var item in intersect)
            {
                Console.WriteLine($"Valor =>  {item}");
            }
            Console.WriteLine("");
          
            Console.WriteLine("Union");
            var union = from conjunto in v1.Union(v2)
                        select conjunto;

            foreach (var item in union)
            {
                Console.WriteLine("Valor => " + item);
            }


            Console.ReadKey();

        }
    }
}
