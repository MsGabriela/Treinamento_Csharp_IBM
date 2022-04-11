using System;
using System.Globalization;


//Crie um programa que armazene 10 notas em um array.
//O programa deve ler o array e imprimir os seguintes resultados:
//1) Exibir a maior nota do array(ok)
//2) Exibir a menor nota do array(ok)
//3) Exibir a soma das notas pares(ok)
//4) Exibir a soma das notas ímpares(ok)
//5) Dizer se o número 5 existe no array(ok)



namespace _01_CS
{
    class DesafioAula05
    {
        static void Main(string[] args)
        {
            double[] notas = { 5.6, 6.0, 4.5, 4.0, 5.9, 7.8, 9.0, 6.6, 8.2, 10.0};
            double somaNotaPares = 0, somaNotaImpares = 0;
            

            Array.Sort(notas);

            int menorNota = notas.GetLowerBound(0);
            int maiorNota = notas.GetUpperBound(0);


            Console.WriteLine("Menor nota: " + notas[menorNota].ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior nota: " + notas[maiorNota].ToString("F2", CultureInfo.InvariantCulture));

            for (int i = 0; i < notas.Length; i++)
            {
                if(notas[i] % 2 == 0)
                {
                    somaNotaPares += notas[i];
           
                }
                else
                {
                    somaNotaImpares += notas[i];

                }
            }
            Console.WriteLine("Soma das notas pares: " + somaNotaPares.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Soma das notas impares: " + somaNotaImpares.ToString("F2", CultureInfo.InvariantCulture));
            var existeNumero5 = Array.Exists(notas, n => n.Equals(5));
            Console.WriteLine("Existe o numero 5? " + existeNumero5);

            Console.ReadKey();

        }
    }
}
