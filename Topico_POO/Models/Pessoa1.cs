using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico_POO.Models
{
    class Pessoa1
    {
        public string nome { get; private set; }
        public string sobrenome { get; private set; }
        public int idade { get; private set; }

        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string name)
        {
            this.nome = name;
        }
        public int GetIdade()
        {
            return idade;
        }
        public void SetIdade(int idade)
        {
            
            if(idade < 1)
            {
                throw new ArgumentOutOfRangeException("idade");
            }
            else
            {
                this.idade = idade;
            }
        }
        public string getNomeCompleto()
        {
            return nome + " " + sobrenome;
        }

    }
}
