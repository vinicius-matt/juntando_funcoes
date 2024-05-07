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
            string mensagem = "Ola Seja Bem-Vindo(a)\n" +
                "\n" +
                "Escolha uma das opções do menu abaixo:"+
                "\n -------------------" +
                "\n 1 - Saudação" +
                "\n 2 - Ler Arquivo" +
                "\n 3 - Exibir Tabuada" +
                "\n 4 - Maior Idade" +
                "\n 5 - Sair " +
                "\n -------------------";
            Console.WriteLine(mensagem);

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
   