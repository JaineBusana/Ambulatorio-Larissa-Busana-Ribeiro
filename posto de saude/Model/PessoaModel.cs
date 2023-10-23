using Dapper;
using posto_de_saude.Entity;
using posto_de_saude.Helpers;
using posto_de_saude.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace posto_de_saude
{
    public class PessoaModel: DataBase, ICrud
    {
        
        private PessoaEntity Popular(PessoaEntity pessoa)
        {
            Console.WriteLine("Informe o nome do paciente:");
            pessoa.NOME = Console.ReadLine();
            Console.WriteLine("Idade:");
            pessoa.IDADE = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Rua:");
            pessoa.RUA = Console.ReadLine();

            return pessoa;
        }
        public void Create()
        {
            PessoaEntity pessoa  = new PessoaEntity();
            pessoa = Popular(pessoa);
            string sql = "INSERT INTO PESSOA VALUE (NULL, @NOME, @IDADE, @RUA)";
            this.Execute(sql, pessoa);
        }
        private IEnumerable<PessoaEntity> ListaPessoaEntity()
        {
            string sql = "SELECT * FROM PESSOA";
            return this.GetConnection().Query<PessoaEntity>(sql);
        }
        public void Read()
        {
            foreach (var item in ListaPessoaEntity())
           Console.WriteLine($"Número de prontuário {pessoa.ID} \nNome:{pessoa.NOME}\nIdade:{pessoa.IDADE}\nRua:{pessoa.RUA}\n");
           
        }

        public void Update()
        {
            Read();
            Console.WriteLine("Digite o codigo do paciente a ser alterado:");
            int index = Convert.ToInt32(Console.ReadLine());
            pacientes[index].Popular();
        }

        public void Delete()
        {
            Read();
            Console.WriteLine("Digite o codigo do paciente a ser deletado:");
            int index = Convert.ToInt32(Console.ReadLine());
            pacientes.RemoveAt(index);
        }
    }
}
