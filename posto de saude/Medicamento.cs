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
        public void Popular()
        {
            Console.WriteLine("Informe o nome do material:");
            Nome = Console.ReadLine();

            Console.WriteLine("Quantidade no estoque:");
            QtdEstoque = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe sua indicação:");
            Indicacao = Console.ReadLine();

            Console.WriteLine("Informe seu mês de validade:");
            MesValidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe seu ano de validade:");
            AnoValidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a dosagem do medicamento:");
            dosagem= Console.ReadLine();

            Console.WriteLine("Informe a via de administração:");
            viaDeAdministracao= Console.ReadLine();

        }

        public void Listar()
        {
            Console.WriteLine($" Nome do medicamento: {Nome} | Quantidade de estoque: {QtdEstoque} |" +
                $" Mês de validade: {MesValidade} | Ano de validade: {AnoValidade} | Indicação: {Indicacao} " +
                $"| Dosagem: {dosagem} | Via de administração: {viaDeAdministracao}");
        }
    }

}