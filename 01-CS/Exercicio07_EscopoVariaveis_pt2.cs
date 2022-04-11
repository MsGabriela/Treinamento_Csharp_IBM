using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Exercicio07_EscopoVariaveis_pt2

    {
        static void NoxtMain(String[] args)
        {
            float NovoSalarioReajustado10PorCento(float salario)
            {
                float reajuste = 10f;
                float novoSalario = salario + (salario / 100 * reajuste);
                return novoSalario;
            }

            float meuSalario = 2000;

            Console.WriteLine("Meu ");

            Console.ReadKey();
        }
    }
}
