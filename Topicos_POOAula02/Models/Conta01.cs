using System;



//Saldo tratar os eventos sacar, depositar, traferir (Verificar o saldo antes);
//Permitir Agendamento de transacoes(Tranferencia, deposito)
//Tratar o caso do cliente especial (Se cliente especial limite = LIMITE_PADRAO ou maior <Limite = especial ? LIMITE_PADRAO : 0>)

namespace Topicos_POOAula02.Models
{
    class Conta01
    {
        private const float LimitePadrao = 1000f;

        public string NomeTitular { get; set; }

        public float Saldo { get; set; }

        public bool  ClienteEspecial { get; set; }

        public float Limite { get; set; }

        public Conta01()
        {

        }
        public Conta01(string nome)
        {
            Console.WriteLine("Construtor 1");
            this.NomeTitular = nome;
            Saldo = 0;
            ClienteEspecial = false;
            Limite = 0;
        }

        public Conta01(string nome, float saldo) : this(nome)
        {
            Console.WriteLine("Construtor 2");
            this.Saldo = saldo;
            this.NomeTitular = nome;
            ClienteEspecial = false;
            Limite = 0;

        }
        public Conta01(string nome, bool especial) 
        {
            Console.WriteLine("Construtor 3");
            this.Saldo = 0;
            this.NomeTitular = nome;
            this.ClienteEspecial = especial;
        }
        public Conta01(string nome, bool especial, float saldo) 
        {
            Console.WriteLine("Construtor 4");
            this.Saldo = 0;
            this.NomeTitular = nome;
            this.ClienteEspecial = especial;
           
        }
    }
}
