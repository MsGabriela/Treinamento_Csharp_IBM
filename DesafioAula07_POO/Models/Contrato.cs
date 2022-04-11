using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula07_POO.Models
{
    public class Contrato
    {
        public string NumeroContrato { get; set; }
        public decimal TotalContrato { get; set; }

        public decimal ValorParcela { get; set; }
        public int NumeroParcelas { get; set; }
    }
}
