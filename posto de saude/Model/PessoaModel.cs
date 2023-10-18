using posto_de_saude.Entity;
using posto_de_saude.Helpers;
using posto_de_saude.Model;
using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace posto_de_saude
{
    public class PessoaModel : DataBase, ICrud
    {
        public void Create()
        {
           PessoaEntity pessoa = new PessoaEntity();
           pessoa = Popular(pessoa);
            string sql = "INSERT INTO PESSOA VALUE (NULL, @NOME, @IDADE, @RUA)";
            int linhas = this.Execute(sql, pessoa);
            Console.WriteLine($"Cadastro concluido - {linhas} linhas afetadas.");
        }

        private PessoaEntity Popular(PessoaEntity pessoa)
        {
            Console.WriteLine("Informe o nome:");
            pessoa.NOME = Console.ReadLine();
            Console.WriteLine("Idade:");
            pessoa.IDADE = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rua:");
            pessoa.RUA = Console.ReadLine();
            return pessoa;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            foreach (var pessoa in ListPessoaEntity())
            {
                Console.WriteLine($"Cod:{pessoa.ID} - Nome: {pessoa.NOME} - Idade: {pessoa.IDADE} - Rua: {pessoa.RUA}");
            }
        }

        private IEnumerable<PessoaEntity> ListPessoaEntity()
        {
            string sql = "SELECT * FROM PESSOA";
            return this.GetConnection().Query<PessoaEntity>(sql);
        }

        public void Update()
        {
            throw new NotImplementedException();
        }








        //public List<Pessoa> pacientes = new List<Pessoa>();

        //public void Create()
        //{
        //    Pessoa paciente = new Pessoa();
        //    paciente.Popular();
        //    pacientes.Add(paciente);
        //}

        //public void Read()
        //{
        //    for (int i = 0; i < pacientes.Count; i++)
        //    {
        //        Console.Write(i);
        //        pacientes[i].Listar();
        //    }
        //}

        //public void Update()
        //{
        //    Read();
        //    Console.WriteLine("Digite o codigo do paciente a ser alterado:");
        //    int index = Convert.ToInt32(Console.ReadLine());
        //    pacientes[index].Popular();
        //}

        //public void Delete()
        //{
        //    Read();
        //    Console.WriteLine("Digite o codigo do paciente a ser deletado:");
        //    int index = Convert.ToInt32(Console.ReadLine());
        //    pacientes.RemoveAt(index);
        //}
    }
}
