using System;


namespace DesafioAula02_POO.Models
{
    interface ContratoBanco
    {
        double Sacar(double valorSaque);
        double Deposito(double valorDeposito);
        double Transferir(double valorTransferir);

        DateTime DataAgendamento(DateTime agendamento, double transacao);

        
    }
}
