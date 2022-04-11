using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_POO
{
    //Aula de Linq
    class Aluno
    {
        public string Nome { get; set; }
        public string Curso { get; set; }
        public int Nota { get; set; }
    }
    class Topico02
    {
        static void nain(string[] args)
        {
            var alunos = new List<Aluno>();
            alunos.Add(new Aluno { Nome = "Aluno 1", Curso = "Ciência da Computação" });
            alunos.Add(new Aluno { Nome = "Aluno 2", Curso = "Estatística" });
            alunos.Add(new Aluno { Nome = "Aluno 3", Curso = "Matemática" });
            alunos.Add(new Aluno { Nome = "Aluno 4", Curso = "Estatística" });
            alunos.Add(new Aluno { Nome = "Aluno 5", Curso = "Ciência da Computação" });
            alunos.Add(new Aluno { Nome = "Aluno 6", Curso = "Ciência da Computação" });

            var consultaAlunosPorCurso =
                from aluno in alunos
                group aluno by aluno.Curso;


            //Ao fazermos um foreach 
            foreach (var grupoCurso in consultaAlunosPorCurso)
            {
                Console.WriteLine(grupoCurso.Key + " possuem " + grupoCurso.Count() + " alunos");
                foreach (var aluno in grupoCurso)
                {
                    Console.WriteLine(aluno.Nome);
                    Console.WriteLine("");
                }
            }
        }
    }
}
