using System;
/*
 Calculadora
 */

namespace Aula09_POO.Models
{
    class ContaPoupanca : Conta
    {
        public double Rendimento { get; set; }
        public ContaPoupanca(double rendimento) : base(1, 500)
        {
            this.Rendimento = rendimento;
        }
        public override void Saque(decimal valor)
        {
            base.Saque(valor + 0.10m);
        }
    }
}
