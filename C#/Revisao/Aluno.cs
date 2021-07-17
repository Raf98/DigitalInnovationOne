using System;

namespace Revisao
{
    class Aluno
    {
        public string Nome{get; set;}
        public decimal Nota{get; set;}

        public Aluno(string Nome, decimal Nota)
        {
            this.Nome = Nome;
            this.Nota = Nota;
        }

        public void printAluno()
        {
            Console.WriteLine("\nNome:" + Nome);
            Console.WriteLine("Nota:" + Nota + "\n");
        }
    }
}