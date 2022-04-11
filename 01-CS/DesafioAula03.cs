using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CS
{
    class DesafioAula03
    {
        static void NoxxxtMain(string[] args)
        {
            double IMC, alt, p;

            Console.WriteLine("Insira a sua altura: ");
            alt = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o seu peso: ");
            p = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            IMC = p / (Math.Pow(alt, 2));


            switch (IMC)
            {
                case var _ when IMC <= 18.5:
                    Console.WriteLine("Baixo peso");
                    break;
                case var _ when IMC >= 18.6 && IMC < 24.9:
                    Console.WriteLine("Peso normal");
                    break;
                case var _ when IMC >= 25 && IMC < 29.9:
                    Console.WriteLine("Sobrepeso");
                    break;
                case var _ when IMC >= 30 && IMC < 34.9:
                    Console.WriteLine("Obesidade grau I");
                    break;
                case var _ when IMC >= 35 && IMC < 39.9:
                    Console.WriteLine("Obesidade grau II");
                        break;
                case var _ when IMC >= 40:
                    Console.WriteLine("Obesidade grau III");
                    break;
                default:
                    Console.WriteLine("Valor inserido invalido.");
                    break;
            }

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
