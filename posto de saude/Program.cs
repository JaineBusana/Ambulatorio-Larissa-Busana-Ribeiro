using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text.Json.Serialization;

namespace posto_de_saude
{
    internal class Program
    {
        // menu1: visualizar menu funcionario, visualizar menu produto, visualizar menu medicamento, visualizar menu triagem
        // menu funcionario: CRUD

        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            return funcionarios;
        }
        static void Main(string[] args)
        {
        //    Pessoa pessoas1 = new Pessoa();
        //    pessoas1.Idade = 20;
        //    pessoas1.Nome = "Thiago";
        //    pessoas1.Rua = "Rua João";
        //    Funcionario funcionario1 = new Funcionario("João", 20, "Rua Humaitá", "Técnico de Enfermagem", "Matutino", 1235);


            Menu.MenuCrud();
        public static void MostrarMenuMedicamentos(string mensagem = "")
        {
            Console.Clear();
            Console.WriteLine("Medicamentos");
            Console.WriteLine(mensagem);
            Console.WriteLine();
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
                    MostrarMenuMedicamentos();
                    break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;

            }
        }




    }









    }
}