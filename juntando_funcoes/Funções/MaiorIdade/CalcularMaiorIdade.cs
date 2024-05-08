using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juntando_funcoes.Funções.MaiorIdade
{
    public class CalcularIdade
    {
        public static void Dados()
        {
            Pessoas Primeira = new Pessoas();
            Pessoas Segunda = new Pessoas();

            Console.WriteLine("Digite o nome da primeira pessoa:");
            Primeira.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade de " + Primeira.Nome + ":");
            Primeira.Idade = LerIdade();

            Console.WriteLine("Digite o nome da segunda pessoa:");
            Segunda.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade de " + Segunda.Nome + ":");
            Segunda.Idade = LerIdade();

            Console.WriteLine("\nDados:");
            MostrarDados(Primeira);
            Console.WriteLine("\nDados:");
            MostrarDados(Segunda);

            MostrarPessoaMaisVelha(Primeira, Segunda);
        }

        public static int LerIdade()
        {
            int idade;
            while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
            {
                Console.WriteLine("Por favor, digite uma idade válida (número inteiro positivo):");
            }
            return idade;
        }

        static void MostrarDados(Pessoas pessoa)
        {
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Idade: {pessoa.Idade}");
            Console.WriteLine("---------------------------");
        }

        static void MostrarPessoaMaisVelha(Pessoas pessoa1, Pessoas pessoa2)
        {
            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine($"A pessoa mais velha é: {pessoa1.Nome}" + $" Pois tem {pessoa1.Idade} Anos");
                Console.WriteLine($"A diferença de idade é de {pessoa1.Idade - pessoa2.Idade} Anos");
            }
            else if (pessoa2.Idade > pessoa1.Idade)
            {
                Console.WriteLine($"A pessoa mais velha é: {pessoa2.Nome}" + $" Pois tem {pessoa2.Idade} Ano(s)");
                Console.WriteLine($"A diferença de idade é de {pessoa2.Idade - pessoa1.Idade} Ano(s)");

            }
            else
            {
                Console.WriteLine("Ambas as pessoas têm a mesma idade.");
            }
        }
    }

    class Pessoas
    {
        public string Nome;
        public int Idade;
    }
}

