using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio05_OperadoresLogicos

    {
        static void NMain(String[] args)
        {
            bool sol = true, vento = false, ferias = true;

            ////AND ou E
            // if(sol && vento )
            // {
            //     Console.WriteLine("Esta sol e tambem esta ventando.");
            // }
            // if (sol && !vento)
            // {
            //     Console.WriteLine("Esta sol e nao esta ventando");
            // } //OR ou OU
            // if(sol || vento)
            // {
            //     Console.WriteLine("Esta sol ou esta ventando");
            // }

            //var salario = 15000;

            //if(sol && ferias && salario >= 10000)
            //{
            //   Console.WriteLine("Vamos viajar.");
            //}
            
            //XOR ou OU Exclusivo
            if (sol ^ ferias)
            {
                Console.WriteLine("Resultado eh XOR");
            }
            else
            {
                Console.WriteLine("Resultado nao eh XOR");
            }
            
            Console.ReadKey();


        }
    }
}
