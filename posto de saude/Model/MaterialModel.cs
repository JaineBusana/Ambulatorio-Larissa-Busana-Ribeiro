using Dapper;
using posto_de_saude.Entity;
using posto_de_saude.Helpers;
using posto_de_saude.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
