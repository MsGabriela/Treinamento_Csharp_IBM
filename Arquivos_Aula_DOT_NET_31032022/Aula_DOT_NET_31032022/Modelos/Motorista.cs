using System;
using System.Collections.Generic;
using System.Text;

namespace Topico_POO.Modelos
{
    class Motorista : Funcionario
    {
        public string CNH { get; set; }

        public Motorista(string CPF, string nome, float salario, string cnh) : base(CPF, nome, salario)
        {
            CNH = cnh;
        }
    }
}
