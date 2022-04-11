using System;
using System.Collections.Generic;
using System.Text;

namespace Topico_POO.Modelos
{
    class Funcionario : Pessoa
    {
        public float Salario { get; set; }

        public Funcionario(string CPF, string nome, float salario) : base(CPF, nome)
        {
            Salario = salario;
        }
    }
}
