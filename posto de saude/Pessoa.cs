using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    internal class Pessoa
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

    }
}
