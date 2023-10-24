using posto_de_saude.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace posto_de_saude
//{
//    public class MedicamentosModel: ICrud
//    {
    
//     private List<Medicamento> medicamentos = new List<Medicamento>();

//      public void Create()
//        {
//            Medicamento medicamento = new Medicamento();
//            medicamento.Popular();
//            medicamentos.Add(medicamento);
//        }

//        public void Read()
//        {
//            for (int i = 0; i < medicamentos.Count; i++)
//            {
//                Console.Write(i);
//                medicamentos[i].Listar();
//            }
//        }

//        public void Update()
//        {
//            Read();
//            Console.WriteLine("Digite o código do medicamento a ser alterado:");
//            int index = Convert.ToInt32(Console.ReadLine());
//            medicamentos[index].Popular();
//        }

//        public void Delete()
//        {
//            Read();
//            Console.WriteLine("Digite o código do medicamento a ser deletado:");
//            int index = Convert.ToInt32(Console.ReadLine());
//            medicamentos.RemoveAt(index);
//        }

//    }
//}
