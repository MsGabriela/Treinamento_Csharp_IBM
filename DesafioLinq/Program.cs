using System;
using System.Collections.Generic;
using System.Linq;

/// Montar uma lista dos 10 carros mais vendidos em 2021
/// Tendo uma lista de carros(Nome do Carro, Nome da Marca, TotalVendidos) OK
/// Agrupar os carros por marca
/// Listar todos os carros da marca FIAT
/// Ordenar por mais vendido em resultado
/// 
//Os 10 carros mais vendidos em 2021

//1º Fiat Strada                          Total de vendas = **109.112**

//2º Hyundai HB20                    Total de vendas = **86.464**

//3º Fiat Argo                             Total de vendas = **84.656**

//4º Jeep Renegade                   Total de vendas = **73.927**

//5º Chevrolet Onix                    Total de vendas = **73.633**

//6º Jeep Compass                     Total de vendas = **70.923**

//7º Fiat Toro                              Total de vendas = **70.914**

//8º Volkswagen Gol                  Total de vendas = **66.234**

//9º Fiat Mobi                             Total de vendas = **65.855**

//10º Hyundai Creta                    Total de vendas = **64.764**



namespace DesafioLinq
{
    class Carro
        {
            public string NomeCarro { get; set; }
            public string  Marca { get; set; }

            public  double TotalVendidos { get; set; }
        }
        class Program
    {
        static void Main(string[] args)
        {
            var carros = new List<Carro>();



            carros.Add(new Carro { NomeCarro = "Strada", Marca = "FIAT", TotalVendidos = 109.112 });
            carros.Add(new Carro { NomeCarro = "Argo", Marca = "FIAT", TotalVendidos = 84.656 });
            carros.Add(new Carro { NomeCarro = "HB20", Marca = "Hyundai", TotalVendidos = 86.464 });
            carros.Add(new Carro { NomeCarro = "Renegade", Marca = "Jeep", TotalVendidos = 73.927 });
            carros.Add(new Carro { NomeCarro = "Onix", Marca = "Chevrolet", TotalVendidos = 73.633 });

            carros.Add(new Carro { NomeCarro = "Compass", Marca = "Jeep", TotalVendidos = 70.923 });
            carros.Add(new Carro { NomeCarro = "Toro", Marca = "FIAT", TotalVendidos = 70.914 });
            carros.Add(new Carro { NomeCarro = "Gol", Marca = "Volkswagen", TotalVendidos = 66.234 });
            carros.Add(new Carro { NomeCarro = "Mobi", Marca = "FIAT", TotalVendidos = 65.855 });
            carros.Add(new Carro { NomeCarro = "Creta", Marca = "Hyundai", TotalVendidos = 64.764 });

            var consultaMarcaFIAT =
                from fiat in carros
                where fiat.Marca.Contains("FIAT")
                select fiat;

            foreach (var f in consultaMarcaFIAT)
            {
                Console.WriteLine( "Carros da Fiat: " + f.Marca  +  " Nome do Carro: " + f.NomeCarro );
                
                Console.WriteLine("");
            }
            Console.WriteLine(" Possuem: " + consultaMarcaFIAT.Count());

            var consultaCarro=
                from carro in carros
                orderby carro.TotalVendidos
                group carro by carro.NomeCarro;

            

            foreach (var carro in consultaCarro)
            {
                Console.WriteLine("");
                Console.WriteLine(carro.Key  + "  possuem "  + carro.Count()  );
            }
            Console.WriteLine("Os 10 carros mais vendidos em 2021");
            foreach (var vendidos in carros)
            {
                Console.WriteLine("");
                Console.WriteLine("Nome carro: " + vendidos.NomeCarro + " Total vendidos: " + vendidos.TotalVendidos);
            }


            Console.ReadKey();
        }
    }
}
