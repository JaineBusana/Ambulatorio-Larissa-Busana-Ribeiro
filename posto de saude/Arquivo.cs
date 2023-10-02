using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace posto_de_saude
{
    internal class Arquivo
    {
        //static List<string> VerificarArquivoPaciente(List<string> listaPacientes)
        //{
        //    List<string> listaPacientes = new List<string>();
        //    if (File.Exists("pacientes.json"))
        //    {
        //        string arquivo = File.ReadAllText("pacientes.json");
        //        listaPacientes = JsonSerializer.Deserialize<List<string>>(arquivo);
        //    }
        //    else
        //    {
        //        List<string> listaPacientes = new List<string>();
        //        string arquivo = JsonSerializer.Serialize(listaPacientes);
        //        File.WriteAllText("itens.json", arquivo);
        //    }
        //    return listaPacientes;
        //}

    }
}
