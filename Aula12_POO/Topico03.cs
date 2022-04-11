using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_POO
{
    //Aula de Linq
    class Jogador
    {
        public int JogadorId { get; set; }
        public string Nome { get; set; }
        public int ClubeId { get; set; }
    }
    class Clube
    {
        public int ClubeId { get; set; }
        public string Nome { get; set; }
        public string Pais { get; set; }

        public List<Jogador> Jogadores { get; set; }

        public Clube()
        {
            Jogadores = new List<Jogador>();
        }
    }

    class Topico03
    {
        static void nMain(string[] args)
        {

            var clubes = new List<Clube>();

            clubes.Add
                (
                    new Clube
                    {
                        ClubeId = 100,
                        Nome = "Juventus",
                        Pais = "Italia",
                    Jogadores =
                    {
                            new Jogador { JogadorId = 1, Nome = "Cristiano Ronaldo"},
                            new Jogador { JogadorId = 2, Nome = "Dyballa"}

                    }
                    }
                );
            clubes.Add
                (
                    new Clube
                    {
                        ClubeId = 100,
                        Nome = "PSG",
                        Pais = "Franca",
                        Jogadores =
                    {
                            new Jogador { JogadorId = 3, Nome = "Neymar"},
                            new Jogador { JogadorId = 4, Nome = "Mbappe"}

                    }
                    }
                );
            clubes.Add
                (
                    new Clube
                    {
                        ClubeId = 100,
                        Nome = "Barcelona",
                        Pais = "Italia",
                        Jogadores =
                    {
                            new Jogador { JogadorId = 5, Nome = "Messi"},
                            

                    }
                    }
                );

            foreach (var clube  in clubes)
            {
                Console.WriteLine("");
                Console.WriteLine("Clube: "  + clube.Nome + " / " + clube.Pais);

                foreach (var jogador in clube.Jogadores)
                {
                    Console.WriteLine(jogador.Nome);
                }
            }

            //clubes.Add(new Clube { ClubeId = 100, Nome = "Juventus", Pais = "Itália" });
            //clubes.Add(new Clube { ClubeId = 200, Nome = "PSG", Pais = "França" });
            //clubes.Add(new Clube { ClubeId = 300, Nome = "Barcelona", Pais = "Espanha" });

            //var jogadores = new List<Jogador>();
            //jogadores.Add(new Jogador { JogadorId = 1, Nome = "Messi", ClubeId = 300 });
            //jogadores.Add(new Jogador { JogadorId = 2, Nome = "Cristiano Ronaldo", ClubeId = 100 });
            //jogadores.Add(new Jogador { JogadorId = 3, Nome = "Neymar", ClubeId = 200 });
            //jogadores.Add(new Jogador { JogadorId = 4, Nome = "Mbappé", ClubeId = 200 });

            //var consultaJoin =
            //    from jogador in jogadores
            //    join clube in clubes
            //    on jogador.ClubeId equals clube.ClubeId
            //    select new { NomeJogador = jogador.Nome, NomeClube = clube.Nome };

            //foreach (var obj in consultaJoin)
            //{
            //    Console.WriteLine("Jogador: " + obj + " Joga no Clube: "  + obj.NomeClube);
            //}

            Console.ReadKey();
        }
    }
}
