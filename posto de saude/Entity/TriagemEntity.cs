using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude.Entity
{
    internal class TriagemEntity
    {
        public double Peso { get; set; }
        public double Pressao { get; set; }
        public double Altura { get; set; }
        public double Temperatura { get; set; }
        public double Saturacao { get; set; }

        private double perimetroCefalico { get; set; }
        public string Sintoma { get; set; }
    }
}
