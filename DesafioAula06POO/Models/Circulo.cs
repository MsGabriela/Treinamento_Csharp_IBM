using DesafioAula06POO.Models;
using System;

namespace DesafioAula06_POO.Models
{
    class Circulo : FormasGeometricas
    {
        public override double GetArea()
        {
            return Math.PI * Math.Pow(x, 2);
        }
    }
}
