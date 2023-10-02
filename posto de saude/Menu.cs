using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    internal class Menu
    {
        public int MenuPrinciapal()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*** Ambulatório Larissa Busana Ribeiro ***");
            Console.ResetColor();
            Console.WriteLine("Olá! Selecione o numero do menu que deseja navegar:");
            Console.WriteLine("1 - Menu Paciente");
            Console.WriteLine("2 - Menu Funcionários");
            Console.WriteLine("3 - Menu Material");
            Console.WriteLine("4 - Menu Medicamentos");
            Console.WriteLine("5 - Menu Triagem");
            Console.WriteLine("0 - Sair");

            return Convert.ToInt32(Console.ReadLine());
        }

        public int MenuPessoa()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*** Pacientes ***");
            Console.ResetColor();
            Console.WriteLine("Olá! Selecione o numero da opção que deseja:");
            Console.WriteLine("1 - Cadastrar pacientes");
            Console.WriteLine("2 - Visualizar pacientes");
            Console.WriteLine("3 - Editar cadastro de pacientes");
            Console.WriteLine("4 - Excluir pacientes");
            Console.WriteLine("0 - Sair");

            return Convert.ToInt32(Console.ReadLine());
        }
        public int MenuFuncionario()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*** Funcionários ***");
            Console.ResetColor();
            Console.WriteLine("Olá! Selecione o numero da opção que deseja:");
            Console.WriteLine("1 - Cadastrar funcionários");
            Console.WriteLine("2 - Visualizar funcionário");
            Console.WriteLine("3 - Editar cadastro de funcionários");
            Console.WriteLine("4 - Demitir funcionários");
            Console.WriteLine("0 - Sair");

            return Convert.ToInt32(Console.ReadLine());
        }
        public int MenuMaterial()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*** Materiais ***");
            Console.ResetColor();
            Console.WriteLine("Olá! Selecione o numero da opção que deseja:");
            Console.WriteLine("1 - Cadastrar materiais");
            Console.WriteLine("2 - Visualizar materiais");
            Console.WriteLine("3 - Editar materiais");
            Console.WriteLine("4 - Excluir materiais");
            Console.WriteLine("0 - Sair");

            return Convert.ToInt32(Console.ReadLine());
        }
        public int MenuMedicamento()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*** Medicamentos ***");
            Console.ResetColor();
            Console.WriteLine("Olá! Selecione o numero da opção que deseja:");
            Console.WriteLine("1 - Cadastrar medicamento");
            Console.WriteLine("2 - Visualizar medicamento");
            Console.WriteLine("3 - Editar cadastro de medicamento");
            Console.WriteLine("4 - excluir medicamento");
            Console.WriteLine("0 - Sair");

            return Convert.ToInt32(Console.ReadLine());
        }
        public int MenuTriagem()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*** Triagem ***");
            Console.ResetColor();
            Console.WriteLine("Olá! Selecione o numero da opção que deseja:");
            Console.WriteLine("1 - Cadastrar nova triagem");
            Console.WriteLine("2 - Visualizar triagens");
            Console.WriteLine("3 - Editar triagem");
            Console.WriteLine("4 - excluir triagem");
            Console.WriteLine("0 - Sair");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
