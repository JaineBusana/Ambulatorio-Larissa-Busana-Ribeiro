using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace posto_de_saude
{
    internal class Triagem 
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

        public Triagem(Pessoa paciente, double peso, double pressao, double altura, double temperatura, double saturacao, string sintoma)
        {
            this.paciente = paciente;
            this.Peso = peso;
            this.Pressao = pressao;
            this.Altura = altura;
            this.Temperatura = temperatura;
            this.Saturacao = saturacao;
            this.Sintoma = sintoma;
        }
    }

public void Popular()
    {
        console.writeline("informe o nome do paciente:");
        // vai ter que buscar o arquivo de pacientes
        string paciente = console.readline();
        console.writeline("informe o peso do paciente:");
        int peso = convert.toint32(console.readline());
        console.writeline("pressão arterial:");
        int pressao = convert.toint32(console.readline());
        console.writeline("altura:");
        int altura = convert.toint32(console.readline());
        console.writeline("temperatura:");
        int temperatura = convert.toint32(console.readline());
        console.writeline("saturação:");
        int saturacao = convert.toint32(console.readline());
        console.writeline("quais os sintomas do paciente:");
        string sintomas = console.readline();

    }
    {
       
    
}
