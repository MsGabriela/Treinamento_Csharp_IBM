using System;
using DesafioAula01_POO.Models;
using System.Globalization;

//Criar duas classes que representem os objetos quadrado e triangulo(Com seus metodos e atributos)
//Usuario informe os atributos
//e sera retornado o calculo da area(GetArea)
//Dica pesquisa interface
namespace DesafioAula01_POO
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Triangulo t = new Triangulo();
            Quadrado q = new Quadrado();

            Console.WriteLine("Insira o valor da altura do Triangulo: ");
            t.h = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o valor da base do Triangulo: ");
            t.b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("A area do Triangulo: " + t.GetArea().ToString("F2", CultureInfo.InvariantCulture));


            Console.WriteLine("Insira o valor dos lados de um Quadrado: ");
            q.L = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("A area do quadrado: " + q.GetArea().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
