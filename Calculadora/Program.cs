using DesafioPOO.Models;
using System;
using System.Globalization;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();
            int op ;

            Console.WriteLine("------------------ CALCULADORA -------------------");

            Console.WriteLine("Selecione a operação e pressione ENTER");
            Console.WriteLine("(1) - Soma");
            Console.WriteLine("(2) - Subtração");
            Console.WriteLine("(3) - Divisão");
            Console.WriteLine("(4) - Multiplicação");
            Console.WriteLine("(5) - Sair");

            op = int.Parse(Console.ReadLine());
           



            while (op != 5)
            {
               
                
                if (op == 1)
                {
                    Console.WriteLine("Digite o primeiro valor e pressione ENTER ");
                    c.Numero1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Digite o segundo valor e pressione ENTER ");
                    c.Numero2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    
                    Console.WriteLine("----------- RESULTADO ------------");

                    Console.WriteLine(c.Somar().ToString("F2", CultureInfo.InvariantCulture));


                }
                else if (op == 2)
                {
                    Console.WriteLine("Digite o primeiro valor e pressione ENTER ");
                    c.Numero1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Digite o segundo valor e pressione ENTER ");
                    c.Numero2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("----------- RESULTADO ------------");

                    Console.WriteLine(c.Subtrair().ToString("F2", CultureInfo.InvariantCulture));
                }
                else if (op == 3)
                {
                    Console.WriteLine("Digite o primeiro valor e pressione ENTER ");
                    c.Numero1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Digite o segundo valor e pressione ENTER ");
                    c.Numero2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("----------- RESULTADO ------------");

                    Console.WriteLine(c.Dividir().ToString("F2", CultureInfo.InvariantCulture));
                }
                else if (op == 4)
                {
                    Console.WriteLine("Digite o primeiro valor e pressione ENTER ");
                    c.Numero1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Digite o segundo valor e pressione ENTER ");
                    c.Numero2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("----------- RESULTADO ------------");

                    Console.WriteLine(c.Multiplicar().ToString("F2", CultureInfo.InvariantCulture));
                }
              
                if (op > 5 && op < 0)
                {
                    Console.WriteLine("Operação Invalida!");
                }
                Console.WriteLine();

                Console.WriteLine("Selecione a operação e pressione ENTER");
                Console.WriteLine("(1) - Soma");
                Console.WriteLine("(2) - Subtração");
                Console.WriteLine("(3) - Divisão");
                Console.WriteLine("(4) - Multiplicação");
                Console.WriteLine("(5) - Sair");

                op = int.Parse(Console.ReadLine());

              
            }
            Console.WriteLine("Deseja sair? Pressione enter");
           


            Console.ReadKey();
           
        }
    }
}
