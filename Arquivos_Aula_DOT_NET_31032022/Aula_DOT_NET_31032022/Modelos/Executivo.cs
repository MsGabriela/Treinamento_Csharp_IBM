using System;
using System.Collections.Generic;
using System.Text;

namespace Topico_POO.Modelos
{
    class Executivo : Funcionario, ILecionavel
    {
        public float Bonus { get; set; }

        public Executivo(string CPF, string nome, float salario, float bonus) : base(CPF, nome, salario)
        {
            Bonus = bonus;
        }

        public float GetValorPorHora()
        {
            return 2000f;
        }
    }
}
