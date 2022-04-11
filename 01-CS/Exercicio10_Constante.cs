using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CS
{
    class Exercicio10_Constante
    {
        static void NotMainx(string[] args)
        {
            int resultado = Calcula(5, 3, Operacao.Soma);
        }
        
        enum Operacao { Soma, Subtracao, Multiplicacao, Divisao }

        static int Calcula(int operando1, int operando2, Operacao operacao)
        {
            switch (operacao)
            {
                case Operacao.Soma:
                    return operando1 + operando2;
                    break;
                case Operacao.Subtracao:
                    return operando1 + operando2;
                    break;
                case Operacao.Multiplicacao:
                    return operando1 * operando2;
                    break;
                case Operacao.Divisao:
                    return operando1 / operando2;
                    break;
                default:
                    //obrigatorio
                    return 0;
                    break;
            }

        }
        //const float PI = 3.1415F;

        //float raio = 4.2F;
        //float area = PI * (raio * raio);
        //Console.WriteLine("Valor da Area: " + area);
        //Console.ReadKey();

    }

}
