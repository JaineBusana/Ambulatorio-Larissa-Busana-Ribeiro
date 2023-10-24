using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text.Json.Serialization;
using posto_de_saude.Helpers;

namespace posto_de_saude
{
    internal class Program
    {

        static void Main(string[] args)
        {
            PessoaModel model = new PessoaModel();
            model.Create();
            Console.Clear();
            model.Read();
            Console.Clear();
            model.Update();
            Console.Clear();
            model.Delete();

        }
    }
}

   
    
        

    

