using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CS
{
    class Exercicio12_ManipulacaoDatas
    {
        static void NotMaixn(string [] args)
        {
            DateTime data1 = new DateTime(2020,12, 18,15,11,10);
            DateTime data2 = new DateTime(2020,12,18,15, 11, 10);  // New DateTime(2020, 12, 18);
            data1 = DateTime.Today;
            data2 = DateTime.Now;

            StringBuilder s1 = new StringBuilder("AAAAAA");
            StringBuilder s2 = new StringBuilder("AAAAAA");

            Console.WriteLine(data1.ToString() + "         "  + data2.ToString());
            Console.WriteLine("Year: " + data1.Year);
            Console.WriteLine("Month: " + data1.Month);
            Console.WriteLine("Day: " + data1.Day);
            Console.WriteLine("Hour: " + data1.Hour);


            Console.WriteLine("Data 1 : " + data1.AddDays(2));//adicionando mais dias ou reduzir
            Console.WriteLine("Data 2: " + data2.AddYears(2)); // adicionando mais anos ou reduzir
            Console.WriteLine("Dia da Semana: " + data1.DayOfWeek);
            Console.WriteLine("Dia do ano: " + data2.DayOfYear);

            string dataISOString = "20190501T08:30:52Z";
            Console.WriteLine();

            Console.WriteLine(data1.Equals(data2));



            Console.ReadKey();
        }
    }
}
