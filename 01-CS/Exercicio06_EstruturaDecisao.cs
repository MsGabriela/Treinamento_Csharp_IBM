using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio06_EstruturaDecisao

    {
        static void NtMain(String[] args)
        {
            float salario1 = 1000.0F;
            float salario2 = 1000.1F;

            if(salario1 == salario2)
            {
                Console.WriteLine("Os salarios sao iguais!");
            }
            if(salario1 != salario2)
            {
                Console.WriteLine("Os salarios nao so iguais!");
            }
            else
                Console.WriteLine("Os salarios sao iguais!");


            if(salario1 == salario2)
                Console.WriteLine(" ");
               
            else if(salario1 > salario2)
                Console.WriteLine(" ");
            else
                Console.WriteLine(" ");


            //Condicao ? true consequencia : alternativa
           string resultado = (salario1 > salario2) ? "Salario 1 eh maior" : "Salario 1 nao eh maior";
            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
