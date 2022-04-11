using System;
using System.Collections.Generic;


namespace DesafioPOO.Models
{
    public class Calculadora : InterfaceCalculadora
    {
        public  double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public double Resultado { get; set; }

        public double Dividir()
        {
            
            try
            {
                return Numero1 / Numero2;
            }
            catch (DivideByZeroException e)
            {
                
                Console.WriteLine("Não é possível dividir por zero!");
                return 0;
            }
        }

        public double Multiplicar()
        {
            return Numero1 * Numero2;
        }

        public double Somar()
        {
            return Numero1 + Numero2;
        }

        public double Subtrair()
        {
            return Numero1 - Numero2;
        }

        
    }
}
