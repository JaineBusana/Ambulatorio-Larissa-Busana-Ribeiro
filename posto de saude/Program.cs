using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text.Json.Serialization;

namespace posto_de_saude
{
    internal class Program
    {
        List<Funcionario> funcionarios = new List<Funcionario>();


    static void Main(string[] args)
    {
            //    Pessoa pessoas1 = new Pessoa();
            //    pessoas1.Idade = 20;
            //    pessoas1.Nome = "Thiago";
            //    pessoas1.Rua = "Rua João";
            //    Funcionario funcionario1 = new Funcionario("João", 20, "Rua Humaitá", "Técnico de Enfermagem", "Matutino", 1235);
            Menu.MostrarMenuPrincipal();
    }
    }
    // menu1: visualizar menu funcionario, visualizar menu produto, visualizar menu medicamento, visualizar menu triagem
    // menu funcionario: CRUD
}

   
    
        

    

