using System;
using System.Collections.Generic;
using System.Text;

namespace Topico_POO.Modelos
{
    class Aula
    {
        public string Titulo { get; set; }
        public string Local { get; set; }
        public DateTime DataHora { get; set; }
        public ILecionavel Professor { get; set; }

        public Aula(string titulo, string local, DateTime datahora, ILecionavel professor)
        {
            Titulo = titulo;
            Local = local;
            DataHora = datahora;
            Professor = professor;
        }

        public string GetInfo()
        {   // como sabemos que todos implementam a classe Pessoa  podemos fazer esse cast com Pessoa 
            return "Aula de " + Titulo + " no " + Local + " na data " + DataHora + " por " + ((Pessoa)Professor).Nome + " e vai receber " + Professor.GetValorPorHora() + " por hora";
        }
    }
}
