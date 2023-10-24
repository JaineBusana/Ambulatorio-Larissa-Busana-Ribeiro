using posto_de_saude.Entity;
using posto_de_saude.Helpers;
using posto_de_saude.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
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
=======
namespace posto_de_saude
{
    public class MedicamentosModel : DataBase, ICrud
    {
        private MedicamentoEntity Popular(MedicamentoEntity medicamento)
        {
           
            Console.WriteLine("Digite a dosagem do medicamento");
            medicamento.DOSAGEM = ChangeValue(medicamento.DOSAGEM);
            Console.WriteLine("Digite a via de administração do medicamento");
            medicamento.VIA_DE_ADMINISTRACAO = ChangeTipo(medicamento.VIA_DE_ADMINISTRACAO);
            return medicamento;
        }

        public void Create()
        {
            MedicamentoEntity medicamento = new MedicamentoEntity();
            medicamento = Popular(medicamento);
            string sql = "INSERT INTO PRODUTO VALUE (NULL, @DESCRICAO, @PRECO, @TIPO_ID)";
            int linhas = this.Execute(sql, medicamento);
            Console.WriteLine($"Produto inserido - {linhas} linhas afetadas");
        }
        public void Read()
        {

        }
        public void Update()
        {

        }
        public void Delete()
        {

        }


    }
}
>>>>>>> 16eed656d361794b471a5de78dc9cd7247b6d4c9
