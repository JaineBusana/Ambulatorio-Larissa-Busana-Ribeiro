using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    internal class Medicamento : Material
    {
        
        private string dosagem;
        private string viaDeAdministracao;
       
        public Medicamento(string nome, int qtdEstoque, string indicacao, int mesValidade, int anoValidade,
            string dosagem, string viaDeAdministracao)
        {
            this.Nome = nome;
            this.dosagem = dosagem;
            this.QtdEstoque = qtdEstoque;
            this.Indicacao = indicacao;
            this.MesValidade = mesValidade;
            this.AnoValidade = anoValidade;
            this.viaDeAdministracao = viaDeAdministracao;
        }
    }
}