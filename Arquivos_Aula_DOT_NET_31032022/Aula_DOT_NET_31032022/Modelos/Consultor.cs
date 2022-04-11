using System;
using System.Collections.Generic;
using System.Text;

namespace Topico_POO.Modelos
{
    class Consultor : Pessoa, ILecionavel
    {
        public string Especialidade { get; set; }

        public Consultor(string CPF, string nome, string especialidade) : base(CPF, nome)
        {
            Especialidade = especialidade;
        }

        public float GetValorPorHora()
        {
            return 1500f;
        }
    }
}
