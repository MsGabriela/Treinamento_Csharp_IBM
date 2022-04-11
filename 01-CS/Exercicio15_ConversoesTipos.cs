using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CS
{
    class Exercicio15_ConversoesTipos
    {
        
       static void NotMain(string[] args)
        {
            int idade = 10;
            short salario = 1234;
            int salario2 = salario;

            char x = 'c';
            string s = "teste";

            s = x.ToString();

            float precoLivro = 90.52f;

            int precoLivroInteiro = (int)precoLivro;

            string numeroEmString = "1234,56";

            //float valor = numeroEmString;

            float valor = Convert.ToSingle(numeroEmString);

            double valor2 = Convert.ToDouble(numeroEmString);



           
        }
    }

   
}
