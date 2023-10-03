using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    internal class Cadastro
    {
=
        public static void CadastroPessoa()
        {
            Console.Clear();
            Pessoa novaPessoa = new Pessoa();
            Console.WriteLine("Informe o nome do funcionário:");
            novaPessoa.Nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            novaPessoa.Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rua:");
            novaPessoa.Rua = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Menu.MenuPessoa("Paciente cadastrado com sucesso!\n");
            Console.ResetColor();
        }
        public static void CadastroFuncionario()
        {
            Console.Clear();
            Console.WriteLine("Informe o nome do funcionário:");
            string nomeFuncionario = Console.ReadLine();
            Console.WriteLine("Idade:");
            int idadeFuncionario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rua:");
            string ruaFuncionario = Console.ReadLine();
            Console.WriteLine("Cargo:");
            string cargoFuncionario = Console.ReadLine();
            Console.WriteLine("Turno:");
            string turnoFuncionario = Console.ReadLine();
            Console.WriteLine("Informe a matricula");
            int matriculaFuncionario = Convert.ToInt32(Console.ReadLine());

            Funcionario novoFuncionario = new Funcionario(nomeFuncionario, idadeFuncionario, ruaFuncionario, 
                cargoFuncionario, turnoFuncionario, matriculaFuncionario);

            Console.ForegroundColor = ConsoleColor.Green;
            Menu.MenuFuncionario("Funcionário cadastrado com sucesso!\n");
            Console.ResetColor();
        }

        public static void CadastroMaterial()
        {
            Console.Clear();
            Material novoMaterial = new Material();
            Console.WriteLine("Informe o nome do material:");
            novoMaterial.Nome = Console.ReadLine();
            Console.WriteLine("Quantidade no estoque:");
            novoMaterial.QtdEstoque = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe sua indicação:");
            novoMaterial.Indicacao = Console.ReadLine();
            Console.WriteLine("Informe seu mês de validade:");
            novoMaterial.MesValidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe seu ano de validade:");
            novoMaterial.AnoValidade = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Green;
            Menu.MenuMaterial("Material cadastrado com sucesso!\n");
            Console.ResetColor();
        }

        public static void CadastroMedicamento()
        {
            Console.Clear();
            Console.WriteLine("Informe o nome do medicamento:");
            string nomeMedicamento = Console.ReadLine();
            Console.WriteLine("Quantidade no estoque:");
            int qtdEstoqueMedicamento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe sua indicação:");
            string indicacaoMedicamento = Console.ReadLine();
            Console.WriteLine("Informe seu mês de validade:");
            int mesValidadeMedicamento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe seu ano de validade:");
            int anoValidadeMedicamento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a dosagem do medicamento:");
            string dosagemMedicamento = Console.ReadLine();
            Console.WriteLine("Informe a via de administração:");
            string viaDeAdministracaoMedicamento = Console.ReadLine();

            Medicamento novoMedicamento = new Medicamento(nomeMedicamento, qtdEstoqueMedicamento, indicacaoMedicamento, 
                mesValidadeMedicamento, anoValidadeMedicamento, dosagemMedicamento, viaDeAdministracaoMedicamento);

            Console.ForegroundColor = ConsoleColor.Green;
            Menu.MenuMedicamento("Medicamento cadastrado com sucesso!\n");
            Console.ResetColor();
        }

        public static void CadastroTriagem()
        {
            Console.Clear();
            Console.WriteLine("Informe o nome do paciente:");
            // vai ter que buscar o arquivo de pacientes
            string paciente = Console.ReadLine();
            Console.WriteLine("Informe o peso do paciente:");
            int peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pressão arterial:");
            int pressao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Altura:");
            int altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Temperatura:");
            int temperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saturação:");
            int saturacao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quais os sintomas do paciente:");
            string sintomas = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Menu.MenuTriagem("Triagem cadastrada com sucesso!\n");
            Console.ResetColor();
        }


    }
}
