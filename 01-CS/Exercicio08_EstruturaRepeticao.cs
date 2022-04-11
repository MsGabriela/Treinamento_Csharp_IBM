using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio08_EstruturaRepeticao

    {
        static void xNotMain(String[] args)
        {
            int tabuada = 5;
            
            //int i = 0;

            //while (i <= 10)
            //{

            //    Console.WriteLine(tabuada + " x " + i + " = " + tabuada * i);
            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine(tabuada + " x " + i + " = " + tabuada * i);
            //    i++;
            //} while (i <= 10);


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(tabuada + " x " + i + " = " + tabuada * i);
                if (i == 6)
                    break;
            }
            Console.ReadKey();
        }
    }
}
