using System;


namespace DesafioAula02_POO.Models
{
    class Banco : ContratoBanco
    {
        public string ClienteTitular { get; set; }
        public double Saldo { get; set; }

        public char Especial { get; set; }


        public float LimitePadrao = 1000f;


        public double Sacar(double valorSaque)
        {
            if(Especial == 's' || Especial == 'S' && Saldo < valorSaque)
            {
                double saldoFinal = 0;

                saldoFinal = Saldo - valorSaque;

                if(saldoFinal< LimitePadrao)
                {
                    Console.WriteLine("Nao foi possivel efetuar o saque!");
                }
                else
                {
                    return Saldo = Saldo - valorSaque;
                }
            }
            else
            {
                if(Saldo < valorSaque)
                {
                    return Saldo = Saldo - valorSaque;
                }
            }

            return Saldo = Saldo - valorSaque;
        }

        public double Transferir(double valorTransferir)
        {
            return Saldo =  Saldo - valorTransferir;
        }

        public double Deposito(double valorDeposito)
        {
            return Saldo =  Saldo + valorDeposito;
        }

        public DateTime DataAgendamento(DateTime agendamento, double transacao)
        {

            if(Saldo  > transacao )
            {
               Console.WriteLine("Agendamento foi efetuado com sucesso!" );
                
            }
            else if(agendamento >  DateTime.Today)
            {
                Console.WriteLine("Agendamento foi efetuado com sucesso!" );
                
            }
            else
            {
                Console.WriteLine("Data invalida para agendamento!");
            }
            return agendamento;
        }

       

    }
}
