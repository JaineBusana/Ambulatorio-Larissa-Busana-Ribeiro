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
        //jsjs
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
            foreach (var pessoa in ListaPessoaEntity())
            {
           Console.WriteLine($"Número de prontuário {pessoa.ID}\nNome:{pessoa.NOME}\nIdade:{pessoa.IDADE}\nRua:{pessoa.RUA}\n");

            }      
        }
        private int PegarProntuario()
        {
            Read();
            Console.WriteLine("Digite o número do prontuário que deseja realizar alterações:");
            return Convert.ToInt32(Console.ReadLine());
        }

        public PessoaEntity PegarId(int id = 0)
        {
            if (id == 0)
            {
                id =PegarProntuario();
            }
            return ListaPessoaEntity().Where(p => p.ID == id).ToList()[0];
        }

        //private static void UpdatePessoaNome(PessoaEntity pessoa)
        //{
        //    Console.WriteLine($"Digite o novo nome para {pessoa.NOME}");
        //    pessoa.NOME = Console.ReadLine();
        //}
        //private static void UpdatePessoaIdade(PessoaEntity pessoa)
        //{
        //    Console.WriteLine($"Digite a nova idade para {pessoa.IDADE}");
        //    pessoa.IDADE = Convert.ToInt32(Console.ReadLine());
        //}
        //private static void UpdatePessoaRua(PessoaEntity pessoa)
        //{
        //    Console.WriteLine($"Digite a nova rua para {pessoa.RUA}");
        //    pessoa.RUA = Console.ReadLine();
        //}

        //public void Update()
        //{

        //}

        public void Delete()
        {
            Read();
           
        }
    }
}
