using System;
using System.Globalization;

namespace Encapsulamento
{
    internal class Aluno
    {
        public string Nome { get; private set; }
        public char Turma { get; private set; }
        public string Curso { get; private set; }
        public double Notas { get; private set; }

        public Aluno(string nome, char turma, string curso)
        {
            Nome = nome;
            Turma = turma;
            Curso = curso;
        }

        public Aluno(string nome, char turma, string curso, double notas) : this(nome, turma, curso)
        {
            LancarNotas(notas);
        }

        public void AlterarTurma(char novaTurma)
        {
            if (Turma != novaTurma)
            {
                Turma = novaTurma;
            }
            else
            {
                Console.WriteLine("É necessário que a nova turma seja diferente da antiga!");
            }
        }

        public void LancarNotas(double novaNotas)
        {
            Notas += novaNotas;
        }
    }
}
