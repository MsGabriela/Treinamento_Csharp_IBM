using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos_POOAula02.Models
{
    class Pessoa
    {
        public string Nome;
        public string Sobrenome;
        public int Idade;
        private DateTime DataNascimento;

        public int AnosCompletos
        {
            get
            {
                return (DateTime.Now.Year - DataNascimento.Year);
            }
        }

        public DateTime Nascimento
        {
            set
            {
                this.DataNascimento = value;
            }
        }

        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string name)
        {
            this.Nome = name;
        }
        public int GetIdade()
        {
            return Idade;
        }
        public void SetIdade(int idade)
        {

            if (idade < 1)
            {
                throw new ArgumentOutOfRangeException("idade");
            }
            else
            {
                this.Idade = idade;
            }
        }
        public string getNomeCompleto()
        {
            return Nome + " " + Sobrenome;
        }
    }
}
