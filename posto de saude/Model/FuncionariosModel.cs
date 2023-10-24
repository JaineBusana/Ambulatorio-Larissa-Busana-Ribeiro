using Dapper;
using posto_de_saude.Entity;
using posto_de_saude.Helpers;
using posto_de_saude.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace posto_de_saude
//{
//    public class FuncionariosModel:DataBase, ICrud
//    {
     
//        private FuncionarioEntity Popular(FuncionarioEntity funcionario)
//        {
//            Console.WriteLine("Qual seu turno?");
//            funcionario.TURNO = Console.ReadLine();
//            Console.WriteLine("Qual seu cargo?");
//            funcionario.CARGO = Console.ReadLine();


//            return funcionario;
//        }

//        public void Create()
//        {
//            Funcionario funcionario = new Funcionario();
//            funcionario.Popular();
//            string sql = "INSERT INTO FUNCIONARIO VALUE (NULL, @CARGO, @TURNO, @ @PESSOA_ID)";
//            int linhas = this.Execute(sql, funcionario);
//            Console.WriteLine($"Funcionário inserido com sucesso!");

//        }

//        private IEnumerable<FuncionarioEntity> ListFuncionarioEntity()
//        { 
//            string sql = "SELECT * FROM FUNCIONARIO F JOIN PESSOA P ON P.ID = F.PESSOA_ID";
//            return this.GetConnection().Query<FuncionarioEntity>(sql);
//        }

//        public void Read()
//        {
//            foreach (var funcionario in ListFuncionarioEntity())
//            {
//                Console.Write($"Id: {funcionario.ID} - Turno: {funcionario.TURNO}- Cargo: {funcionario.CARGO}" +
//                    $"- Nome:{funcionario.PESSOA.NOME}- Idade:{funcionario.PESSOA.IDADE}- Rua:{funcionario.PESSOA.RUA}");
                
//            }
//        }

//        private FuncionarioEntity GetById()
//        {
//            return ListFuncionarioEntity().Where(f => f.ID == GetIndex()).ToList()[0];
//        }
//        public void Update()
//        {
//            FuncionarioEntity funcionario = Popular(GetById());
//            string sql = "UPDATE FUNCIONARIO SET CARGO = @CARGO, TURNO = @TURNO, PESSOA_ID = @PESSOA_ID WHERE ID = @ID";
//            int linhas = this.Execute(sql, funcionario);
//            Console.WriteLine($" Foi atualizado o funcionário");
//        }

//        private int GetIndex()
//        {
//            Read();
//            Console.WriteLine("Digite o ID que deseja alterar:");
//            return Convert.ToInt32(Console.ReadLine());
//        }
//        public void Delete()
//        {
//            var parametro = new { ID = GetIndex() };
//            string sql = "DELETE FROM FUNCIONARIO WHERE ID = @ID";
//            this.Execute(sql, parametro);
//            Console.WriteLine("Funcionário deletado com sucesso");
//        }
//    }
//}
