using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text.Json.Serialization;
using posto_de_saude.Helpers;

namespace posto_de_saude
{
    internal class Program
    {
<<<<<<< HEAD

        static void Main(string[] args)
        {
            PessoaModel model = new PessoaModel();
            model.Create();
            Console.Clear();
            model.Read();
            Console.Clear();
            model.Update();
            Console.Clear();
            model.Delete();

        }
=======
        

    static void Main(string[] args)
    {
            //    Pessoa pessoas1 = new Pessoa();
            //    pessoas1.Idade = 20;
            //    pessoas1.Nome = "Thiago";
            //    pessoas1.Rua = "Rua João";
            //    Funcionario funcionario1 = new Funcionario("João", 20, "Rua Humaitá", "Técnico de Enfermagem", "Matutino", 1235);
            //Menu.MostrarMenuPrincipal();

            PessoaModel pessoa = new PessoaModel();
            pessoa.Create();
            pessoa.Read();

>>>>>>> 16eed656d361794b471a5de78dc9cd7247b6d4c9
    }
}

   
    
        

    

