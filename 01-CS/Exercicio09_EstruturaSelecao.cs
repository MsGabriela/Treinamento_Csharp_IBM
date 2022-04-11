using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CS
{
    class Exercicio09_EstruturaSelecao
    {
        static void NotMainxx(string[] args)
        {
            int mes;
            string resposta;
            Console.WriteLine("Informe o numero do mes: ");

            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                //case 1:
                //    resposta = "Janeiro";
                //    break;
                //case 2:
                //    resposta = "Fevereiro";
                //    break;
                //case 3:
                //    resposta = "Marco";
                //    break;
                //case 4:
                //    resposta = "Abril";
                //    break;
                //case 5:
                //    resposta = "Maio";
                //    break;
                //case 6:
                //    resposta = "Junho";
                //    break;
                //case 7:
                //    resposta = "Julho";
                //    break;
                //case 8:
                //    resposta = "Agosto";
                //    break;
                //case 9:
                //    resposta = "Setembro";
                //    break;
                //case 10:
                //    resposta = "Outubro";
                //    break;
                //case 11:
                //    resposta = "Novembro";
                //    break;
                //case 12:
                //    resposta = "Desembro";
                //    break;


                case 1:
                case 2:
                case 3:
                    resposta = "1 - Trimestre";
                    break;

                case 4:
                case 5:
                case 6:
                    resposta = "2 - Trimestre";
                    break;
                case 7:
                case 8:
                case 9:
                    resposta = "3 - Trimestre";
                    break;
                case 10:
                case 11:
                case 12:
                    resposta = "4 - Trimestre";
                    break;
                default:
                    resposta = "Nao existe";
                    break;


                    Console.WriteLine("Mes: " +  " Pertence ao "+resposta);
                    Console.ReadKey();
            }
        }
        
    }
}
