using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace posto_de_saude
{
    public class Triagem 
    {
        public PessoaModel pessoaModel; 
        public Pessoa paciente; 
        private double perimetroCefalico;

        public double PerimetroCefalico 
        { 
            get
            {
                return perimetroCefalico;
            }
            set
            {
                if (paciente.Idade < 1)
                {
                    if (perimetroCefalico <= 0)
                    {
                        throw new ArgumentException("Precisa informar um valor de Perimetro Cefálico!");
                    }
                    else
                    {
                    perimetroCefalico = value;
                    }
                }
            }
        }

       
        public void Popular()
        {
            //Console.WriteLine("informe o nome do paciente:");
            //string nomePaciente = Console.ReadLine();
            //int indice = pessoaModel.pacientes.IndexOf(nomePaciente);
            
            //// vai ter que buscar o arquivo de pacientes
            //paciente.nome = Console.ReadLine();
            Console.WriteLine("informe o peso do paciente:");
            Peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pressão arterial:");
            Pressao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("altura:");
            Altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("temperatura:");
            Temperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("saturação:");
            Saturacao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("quais os sintomas do paciente:");
            Sintoma = Console.ReadLine();

        }

        public void Listar()
        {
            Console.WriteLine($" Paciente: {paciente.nome} \n Peso:{Peso} \n Pressão:{Pressao}" +
                $" \n Altura:{Altura} \n Temperatura:{Temperatura} \n Saturação:{Saturacao} \n Sintomas:{Sintoma} ");
        }
    }


    
       
    
}
