using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio04_OperadoresRelacionais

    {
        static void xMain(String[] args)
        {
            //Console.WriteLine("12 eh igual a 12? " + (12 == 12));
            //Console.WriteLine("12 eh diferente a 12? " + (12 != 12));
            //Console.WriteLine("15 eh maior que  15? " + (15 > 15));
            //Console.WriteLine("15 eh menor que  15? " + (15 < 15));
            //Console.WriteLine("15 eh maior ou igual a  15? " + (15 >= 15));
            //Console.WriteLine("15 eh menor ou igual a  15? " + (15 <= 15));


            bool flag = true;

            Console.WriteLine("Isto eh verdadeiro: " + flag);

            flag = !flag;

            Console.WriteLine("Isto eh falso: " + flag);
            Console.ReadKey();
        }
    }
}
