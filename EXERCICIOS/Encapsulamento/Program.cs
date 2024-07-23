using System;
using System.Globalization;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1;

            Console.Write("Insira o nome do Aluno: ");
            string nomeAluno = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Insira a turma do Aluno: ");
            char turma = char.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Insira o curso do Aluno: ");
            string curso = Console.ReadLine();
            Console.WriteLine();

            Console.Write("O aluno ja possui alguma nota? (s/n) ");
            char verifica = char.Parse(Console.ReadLine());
            if (verifica == 's' || verifica == 'S')
            {
                Console.Write("Digite aqui a nota do aluno: ");
                double notaInicial =  double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                aluno1 = new Aluno(nomeAluno, turma, curso, notaInicial);
            }
            else
            {
                aluno1 = new Aluno(nomeAluno, turma, curso);
            }

            Console.WriteLine($"Os dados cadastrados são: {aluno1.Nome}, turma: {aluno1.Turma}, ");

            Console.Write($"Lance uma nota para o aluno {aluno1.Nome} da turma {aluno1.Turma}");
            double nota = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            aluno1.LancarNotas(nota);
            Console.WriteLine();

            Console.Write("Voce deseja alterar o aluno de turma? (s/n) ");
            char alteraTurma = char.Parse(Console.ReadLine());
            if (alteraTurma == 's' || alteraTurma == 'S')
            {
                Console.Write("Digite aqui a nova turma do aluno: ");
                char novaTurma = char.Parse(Console.ReadLine());
                aluno1.AlterarTurma(novaTurma);
            }
            else
            {
                Console.WriteLine("Certo, finalizando programa...");
            }

            Console.WriteLine("Programa finalizado!");
        }
    }
}
