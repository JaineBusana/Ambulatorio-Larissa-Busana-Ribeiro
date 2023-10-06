using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    internal class TriagemModel
    {
        private List<Triagem> triagem = new List<Triagem>();


        public void Create()
        {
            Triagem cadastro = new Triagem();
            cadastro.Popular();
            triagem.Add(cadastro);   
        }
        public void Read()
        {
            for (int i = 0; i < triagem.Count; i++)
            {
                Console.WriteLine(i);
                triagem[i].Listar();
            }
        }
        public void Update()
        {
            Read();
            Console.WriteLine("Digite o codigo do item a ser alterado");
            int index = Convert.ToInt32(Console.ReadLine());
            triagem[index].Popular();
        }

        public void Delete()
        {
            Read();
            Console.WriteLine("Digite o codigo do item a ser deletado");
            int index = Convert.ToInt32(Console.ReadLine());
            triagem.RemoveAt(index);
        }

    }
}
