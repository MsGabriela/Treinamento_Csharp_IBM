using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAula06POO.Models
{
    public abstract class FormasGeometricas
    {
        public double x { get; set; }
        public double y { get; set; }
        public abstract double GetArea();
    }
}
