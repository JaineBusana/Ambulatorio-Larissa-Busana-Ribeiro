using Dapper;
using posto_de_saude.Entity;
using posto_de_saude.Helpers;
using posto_de_saude.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    public class FuncionariosModel:DataBase, ICrud
    {
     
        private FuncionarioEntity Popular(FuncionarioEntity funcionario)
        {
            Console.WriteLine("Qual seu turno?");
            funcionario.TURNO = Console.ReadLine();
            Console.WriteLine("Qual seu cargo?");
            funcionario.CARGO = Console.ReadLine();


            return funcionario;
        }

        public void Create()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Popular();
            string sql = "INSERT INTO FUNCIONARIO VALUE (NULL, @CARGO, @TURNO, @ @PESSOA_ID)";
            int linhas = this.Execute(sql, funcionario);
            Console.WriteLine($"Funcionário inserido com sucesso!");

        }

        private IEnumerable<FuncionarioEntity> ListFuncionarioEntity()
        { 
            string sql = "SELECT * FROM FUNCIONARIO F JOIN PESSOA P ON P.ID = F.PESSOA_ID";
            return this.GetConnection().Query<FuncionarioEntity>(sql);
        }

        public void Read()
        {
            foreach (var funcionario in funcionarios)
            {
                Console.Write($"Id: {funcionario.ID} - Turno: {funcionario.TURNO}- Cargo: {funcionario.CARGO}" +
                    $"- Nome:{funcionario.PESSOA.NOME}- Idade:{funcionario.PESSOA.IDADE}- Rua:{funcionario.PESSOA.RUA}");
                
            }
        }

        public void Update()
        {
            Read();
            Console.WriteLine("Digite o codigo do funcionário a ser alterado:");
            int index = Convert.ToInt32(Console.ReadLine());
            funcionarios[index].Popular();
        }

        public void Delete()
        {
            Read();
            Console.WriteLine("Digite o codigo do funcionário a ser deletado:");
            int index = Convert.ToInt32(Console.ReadLine());
            funcionarios.RemoveAt(index);
        }
    }
}
