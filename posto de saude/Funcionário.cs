using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    internal class Funcionario : Pessoa
    {
        //private int matricula;

        public string Cargo { get; set; }
        public string Turno { get; set; }
        //public int Matricula
        //{
        //    get
        //    { return matricula; }
        //    set
        //    {
        //        if (value > 0)
        //        {
        //            matricula = value;
        //        }
        //    }
        //}
        public Funcionario(string nome, double idade, string rua, string cargo, string turno,/* int matricula*/)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Rua = rua;
            this.Cargo = cargo;
            this.Turno = turno;
            //this.Matricula = matricula;


        }

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
