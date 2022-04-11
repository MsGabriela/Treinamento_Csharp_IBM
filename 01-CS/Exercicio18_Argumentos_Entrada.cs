using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CS
{
    class Exercicio18_Argumentos_Entrada

    {
        
       static void nMain(string[] args)
        {

            if(args.Length< 2)
            {
                Console.WriteLine("Este programa necessita de 2 argumentos de entrada");
            }
            else
            {
                int n1 = int.Parse(args[0]);
                int n2 = Convert.ToInt32(args[1]);

                Console.WriteLine("Resultado da soma: " + (n1+n2));
            }

        
        }
    }

   
}
