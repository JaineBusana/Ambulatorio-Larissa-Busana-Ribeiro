using System.Text.Json.Serialization;

namespace posto_de_saude
{
    internal class Program
    {
        // menu1: visualizar menu funcionario, visualizar menu produto, visualizar menu medicamento, visualizar menu triagem
        // menu funcionario: CRUD
        //


        static void Main(string[] args)
        {
            Pessoa pessoas1 = new Pessoa();
            pessoas1.Idade = 20;
            pessoas1.Nome = "Thiago";
            pessoas1.Rua = "Rua João";

            Funcionario funcionario1 = new Funcionario("João", 20, "Rua Humaitá", "Técnico de Enfermagem", "Matutino", 1235);

            Menu menu = new Menu();
            switch (menu.MenuPrinciapal())
            {
                case 1:
                    Console.Clear();
                    Menu menuPessoa = new Menu();
                    switch (menuPessoa.MenuPessoa())
                    {
                        case 1:
                            Console.Clear();
                            Cadastro cadastroPessoa = new Cadastro();
                            cadastroPessoa.CadastroPessoa();
                            break;
                    }
                    break;
                case 2:
                    Console.Clear();
                    Menu menuFuncionario = new Menu();
                    switch (menuFuncionario.MenuFuncionario())
                    {
                        case 1:
                            Console.Clear();
                            Cadastro cadastroFuncionario = new Cadastro();
                            cadastroFuncionario.CadastroFuncionario();
                            break;
                    }
                    break;
                case 3:
                    Console.Clear();
                    Menu menuMaterial = new Menu();
                    switch (menuMaterial.MenuMaterial())
                    {
                        case 1:
                            Console.Clear();
                            Cadastro cadastroMaterial = new Cadastro();
                            cadastroMaterial.CadastroMaterial();
                            break;
                    }
                    break;
                    case 4:
                    Console.Clear();
                    Menu menuMedicamento = new Menu();
                    switch (menuMedicamento.MenuMedicamento())
                    {
                        case 1:
                            Console.Clear();
                            Cadastro cadastroMedicamento = new Cadastro();
                            cadastroMedicamento.CadastroMedicamento();
                            break;
                    }
                    break;
                    case 5:
                    Console.Clear();
                    Menu menuTriagem = new Menu();
                    switch (menuTriagem.MenuTriagem())
                    {
                        case 1:
                            Console.Clear();
                            Cadastro cadastroTriagem = new Cadastro();
                            cadastroTriagem.CadastroTriagem();
                            break;
                    }
                    break;
                    case 0:
                    Console.WriteLine("Falow");
                    break;
            }

        }
    }
}