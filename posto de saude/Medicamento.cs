using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    public class Medicamento : Material
    {
       
        public void Popular()
        {
            Console.WriteLine("Informe o nome do medicamento:");
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