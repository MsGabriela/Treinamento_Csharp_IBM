using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CS
{
    class Exercicio17_OperacoesArrays

    {
        
       static void notMain(string[] args)
        {

            string[] nomes = { "Paulo", "Roberto", "Maria", "Silvia", "Antonio", "Fernanda" };

            Array.Sort(nomes);
            ImprimeArray(nomes);

            Array.Reverse(nomes);
            Console.ReadKey();

            Array.Resize(ref nomes, 10);

            Array.Clear(nomes, 1, 2);

            var existeMaria = Array.Exists(nomes, n => n.Equals("Maria"));

            Console.WriteLine("Maria esta no Array? "  + existeMaria);


            string[] nomeQueComecamComR = Array.FindAll(nomes, n => n.StartsWith("R"));

            int posicaoAntonioArray = Array.IndexOf(nomes, "Antonio");

            Console.WriteLine("Posicao do Antonio do Array: " + posicaoAntonioArray);
        }

        static void ImprimeArray(string [] array)
        {
            Console.WriteLine("------------------");

            int i = 0;

            foreach (var item in array )
            {
                Console.WriteLine(string.Format("{0} => {1}", item, i));
                i++;
            }
            Console.WriteLine("------------------");
            Console.WriteLine("");
        }
    }

   
}
