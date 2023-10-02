using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    internal class Menu
    {
        public static int MenuPrinciapal()
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

        public static void RespostaMenu()
        {
            switch (Menu.MenuPrinciapal())
            {
                case 1:
                    Console.Clear();
                    switch (MenuPessoa())
            {
                case 1:
                    Console.Clear();
                    Cadastro.CadastroPessoa();
                    break;
            }
            break;
                case 2:
                    Console.Clear();
            switch (MenuFuncionario())
            {
                case 1:
                    Console.Clear();
                    Cadastro.CadastroFuncionario();
                    break;
            }
            break;
                case 3:
                    Console.Clear();
            switch (MenuMaterial())
            {
                case 1:
                    Console.Clear();
                    Cadastro.CadastroMaterial();
                    break;
            }
            break;
                    case 4:
                    Console.Clear();
            switch (MenuMedicamento())
            {
                case 1:
                    Console.Clear();
                    Cadastro.CadastroMedicamento();
                    break;
            }
            break;
                    case 5:
                    Console.Clear();
            switch (MenuTriagem())
            {
                case 1:
                    Console.Clear();
                    Cadastro.CadastroTriagem();
                    break;
            }
            break;
                    case 0:
                    Console.WriteLine("Falow");
            break;
        }
    }

        public static int MenuPessoa()
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
        public static int MenuFuncionario()
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
        public static int MenuMaterial()
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
        public static int MenuMedicamento()
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
        public static int MenuTriagem()
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
