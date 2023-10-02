using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    internal class Funcionario : Pessoa
    {
        private int matricula;

        public string Cargo { get; set; }
        public string Turno { get; set; }
        public int Matricula
        {
            get
            { return matricula; }
            set
            {
                if (value > 0)
                {
                    matricula = value;
                }
            }
        }
        public Funcionario(string nome, double idade, string rua, string cargo, string turno, int matricula)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Rua = rua;
            this.Cargo = cargo;
            this.Turno = turno;
            this.Matricula = matricula;
        }
    }
}
