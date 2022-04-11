using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CS
{
    class Exercicio16_Arrays

    {
        
       static void xMain(string[] args)
        {

            int [] idades = new int[3];

            idades[0] = 10;
            idades[1] = 20;
            idades[2] = 30;

            int totalIdades = idades[0] + idades[1] + idades[2];

            Console.WriteLine(totalIdades);

            string[] nomes = new string[] { "Joao", "Maria" , "Jose"};

            Console.WriteLine("Total de elementos no array: " + nomes.Length);

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Elementos: " + nomes[i]);
            }

            foreach (var item in nomes)
            {
                Console.WriteLine("Elemento: " + item);
            }

            string[] nomes2 = new string[nomes.Length];

            Array.Copy(nomes, nomes2, 2);

            foreach (var item in nomes2)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }

   
}
