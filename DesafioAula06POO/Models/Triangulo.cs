using DesafioAula06POO.Models;
using System;


namespace DesafioAula06_POO.Models
{
    class Triangulo : FormasGeometricas
    {
      

        public override double GetArea()
        {
            var area = (x * y) / 2;
            return area;
        }
    }
}
