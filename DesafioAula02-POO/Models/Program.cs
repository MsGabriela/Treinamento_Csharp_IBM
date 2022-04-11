using DesafioAula02_POO.Models;
using System;
using System.Globalization;
//Saldo tratar os eventos sacar, depositar, traferir (Verificar o saldo antes);
//Permitir Agendamento de transacoes(Tranferencia, deposito)
//Tratar o caso do cliente especial (Se cliente especial limite = LIMITE_PADRAO ou maior <Limite = especial ? LIMITE_PADRAO : 0>)

namespace DesafioAula02_POO
{
    class Program 
    {
        static void Main(string[] args)

        {
            Banco b = new Banco();
            int op = 0;
            double valorSaque;
            double valorTransferir;
            double valorDeposito;
            char opAgendamento = ' ';
           
            DateTime agendamento;

            Console.WriteLine("Insira o valor do Saldo da conta: ");
            b.Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Escolha a opcao que deseja: (1) - Sacar, (2) - Transferir , (3) - Depositar, (4) - Agendamento" );
            op = int.Parse(Console.ReadLine());


            if (op == 1)
            {
                Console.WriteLine("Insira o valor do Saque: ");
                valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Eh cliente especial: (S)im ou (N)ao");
                b.Especial = char.Parse(Console.ReadLine());

                Console.WriteLine("O saldo final: " + b.Sacar(valorSaque).ToString("F2", CultureInfo.InvariantCulture));

            }
            else if(op == 2)
            {
                Console.WriteLine("Insira o valor da transferencia:  ");
                valorTransferir = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                Console.WriteLine("O valor transferido: " + b.Transferir(valorTransferir).ToString("F2", CultureInfo.InvariantCulture)); 
            }
            else if(op == 3)
            {
                Console.WriteLine("Insira o valor do deposito:  ");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                Console.WriteLine("O valor depositado: " + b.Deposito(valorDeposito).ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (op == 4)
            {
                Console.WriteLine("Deseja fazer o agendamento: ");
                opAgendamento = char.Parse(Console.ReadLine());

                if(opAgendamento == 'S' || opAgendamento == 's')
                {
                    Console.WriteLine("Insira a data que deseja agendar: ");
                    agendamento = DateTime.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o valor do deposito:  ");
                    valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                    Console.WriteLine(b.DataAgendamento(agendamento, valorDeposito));
                }
                else if(opAgendamento == 'N' || opAgendamento == 'n')
                {
                    Console.WriteLine("Agendamento Invalido!");
                }

            }
            else
            {
                Console.WriteLine("Opcao invalida");
            }

            
            

            Console.ReadKey();
            
        }
    }
}
