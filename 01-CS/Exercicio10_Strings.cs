using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CS
{
    class Exercicio10_Strings
    {
        static void NotMaixn(string[] args)
        {
            string nomeCurso = "Programacao C# / .Net";
            float valorCurso = 123.456F;
            string resultado = string.Empty;

            resultado = string.Format("Valor do curso: {0}", valorCurso);
            resultado = string.Format("Valor do curso {0} e de: {1}" , nomeCurso, valorCurso);
            resultado = string.Format("Valor do curso {0} e de: {1:2}", nomeCurso, valorCurso);



            //DateTime date = "03-17-2022T00:00:00";



            Console.WriteLine(resultado);
            Console.WriteLine($"{valorCurso}");

            Console.ReadKey();
        }
    }
}
