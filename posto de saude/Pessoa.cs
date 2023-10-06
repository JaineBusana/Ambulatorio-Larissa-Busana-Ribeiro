using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    public class Pessoa
    {
        protected string nome;

        public string Nome
        {
            get 
            { return nome; } 
            set 
            {
                if (!string.IsNullOrEmpty(value)) 
                { 
                nome = value; 
                }
            }
        }
        public double Idade { get; set; }
        public string Rua { get; set; }

        public void Popular()
        {
            Console.WriteLine("Informe o nome do funcionário:");
            Nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rua:");
            Rua = Console.ReadLine();
        }

        public void Listar()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade:{Idade}\nRua:{Rua}\n");
        }
    }
}
