using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula07_POO.Models
{
    public class Conta
    {
        public string NomeCliente { get; set; }
        public string NumeroConta { get; set; }

        public decimal Saldo { get; set; }
        
        public decimal Especial { get; set; }

        public List<Contrato> Contratos { get;set;}
        public Conta()
        {
            
            this.Contratos = new List<Contrato>();

        }
    }
}
