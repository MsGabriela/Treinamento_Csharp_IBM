using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio03_Precedencia_Operadores
    {
        static void xMain(String[] args)
        {
            //Var = eh uma variavel com tipo implicito, e eh definido o tipo da variavel que for passado atraves dos dados inseridos
            //var num1 = 4 + 2 * 3;

            //var num2 = (4 + 2) * 3;

            //Console.WriteLine(num1);
            //Console.WriteLine(num2);

            //var idade = 35;
            //Console.WriteLine(idade++);
            //Console.WriteLine(idade);

            var idade = 35;
            Console.WriteLine(++idade);

            Console.ReadKey();
        }
    }
}
