using System;
using System.Collections.Generic;

namespace juntando_funcoes.Funções.CalculoMedia
{
    public class Calculo
    {
        public static void CalcularMediaAlunos()
        {
            double qtdNotas = 3;
            double totalNotas = 0;

            Console.WriteLine("Digite o Nome do Aluno");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite as " + qtdNotas + " notas do aluno " + nome + "\n");

            List<double> notas = new List<double>();
            for (int i = 0; i < qtdNotas; i++)
            {
                Console.WriteLine("Digite a " + (i + 1) + "º nota" + " de " + nome);
                double nota;
                bool notaValida;
                do
                {
                    notaValida = double.TryParse(Console.ReadLine(), out nota);
                    if (!notaValida || nota < 0 || nota > 10)
                    {
                        Console.WriteLine("Nota inválida! Digite novamente (entre 0 e 10).");
                        notaValida = false;
                    }
                } while (!notaValida);

                totalNotas += nota;
                notas.Add(nota);
            }
            double media = totalNotas / notas.Count;
            Console.WriteLine("A média do aluno " + nome + " é: " + media.ToString("0.00").Replace('.', ','));
            Console.WriteLine("Suas notas são:\n");

            foreach (double nota in notas)
            {
                Console.WriteLine("Nota: " + nota.ToString("0.00").Replace('.', ','));
            }
        }
    }
}
