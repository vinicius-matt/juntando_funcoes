using System;
using System.IO;
using juntando_funcoes.saudar;
using juntando_funcoes.LerDocumento;
using juntando_funcoes.Tabuada;
using juntando_funcoes.Idade;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Ola Seja Bem-Vindo(a)\n");
            Console.WriteLine("Escolha uma opção das opções abaixo:");
            Console.WriteLine("-------------------");
            Console.WriteLine("1 - Saudação");
            Console.WriteLine("2 - Ler Arquivo");
            Console.WriteLine("3 - Exibir Tabuada");
            Console.WriteLine("4 - Maior Idade");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-------------------");

            int escolha;
            if (!int.TryParse(Console.ReadLine(), out escolha) || escolha < 1 || escolha > 5)
            {
                Console.WriteLine("Por favor, insira uma opção válida (1 a 5).");
                continue;
            }

            switch (escolha)
            {
                case 1:
                    Saudar.Saudacao();
                    break;
                case 2:
                    LerDocumento.LerArquivo();
                    break;
                case 3:
                    Tabuada.ExibirTabuada();
                    break;
                case 4:
                    CalcularIdade.Dados();
                    break;
                case 5:
                    continuar = false;
                    break;
            }

            Console.WriteLine("\nDeseja selecionar outra opção? (s/n)");
            string resposta;
            do
            {
                resposta = Console.ReadLine().ToLower();
                if (resposta != "s" && resposta != "n")
                {
                    Console.WriteLine("Digite S ou N para continuar");
                }
            } while (resposta != "s" && resposta != "n");

            if (resposta == "n")
            {
                continuar = false;
            }
        }
    }
}
   