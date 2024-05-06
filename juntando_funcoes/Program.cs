using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Escolha uma opção abaixo:");
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
                    Saudacao();
                    break;
                case 2:
                    LerArquivo();
                    break;
                case 3:
                    ExibirTabuada();
                    break;
                case 4:
                    MaiorIdade.Dados();
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

    static void Saudacao()
    {
        // Obtém o horário atual
        DateTime agora = DateTime.Now;

        // Obtém a hora do horário atual
        int hora = agora.Hour;

        // Define a saudação de acordo com a hora do dia
        string saudacao;
        if (hora <= 12)
        {
            saudacao = "Bom dia";
        }
        else if (hora <= 18)
        {
            saudacao = "Boa tarde";
        }
        else
        {
            saudacao = "Boa noite";
        }

        // Mostra a saudação
        Console.WriteLine(saudacao);
    }

    static void LerArquivo()
    {
        Console.WriteLine("Informe o caminho do arquivo:");
        string caminho = Console.ReadLine();

        // Verifica se o arquivo existe
        if (File.Exists(caminho))
        {
            // Verifica se o arquivo tem uma extensão suportada
            string extensao = Path.GetExtension(caminho).ToLower();
            if (extensao == ".txt" || extensao == ".csv" || extensao == ".xml" || extensao == ".json" || extensao == ".xlsx")
            {
                Arquivo.LerArquivo(caminho);
            }
            else
            {
                Console.WriteLine("Extensão de arquivo não suportada. Por favor, escolha um arquivo de texto " +
                    "(.txt), CSV (.csv), XML (.xml), JSON (.json) ou planilha Excel (.xlsx).");
            }
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
    }

    static void ExibirTabuada()
    {
        Console.WriteLine("Digite um número para exibir a tabuada:");
        int numero;
        if (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Por favor, insira um número válido.");
            return;
        }

        Console.WriteLine($"Tabuada do {numero}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i} = {numero * i}");
            Console.WriteLine("--------------");
        }
    }

    class Arquivo
    {
        public static void LerArquivo(string nomeArquivo)
        {
            try
            {
                using (StreamReader arquivo = File.OpenText(nomeArquivo))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao ler o arquivo: " + ex.Message);
            }
        }
    }

    class MaiorIdade
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

        static int LerIdade()
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
