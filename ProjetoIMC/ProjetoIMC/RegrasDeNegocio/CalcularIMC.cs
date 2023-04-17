using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIMC.RegrasDeNegocio
{
    internal class CalcularIMC
    {
        public double Peso { get; set; }
        public double Altura { get; set; } //em metros
        public double Indice { get; set; }

        public void ClassCalcularIMC()
        {
            Indice = Peso / (Altura * Altura);

        }
        public string Classificassao()
        {
            string situacao = "";
            /*if (Indice < 18.5) //situacao = "Magreza";
            {
                situacao = "Magreza";
            }
            if (Indice > 18.5 && Indice < 24.9)//situacao = "Normal";//Exemplo do profesor
            {
                situacao = "Normal";
            }*/
            if (Indice > 40) //situacao = "Obesidade";
            {
                situacao = "Obesidade de Grau III";
            }
            else if (Indice > 35)
            {
                situacao = "Obesidade de Grau II";
            }
            else if (Indice > 30)
            {
                situacao = "Obesidade de Grau I";
            }
            else if (Indice > 25)
            {
                situacao = "Sobrepeso";
            }
            else if (Indice >= 18.5)
            {
                situacao = "Normal";
            }
            else
            {
                situacao = "Magreza";
            }
            return situacao;
        }


    }

}
