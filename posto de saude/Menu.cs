using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    internal class Menu
    {
        public static PessoaModel PessoaModel = new PessoaModel();
        public static FuncionariosModel FuncionariosModel = new FuncionariosModel();
        public static MaterialModel MaterialModel = new MaterialModel();
        public static MedicamentosModel MedicamentosModel = new MedicamentosModel();
        public static TriagemModel TriagemModel = new TriagemModel();

        public static string MenuPrinciapal()
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

            return Console.ReadLine();
        }

        public static void MostrarMenuPrincipal()
        {
            Console.Clear();
            switch (MenuPrinciapal())
            {
                case "1":
                    MostrarMenuPaciente();
                    break;
                case "2":
                    MostrarMenuFuncionarios();
                    break;
                case "3":
                    MostrarMenuMaterial();
                    break;
                case "4":
                    MostrarMenuMedicamentos();
                    break;
                case "5":
                    MostrarMenuTriagem();
                    break;
                case "0":
                    Console.WriteLine("Até logo!");
                    return;
                default:
                    Console.WriteLine("Opção inválida! \nPrecione qualquer tecla para continuar.");
                    Console.ReadLine();
                    MostrarMenuPrincipal();
                    break;
            }
        }

        public static string MenuCrud()
        {
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Visualizar");
            Console.WriteLine("3 - Editar");
            Console.WriteLine("4 - Excluir");
            Console.WriteLine("0 - Voltar");
            return Console.ReadLine();
        }

        public static void MostrarMenuPaciente(string mensagem = "")
        {
            Console.Clear();
            Console.WriteLine("Pacientes");
            Console.WriteLine(mensagem);
            switch (MenuCrud())
            {
                case "1":
                    PessoaModel.Create();
                    MostrarMenuPaciente("Paciente adicionado com sucesso!");
                    break;
                case "2":
                    PessoaModel.Read();
                    Console.WriteLine("Precione qualquer tecla para continuar");
                    Console.ReadLine();
                    MostrarMenuPaciente();
                    break;
                case "3":
                    PessoaModel.Update();
                    MostrarMenuPaciente("Paciente alterado com sucesso!");
                    break;
                case "4":
                    PessoaModel.Delete();
                    MostrarMenuPaciente("Paciente removido com sucesso!");
                    break;
                case "0":
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }
        }

        public static void MostrarMenuFuncionarios(string mensagem = "")
        {
            Console.Clear();
            Console.WriteLine("Funcionários");
            Console.WriteLine(mensagem);
            switch (MenuCrud())
            {
                case "1":
                    FuncionariosModel.Create();
                    MostrarMenuFuncionarios("Funcionário adicionado com sucesso!");
                    break;
                case "2":
                    PessoaModel.Read();
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadLine();
                    MostrarMenuFuncionarios();
                    break;
                case "3":
                    PessoaModel.Update();
                    MostrarMenuFuncionarios("Funcionário alterado com sucesso!");
                    break;
                case "4":
                    PessoaModel.Delete();
                    MostrarMenuFuncionarios("Funcionário removido com sucesso!");
                    break;
                case "0":
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }
        }

        public static void MostrarMenuMaterial(string mensagem = "")
        {
            Console.Clear();
            Console.WriteLine("Materiais");
            Console.WriteLine(mensagem);
            switch (MenuCrud())
            {
                case "1":
                    FuncionariosModel.Create();
                    MostrarMenuMaterial("Materiais adicionado com sucesso!");
                    break;
                case "2":
                    PessoaModel.Read();
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadLine();
                    MostrarMenuMaterial();
                    break;
                case "3":
                    PessoaModel.Update();
                    MostrarMenuMaterial("Materiais alterado com sucesso!");
                    break;
                case "4":
                    PessoaModel.Delete();
                    MostrarMenuMaterial("Materiais removido com sucesso!");
                    break;
                case "0":
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }
        }


        public static void MostrarMenuMedicamentos(string mensagem = "")
        {
            Console.Clear();
            Console.WriteLine("Medicamentos");
            Console.WriteLine(mensagem);
            switch (MenuCrud())
            {
                case "1":
                    MedicamentosModel.Create();
                    MostrarMenuMedicamentos("Medicamento adicionado com sucesso!");
                    break;
                case "2":
                    MedicamentosModel.Read();
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadLine();
                    MostrarMenuMedicamentos();
                    break;
                case "3":
                    MedicamentosModel.Update();
                    MostrarMenuMedicamentos("Medicamento alterado com sucesso!");
                    break;
                case "4":
                    MedicamentosModel.Delete();
                    MostrarMenuMedicamentos("Medicamento removido com sucesso!");
                    break;
                case "0":
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }
        }

        public static void MostrarMenuTriagem(string mensagem = "")
        {
            Console.Clear();
            Console.WriteLine("Triagem");
            Console.WriteLine(mensagem);
            switch (MenuCrud())
            {
                case "1":
                    TriagemModel.Create();
                    MostrarMenuTriagem("Triagem adicionado com sucesso!");
                    break;
                case "2":
                    TriagemModel.Read();
                    Console.WriteLine("Pressione qualquer tecla para continuar");
                    Console.ReadLine();
                    MostrarMenuTriagem();
                    break;
                case "3":
                    TriagemModel.Update();
                    MostrarMenuTriagem("Triagem alterado com sucesso!");
                    break;
                case "4":
                    TriagemModel.Delete();
                    MostrarMenuTriagem("Triagem removido com sucesso!");
                    break;
                case "0":
                    MostrarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }


        }

    }
}
  
