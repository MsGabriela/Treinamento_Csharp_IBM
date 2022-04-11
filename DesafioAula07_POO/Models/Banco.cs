using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula07_POO.Models
{
    public class Banco
    {
        public string Nome { get; set; }
        public List<Conta> Contas { get; set; }

        public List<Contrato> Contratos { get; set; }

        public Banco()
        {
            this.Nome = "Teste";
            this.Contas = new List<Conta>();
            this.Contratos = new List<Contrato>();
        }
    }
}
