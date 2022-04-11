using System;
using System.Collections.Generic;
using System.Text;

namespace Topico_POO.Modelos
{
    class Instrutor : Funcionario, ILecionavel
    {
        public string Especialidade { get; set; }

        public Instrutor(string CPF, string nome, float salario, string especialidade) : base(CPF, nome, salario)
        {
            Especialidade = especialidade;
        }

        public float GetValorPorHora()
        {
            return 1000f;
        }
    }
}
