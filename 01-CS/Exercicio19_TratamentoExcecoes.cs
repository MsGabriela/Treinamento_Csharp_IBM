using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CS
{
    class Exercicio19_TratamentoExcecoes

    {
        
       static void nMain(string[] args)
        {

            int numeroQualquer = 15;

            try
            {
                // numeroQualquer = Int16.Parse("ABC");
                numeroQualquer = numeroQualquer / 0;

            } catch (FormatException e)
            {
                numeroQualquer = 0;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("ERRO DE DIVISAO POR ZERO!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro Generico");
            }
            finally
            {
                Console.WriteLine("o FINALLY sempre eh executado!");
            }

            Console.WriteLine("Numero: " + numeroQualquer);
        }
    }

   
}
