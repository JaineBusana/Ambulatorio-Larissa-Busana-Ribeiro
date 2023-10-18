using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude.Entity
{
    internal class MaterialEntity
    {
        public int QtdEstoque { get; set; }
        public string Indicacao { get; set; }
        public int MesValidade { get; set; }
        public int AnoValidade { get; set; }
    }
}
