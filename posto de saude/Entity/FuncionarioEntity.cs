using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude.Entity
{
    public class FuncionarioEntity
    {
        public int ID { get; set; }
        public string CARGO { get; set; }
        public string TURNO { get; set; }

        public int PESSOA_ID { get; set; }

        public PessoaEntity PESSOA { get; set; }
    }
}
