﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posto_de_saude
{
    public class MaterialModel
    {
        private List<Material> materiais = new List<Material>();

        public void Create()
        {
            Material material = new Material();
            material.Popular();
            materiais.Add(material);
        }

        public void Read()
        {
            for (int i = 0; i < materiais.Count; i++)
            {
                Console.Write(i);
                materiais[i].Listar();
            }
        }

        public void Update()
        {
            Read();
            Console.WriteLine("Digite o codigo do item a ser alterado:");
            int index = Convert.ToInt32(Console.ReadLine());
            materiais[index].Popular();
        }

        public void Delete()
        {
            Read();
            Console.WriteLine("Digite o codigo do item a ser deletado:");
            int index = Convert.ToInt32(Console.ReadLine());
            materiais.RemoveAt(index);
        }
    }
}
