using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CS
{
    class DesafioAula01
    {
        static void NotMaxin(string[] args)
        {

            double IMC, altura, peso;

            Console.WriteLine("Insira a sua altura: ");
            altura = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o seu peso: ");
            peso = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            IMC = peso / (Math.Sqrt(altura));

            Console.WriteLine("O seu IMC : " + IMC.ToString("F2", CultureInfo.InvariantCulture));


            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
