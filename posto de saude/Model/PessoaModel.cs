using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    public class PessoaModel
    {
        public List<Pessoa> pacientes = new List<Pessoa>();

        public void Create()
        {
            Pessoa paciente = new Pessoa();
            paciente.Popular();
            pacientes.Add(paciente);
        }

        public void Read()
        {
            for (int i = 0; i < pacientes.Count; i++)
            {
                Console.Write(i);
                pacientes[i].Listar();
            }
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
