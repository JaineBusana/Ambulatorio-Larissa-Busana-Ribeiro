using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    public class Pessoa
    {
        public string nome;

        //public string Nome
        //{
        //    get 
        //    { return nome; } 
        //    set 
        //    {
        //        if (!string.IsNullOrEmpty(value)) 
        //        { 
        //        nome = value; 
        //        }
        //    }
        //}
        public double Idade { get; set; }
        public string Rua { get; set; }

        public void Popular()
        {
            Console.WriteLine("Informe o nome do paciente:");
            nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rua:");
            Rua = Console.ReadLine();
        }

        public void Listar()
        {
            Console.WriteLine($":Número de prontuário \nNome:{nome}\nIdade:{Idade}\nRua:{Rua}\n");
        }
    }
}
