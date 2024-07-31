using System;

namespace CalculadoraDeNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aluno;
            double[] notas = new double[5];
            string[] aprovProva = new string[5];

            Console.WriteLine("Informe o Nome do Aluno:");
            aluno = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                notas[i] = LerNota($"Informe a nota da atividade {i + 1}: ");
            }

            notas[4] = LerNota("Informe a nota da prova: ");

            for (int i = 0; i < 5; i++)
            {
                aprovProva[i] = notas[i] < 7 ? "Reprovado" : "Aprovado";
            }

            double somaAtividades = 0;
            for (int i = 0; i < 4; i++)
            {
                somaAtividades += notas[i];
            }

            double mediaAtividades = somaAtividades / 4;

            double notaFinal = (mediaAtividades * 4 + notas[4] * 6) / 10;
            string aprovFinal = notaFinal >= 7 ? "Aprovado" : "Reprovado";

            Console.WriteLine($"\nAluno: {aluno}\n");
            Console.WriteLine("Atividades\tStatus\n");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{notas[i]}\t\t{aprovProva[i]}");
            }
            Console.WriteLine($"\nProva\t\tStatus");
            Console.WriteLine($"{notas[4]}\t\t{aprovProva[4]}\n");
            Console.WriteLine("Nota Final\tResultado");
            Console.WriteLine($"{notaFinal:F2}\t\t{aprovFinal}\n");

            if (aprovFinal == "Aprovado")
            {
                Console.WriteLine($"Parabéns {aluno}!! Você está habilitado para o próximo semestre.");
            }
            else
            {
                Console.WriteLine($"{aluno}.. você NÃO está habilitado para o próximo semestre. Agende sua prova de revisão.");
            }
        }

        static double LerNota(string mensagem)
        {
            double nota;
            while (true)
            {
                Console.Write(mensagem);
                if (double.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 10)
                {
                    return nota;
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número válido entre 0 e 10.");
                }
            }
        }
    }
}
