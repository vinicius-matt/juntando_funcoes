using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juntando_funcoes.Funções.Saudação
{
    class Saudar
    {
        public static void Saudacao()
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
    }
}
