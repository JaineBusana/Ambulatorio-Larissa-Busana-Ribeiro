using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    public class Material
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

        }

        public void Listar()
        {
            Console.WriteLine($" Nome do medicamento: {Nome} | Quantidade de estoque: {QtdEstoque} |" +
                $" Mês de validade: {MesValidade} | Ano de validade: {AnoValidade} | Indicação: {Indicacao} ");
        }

    }
}
