using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10.Models
{
    class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public float Salario { get; set; }
​
​
        public Funcionario()
        {
            Pessoa p = new Pessoa();
            p.Nome = "Jose Sila";
​
            Pessoa p2 = new Pessoa();
            p.Nome = "Paulo Sila";
​
            Pessoa p3 = new Pessoa();
            p.Nome = "Joao Sila";
        }


    }
}
