using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace juntando_funcoes.Funções.Tabuada
{
    public class Tabuada
    {
        public static void ExibirTabuada()
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
    }
}
