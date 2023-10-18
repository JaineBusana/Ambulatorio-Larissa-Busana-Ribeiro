using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    public class Funcionario : Pessoa
    {

        public void Popular()
        {
            Console.WriteLine("Informe o nome do material:");
            nome = Console.ReadLine();
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
            Console.WriteLine($"Nome: {nome}\nIdade:{Idade}\nRua:{Rua}\nCargo:{Cargo}\nTurno:{Turno}");
        }
    }
}
