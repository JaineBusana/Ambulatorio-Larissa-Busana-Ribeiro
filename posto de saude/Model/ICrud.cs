using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude.Model
{
    internal interface ICrud
    {
        public void Create();
        public void Read();
        public void Update();
        public void Delete();
    }
}
