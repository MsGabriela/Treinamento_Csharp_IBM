using Aula09_POO.Models;
using System;


namespace Aula09_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            c.Numero = 1;
            c.Saldo = 500;

            Console.WriteLine("O saldo da conta: " + c.Saldo);

           // c.Saque(200);
           

            try
            {
                //c.Saque(300,1); // usando sobrecarga
                c.Saque(100);
                Console.WriteLine(c.Mensagem);
                Console.WriteLine("O saldo da conta: " + c.Saldo);

            }
            catch(SaldoInsuficienteException e)
            {
                Console.WriteLine("Saldo insuficiente!" );
            }
            catch (ArgumentException e)
            {

                Console.WriteLine("Nao foi possivel sacar valor negativo." + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("O saldo da conta: " + c.Saldo);
            Console.ReadKey();
        }
    }
}
