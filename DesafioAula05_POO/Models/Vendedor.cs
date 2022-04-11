using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula04_POO.Models
{
    class Vendedor : Funcionario
    {
        public Vendedor()
        {
                
        }
        public Vendedor(string cargo, decimal salario) : base(cargo, salario)
        {
        }

        public override decimal GetSalario()
        {
            double comissao = 0.10;
            return Salario = Salario + (Salario * (decimal)comissao);   
        }
    }
}
