using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CS
{
    class Strings
    {
        static void xxNotMain(string[] args)
        {
            string frase = " Hoje eh um belo dia para estudar C#";
            int tamanhoFrase = frase.Length;

            //Console.WriteLine(string.Format("Tamanho da frase: {0} caracteres, frase.Length"));


            //Console.WriteLine(frase.Trim() + "///");

            string novaFrase = frase.Replace("dia", "ano");
            Console.WriteLine(novaFrase);

            Console.WriteLine(frase.Contains("#"));

            Console.WriteLine(novaFrase.Equals( frase));

            string fraseNova = frase.TrimStart(); //da espaco no inicio

            Console.WriteLine(frase.IndexOf("eh"));

           // Console.WriteLine(frase.ToUpper().ToUpper.Trim().Equals("HOJE.."));

            Console.WriteLine(frase.Insert(5, "------"));
            Console.ReadKey();
        }
    }
}
