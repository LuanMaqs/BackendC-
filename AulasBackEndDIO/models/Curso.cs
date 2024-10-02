using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulasBackEndDIO.models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAlunos(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }  
    }
}