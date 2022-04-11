using System;

namespace DesafioAula04_POO.Models
{
    public class Administrativo : Funcionario
    {
        public Administrativo(string cargo, decimal salario) : base(cargo, salario)
        {
        }

        public override decimal GetSalario()
        {
            return base.Salario;
        }
    }
}
