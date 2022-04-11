using System;


namespace DesafioAula01_POO.Models
{
    class Triangulo : ContratoArea
    {
        public double h;
        public double b;
        public double GetArea()
        {
            var area = (b * h) / 2;

            return area;
        }
    }
}
