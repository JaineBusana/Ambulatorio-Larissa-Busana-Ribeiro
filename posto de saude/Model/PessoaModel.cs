<<<<<<< HEAD
﻿using Dapper;
using posto_de_saude.Entity;
using posto_de_saude.Helpers;
using posto_de_saude.Model;
using System;
=======
﻿using posto_de_saude.Entity;
using posto_de_saude.Helpers;
using posto_de_saude.Model;
using System;
using Dapper;
>>>>>>> 16eed656d361794b471a5de78dc9cd7247b6d4c9
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace posto_de_saude
{
<<<<<<< HEAD
    public class PessoaModel: DataBase, ICrud
    {
       
        private PessoaEntity Popular(PessoaEntity pessoa)
        {
            Console.WriteLine("Informe o nome do paciente:");
            pessoa.NOME = Util.MudarInformacoes(pessoa.NOME);
            Console.WriteLine("Idade:");
            pessoa.IDADE = Util.MudarInformacoes(pessoa.IDADE);
            Console.WriteLine("Rua:");
            pessoa.RUA = Util.MudarInformacoes(pessoa.RUA);

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
            Console.WriteLine("Digite o número do prontuário:");
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

        public void Update()
        {
            PessoaEntity pessoa = Popular(PegarId());
            string sql = "UPDATE PESSOA SET NOME=@NOME, IDADE=@IDADE, RUA=@RUA";
            int executar=this.Execute(sql,pessoa);
            Console.WriteLine("Atualizado!!");
=======
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
>>>>>>> 16eed656d361794b471a5de78dc9cd7247b6d4c9
        }

   
        public void Delete()
        {
<<<<<<< HEAD
            var parameters = new { ID = PegarProntuario() };
            string sql = "DELETE FROM PESSOA WHERE ID = @ID";
            this.Execute(sql,parameters);
            Console.WriteLine("Deletado!!");

=======
            throw new NotImplementedException();
>>>>>>> 16eed656d361794b471a5de78dc9cd7247b6d4c9
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
