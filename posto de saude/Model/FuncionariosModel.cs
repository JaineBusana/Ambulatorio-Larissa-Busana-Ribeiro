using posto_de_saude.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    public class FuncionariosModel :ICrud
    {
        private List<Funcionario> funcionarios = new List<Funcionario>();

        public void Create()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Popular();
            funcionarios.Add(funcionario);
        }

        public void Read()
        {
            for (int i = 0; i < funcionarios.Count; i++)
            {
                Console.Write(i);
                funcionarios[i].Listar();
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
