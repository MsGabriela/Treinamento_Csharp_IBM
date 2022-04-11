using System;
using DesafioAula04_POO.Models;
using System.Globalization;

/* Atividade da Aula
Classes
Funcionario
Vendedor : Funcionario
Administrativo : Funcionario
Temos uma classe funcionario e uma classe Vendedor
esta classe deve ter o seguinte construtor > public Funcionario(string cargo, decimal salario)
getSalario retorna o salario do funcionario 
mas se For vendedor salario + comissao 10% 
*/

namespace DesafioAula04_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            Vendedor v = new Vendedor();

            char op;

            Console.WriteLine("Voce eh (V)endedor ou (F)uncionario : Insira (V) ou (F)");
            op = Char.Parse(Console.ReadLine());

            



            
                if (op == 'V' || op == 'v')
                {
                    Console.WriteLine("Insira o nome do seu cargo: ");
                    v.Cargo = Console.ReadLine();

                    Console.WriteLine("Insira o salario do funcionario: R$");
                    v.Salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("O salario do Vendedor: " + v.GetSalario().ToString("F2", CultureInfo.InvariantCulture));

                }
                else if (op == 'F' || op == 'f') 
                {
                    Console.WriteLine("Insira o nome do seu cargo: ");
                    f.Cargo = Console.ReadLine();

                    Console.WriteLine("Insira o salario do funcionario: R$");
                    f.Salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("O salario do   " + f.Cargo + "  " + f.GetSalario().ToString("F2", CultureInfo.InvariantCulture));
                }
                 


            Console.ReadKey();


        }
    }
}
