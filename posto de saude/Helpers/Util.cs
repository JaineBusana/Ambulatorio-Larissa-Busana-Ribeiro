using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude.Helpers
{
    public class Util
    {
        public static string MudarInformacoes(string valor)
        {
            if (!string.IsNullOrEmpty(valor))
            {
                if (PerguntarSimNao($"Deseja alterar o dado: {valor}?") == 'S')
                {
                    Console.WriteLine("Digite o valor editado: ");
                    valor = Console.ReadLine();
                }
            }
            else
            {
                valor = Console.ReadLine();
            }
            return valor;
        }
        public static int MudarInformacoes(int valor)
        {
            if (valor > 0)
            {
                if (PerguntarSimNao($"Deseja alterar o dado: {valor}?") == 'S')
                {
                    Console.WriteLine("Digite o valor editado: ");
                    valor = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                valor = Convert.ToInt32(Console.ReadLine());
            }
            return valor;
        }


        public static char PerguntarSimNao(string mensagem = "Deseja continuar?")
        {
            Console.WriteLine($"{mensagem} S/N");
            return Convert.ToChar(Console.ReadLine());
        }
    }
}
