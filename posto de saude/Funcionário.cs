using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    public class Funcionario : Pessoa
    {

        public string Cargo { get; set; }
        public string Turno { get; set; }

        public void Popular()
        {
            Console.WriteLine("Informe o nome do funcionário:");
            Nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rua:");
            Rua = Console.ReadLine();
            Console.WriteLine("Cargo:");
            Cargo = Console.ReadLine();
            Console.WriteLine("Turno:");
            Turno = Console.ReadLine();
        }

        public void Listar()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade:{Idade}\nRua:{Rua}\nCargo:{Cargo}\nTurno:{Turno}");
        }
    }
}
