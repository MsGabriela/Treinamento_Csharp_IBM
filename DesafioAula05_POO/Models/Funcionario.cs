using System;


namespace DesafioAula04_POO.Models
{
    public class Funcionario
    {
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        public Funcionario()
        {

        }
        public Funcionario(string cargo, decimal salario)
        {
            this.Salario = salario;
            this.Cargo = cargo;
        }
        public virtual decimal GetSalario()
        {
            return Salario;
        }
    }
}
