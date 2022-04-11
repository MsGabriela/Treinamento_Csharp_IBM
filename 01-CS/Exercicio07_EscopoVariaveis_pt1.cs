using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio07_EscopoVariaveis_pt1

    {
        static void NotXMain(String[] args)
        {

            float salario = 2000f;

            
            if (salario > 100)
            {    //Calculando reajuste de 10%
                float reajuste = salario * 0.1f;

                salario += reajuste;

                Console.WriteLine("Valor do reajuste: " + reajuste);
                Console.WriteLine("Novo salario: " + salario);
            }

            Console.WriteLine("Aplicado reajuste de: ");
            Console.ReadKey();
        }
    }
}
