using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CS
{
    class DesafioAula02
    {
        static void NxotMain(string[] args)
        {
            double IMC, alt, p;

            Console.WriteLine("Insira a sua altura: ");
            alt = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o seu peso: ");
            p = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            IMC = p / (Math.Pow(alt, 2));

            //Console.WriteLine("O seu IMC : " + IMC.ToString("F2", CultureInfo.InvariantCulture));

            if (IMC < 18.5)
            {
                Console.WriteLine("Baixo peso");
            } else if (IMC > 18.6 && IMC < 24.9)
            {
                Console.WriteLine("Peso normal");
            } else if (IMC > 25 && IMC < 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (IMC > 30 && IMC < 34.9)
            {
                Console.WriteLine("Obesidade grau I");
            }else if(IMC > 35 && IMC < 39.9)
            {
                Console.WriteLine("Obesidade grau II");
            }
            else
            {
                Console.WriteLine("Obesidade grau III");
            }
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
