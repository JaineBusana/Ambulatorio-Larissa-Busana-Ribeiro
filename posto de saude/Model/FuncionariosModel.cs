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
        private List<Funcionario> funcionarios = new List<Funcionario>();

        public void Create()
        {
            FuncionarioEntity funcionario = new FuncionarioEntity();
            funcionario = Popular(funcionario);
            string sql = "INSERT INTO PRODUTO VALUE (NULL, @CARGO, @TURNO, @PESSOA_ID)";
            this.Execute(sql, funcionario);
            Console.WriteLine("Funcionario criado com sucesso!");
        }

        public FuncionarioEntity Popular(FuncionarioEntity funcionario)
        {
            Console.WriteLine("Digite o cargo do funcioário");
            funcionario.CARGO = Console.ReadLine();
            Console.WriteLine("Digite o turno");
            funcionario.TURNO = Console.ReadLine();
            funcionario.PESSOA_ID = AlterarPessoa(funcionario);

            return funcionario;
        }

        private int AlterarPessoa(FuncionarioEntity funcionario)
        {
            PessoaModel pessoaModel = new PessoaModel();
            pessoaModel.Read();
            Console.WriteLine("Digite o ID da pessoa");
            funcionario.PESSOA_ID = Convert.ToInt32(Console.ReadLine());

            return funcionario.PESSOA_ID;
        }

        public void Read()
        {
            foreach (var funcionario in ListFuncionarioEntity())
            {
                Console.WriteLine($"{funcionario.ID} - {funcionario.PESSOA.NOME} - Idade:{funcionario.PESSOA.IDADE} - Cargo:{funcionario.CARGO} - Turno:{funcionario.TURNO}");
            }
        }

        private IEnumerable<FuncionarioEntity> ListFuncionarioEntity()
        {
            string sql = "SELECT * FROM FUNCIONARIO F JOIN PESSOA P ON P.ID = F.PESSOA_ID";
            return this.GetConnection().Query<FuncionarioEntity, PessoaEntity, FuncionarioEntity>(
                sql,
                (funcionario, pessoa) =>
                {
                    funcionario.PESSOA = pessoa;
                    return funcionario;
                }
                );
        }

        public void Update()
        {
            FuncionarioEntity funcionario = Popular(GetById());
            string sql = "UPDATE FUNCIONARIO SET CARGO = @CARGO, TURNO = @TURNO, PESSOA_ID = @PESSOA_ID WHERE ID = @ID";
            this.Execute(sql, funcionario);
            Console.WriteLine($"Funcionário atualizado com sucesso!");
        }

        private int GetIndex()
        {
            Read();
            Console.WriteLine($"Digite o ID para continuar");
            return Convert.ToInt32(Console.ReadLine());
        }

        public FuncionarioEntity GetById(int id = 0)
        {
            if (id == 0)
            {
                id = GetIndex();
            }
            return ListFuncionarioEntity().Where(o => o.ID == id).ToList()[0];
            
        }

        public void Delete()
        {
            Read();
            var parametros = new { ID = GetIndex() };
            string sql = "DELETE FROM FUNCIONARIO WHERE ID = @ID";
            this.Execute(sql, parametros);
            Console.WriteLine("Funcionario excluido com sucesso!");
        }
    }
}
