using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude.Entity
{
    internal class MaterialEntity
    {

        public int ID {  get; set; }
        public string NOME { get; set; }
        public int QUANTIDADE { get; set; }
        public string INDICACAO { get; set; }
        public int VALIDADE { get; set; }
    }
}
