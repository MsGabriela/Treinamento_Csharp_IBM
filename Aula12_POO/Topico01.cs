using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_POO
{
    //Aula de Linq
    class Topico01
    {
       public class Municipio
        {
            public string Nome { get; set; }
            public int Populacao { get; set; }
        }
        static void nMain(string[] args)
        {
            //int[] numeros = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //var consulta =
            //    from num in numeros
            //    where (num % 2) == 0
            //    select num;

            //foreach (int num in consulta)
            //{
            //    Console.WriteLine(num);
            //}


            var municipios = new List<Municipio>();
            municipios.Add(new Municipio { Nome = "João Pessoa", Populacao = 100 });
            municipios.Add(new Municipio { Nome = "Santos", Populacao = 200 });
            municipios.Add(new Municipio { Nome = "Aracajú", Populacao = 300 });
            municipios.Add(new Municipio { Nome = "Curitiba", Populacao = 400 });
            municipios.Add(new Municipio { Nome = "Sorocaba", Populacao = 500 });
            municipios.Add(new Municipio { Nome = "Sinop", Populacao = 600 });

            var consultaMunicipioComS =
                from municipio in municipios
                where municipio.Nome.StartsWith("S") && municipio.Populacao > 200
                orderby municipio.Nome
                select municipio;

            //Sempre que utiliza Count, Max, Average, First, ....... Consulta e Feita de forma imediata

            var consulta =
               ( from municipio in municipios
                where municipio.Nome.StartsWith("S") && municipio.Populacao > 200
                orderby municipio.Nome
                select municipio).Count();

            Console.WriteLine(consulta);

            foreach (var m in consultaMunicipioComS)
            {
                Console.WriteLine(m.Nome);
            }

            Console.ReadKey();

        }
    }
}
