using System;


namespace Aula09_POO.Models
{
    public class Conta
    {
        public int Numero { get; set; }

        public decimal Saldo { get; set; }

        public string Mensagem { get; set; }


        ContaPoupanca contaPoupanca = new ContaPoupanca();
        public Conta(int numero, decimal saldo)
        {
            this.Numero = numero;
            this.Saldo = saldo;
        }
        public virtual void Saque(decimal valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException();
            }
            else if(valor > this.Saldo) 
            {

                throw new SaldoInsuficienteException();
            }
            this.Saldo -= valor;
            this.Mensagem = "Saque efetuado com sucesso!";
        }

        public virtual void Saque(decimal valor,int numero)
        {
            if (valor < 0)
            {
                throw new ArgumentException();
            }
            else if (valor > this.Saldo)
            {

                throw new SaldoInsuficienteException();
            }
            this.Saldo -= valor;
            this.Mensagem = $"Saque da conta {numero} realizado com sucesso!";
        }


    }
}
