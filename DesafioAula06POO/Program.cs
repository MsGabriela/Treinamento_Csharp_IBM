using DesafioAula06_POO.Models;
using DesafioAula06POO.Models;
using System;
using System.Globalization;

namespace DesafioAula06POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo();
            Quadrado q = new Quadrado();
            Circulo c = new Circulo();

            Console.WriteLine("Insira o valor da altura do Triangulo: ");
            t.x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o valor da base do Triangulo: ");
            t.y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("A area do Triangulo: " + t.GetArea().ToString("F2", CultureInfo.InvariantCulture));


            Console.WriteLine("Insira o valor dos lados de um Quadrado: ");
            q.x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("A area do quadrado: " + q.GetArea().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Insira o valor do Raio do Circulo: ");
            c.x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("A area do Circulo: " + c.GetArea().ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
