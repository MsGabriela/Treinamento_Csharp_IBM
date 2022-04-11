using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Faça um algoritmo que receba uma data (Dia; Mes; Ano; Hora; Minuto; Segundo)
// 1- Devolver uma msg informando se esta data é de uma ano bissexto;
// 2- Informe a data uma semana atras; 
// 3- Informe se é final de semana

namespace _01_CS
{
    class DesafioAula04
    {
        static void xNotMain(string[] args)
        {
            int day, month, year, hour, minute, second;
            
            Console.WriteLine("Informe o dia de hoje: ");
            day = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o mes: ");
            month = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o ano: ");
            year = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a hora atual: ");
            hour = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe os minutos atuais:: ");
            minute = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe os segundos: ");
            second = int.Parse(Console.ReadLine());

            DateTime d = new DateTime(year, month, day, hour, minute, second);

            if (year % 400 == 0)
            {
                Console.WriteLine(year + " eh bissexto.");
            }
            else if((year % 4 == 0)&& (year % 100 != 0))
            {
                Console.WriteLine(year + " eh bissexto.");
            }
            else
            {
                Console.WriteLine("Nao eh bissexto");
            }


            Console.WriteLine(" A data uma semana atras : " + d.AddDays(-7));

            Console.WriteLine("Dia da semana: " + d.DayOfWeek);

            if(d.DayOfWeek == DayOfWeek.Saturday  || d.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Final de semana!");
            }
            else
            {
                Console.WriteLine("Dia na semana");
            }
            
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
