<<<<<<< HEAD
﻿using posto_de_saude.Entity;
=======
﻿using Dapper;
using posto_de_saude.Entity;
>>>>>>> 16eed656d361794b471a5de78dc9cd7247b6d4c9
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
//    public class MaterialModel : DataBase, ICrud
//    {
//        private MaterialEntity Popular(MaterialEntity material)
//        {
//            Console.WriteLine("Digite o nome");
//            material.NOME = Console.ReadLine();
//            Console.WriteLine("Digite a quantidade de estoque:");
//            material.QUANTIDADE= Convert.ToInt32(Console.ReadLine());


//            return material;
//        }
//        public void Create()
//        {

//        }
//        public void Read()
//        {
           
//        }

//        public void Update()
//        {
          
            
//        }

//        public void Delete()
//        {
//        }
//    }
//}
=======
namespace posto_de_saude
{
    public class MaterialModel : DataBase ICrud
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            foreach (var material in ListMaterial())
            {
                Console.WriteLine($"{material.ID} - {material.NOME}-{material.QUANTIDADE}-{material.INDICACAO}-{material.VALIDADE}");
            }
        }
        private IEnumerable<MaterialEntity> ListMaterial()
        {
            string sql = "SELECT * FROM RESIDUO";
            return this.GetConnection().Query<MaterialEntity>(sql);
        }



        public void Update()
        {
            throw new NotImplementedException();
        }
    }
>>>>>>> 16eed656d361794b471a5de78dc9cd7247b6d4c9
