using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula01_POO.Models
{
    class Quadrado : ContratoArea
    {
        public double L;

        
        public double GetArea()
        {
            return Math.Pow(L, 2);
        }
    }
}
