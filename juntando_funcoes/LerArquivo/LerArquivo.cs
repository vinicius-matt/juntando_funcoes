using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juntando_funcoes.LerDocumento
{
     class LerDocumento
    {
         public static void LerArquivo()
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
    }
}
