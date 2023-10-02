using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    internal class Material
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
        public int QtdEstoque { get; set; }
        public string Indicacao { get; set; }
        public int MesValidade { get; set; }
        public int AnoValidade { get; set; }

    }
}
