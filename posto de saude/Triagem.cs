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
        public Pessoa paciente; 
        private double perimetroCefalico;

        public double Peso { get; set; }
        public double Pressao { get; set; }
        public double Altura { get; set; }
        public double Temperatura { get; set; }
        public double Saturacao { get; set; }
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
        public string Sintoma { get; set; }

       
        public void Popular()
        {
            Console.WriteLine("informe o nome do paciente:");
            // vai ter que buscar o arquivo de pacientes
            string paciente = Console.ReadLine();
            Console.WriteLine("informe o peso do paciente:");
            int peso = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pressão arterial:");
            int pressao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("altura:");
            int altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("temperatura:");
            int temperatura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("saturação:");
            int saturacao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("quais os sintomas do paciente:");
            string sintomas = Console.ReadLine();

        }

        public void Listar()
        {
            Console.WriteLine($" Paciente: {paciente} \n Peso:{Peso} \n Pressão:{Pressao}" +
                $" \n Altura:{Altura} \n Temperatura:{Temperatura} \n Saturação:{Saturacao} \n Sintomas:{Sintoma} ");
        }
    }


    
       
    
}
