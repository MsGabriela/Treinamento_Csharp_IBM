using DesafioAula07_POO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace DesafioAula07_POO
{
    class Program
    {
        static Banco b;
        static Conta c;
        static Contrato contrato1;
        static void Main(string[] args)
        {
            b = new Banco();
            c = new Conta();
            contrato1 = new Contrato();
            

            Console.WriteLine("------------- Cadastro de Contas -------------");

            CadastrarConta(c);

           

            Console.WriteLine("------------- Imprimindo o saldo -------------");
            ImprimirSaldo("123456");

            Console.WriteLine("------------- Cadastro de Contratos -------------");
            CadastrarContrato(contrato1);

            Console.ReadKey();
        }
        private static void CadastrarConta(Conta c)
        {
            Console.WriteLine("Insira o seu nome: ");
            c.NomeCliente = Console.ReadLine();

            Console.WriteLine("Insira o numero da Conta: ");
            c.NumeroConta = Console.ReadLine();

            Console.WriteLine("Insira o valor do Saldo da sua conta: ");
            c.Saldo = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o valor do Cheque especial: ");
            c.Especial = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            b.Contas.Add(c);


        }

        private static void ExcluirConta (string numeroConta)
        {
            var conta = from c in b.Contas
                        where (c.NumeroConta.Equals(numeroConta))
                        select c;

            b.Contas.Remove(conta.FirstOrDefault());
        }

        private static void Depositar(string numeroConta, decimal valor)
        {
            var conta = from c in b.Contas
                        where (c.NumeroConta.Equals(numeroConta))
                        select c;

            conta.FirstOrDefault().Saldo += valor;

            Console.WriteLine(conta.FirstOrDefault().Saldo);
        }

        private static void Sacar(string numeroConta, decimal Valor)
        {
            var conta = from c in b.Contas
                        where (c.NumeroConta.Equals(numeroConta))
                        select c;

            conta.FirstOrDefault().Saldo -= Valor;
            Console.WriteLine(conta.FirstOrDefault().Saldo);
        }

        private static void ImprimirSaldo(string numeroConta)
        {
            var conta = from c in b.Contas
                        where (c.NumeroConta.Equals(numeroConta))
                        select c;

            Console.WriteLine(conta.FirstOrDefault().Saldo); 

        }
        private static void CadastrarContrato (Contrato contrato)
        {
            Console.WriteLine("Insira o numero do contrato:  ");
            contrato.NumeroContrato = Console.ReadLine();

            Console.WriteLine("Insira o numero da Conta: ");
            contrato.TotalContrato = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o valor da parcela: ");
            contrato.ValorParcela = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Insira o numero de parcelas: ");
            contrato.NumeroParcelas = int.Parse(Console.ReadLine());

            c.Contratos.Add(contrato);

            Console.WriteLine("Contrato Adicionado com sucesso!");
        }
    }
}
