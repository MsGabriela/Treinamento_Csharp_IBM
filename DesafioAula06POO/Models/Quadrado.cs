using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula06POO.Models
{
    public class Quadrado : FormasGeometricas
    {
        public override double GetArea()
        {
            return Math.Pow(x, 2);
        }
    }
}
