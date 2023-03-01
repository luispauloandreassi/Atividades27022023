using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Calcular
    {
        public double Somar(String num1, String num2)
        {
            return Convert.ToDouble(num1) + Convert.ToDouble(num2);
        }


        public double Subtrair (String num1, String num2)
        {
            return Convert.ToDouble(num1) - Convert.ToDouble(num2);
        }

        public double Multiplicar(String num1, String num2)
        {
            return Convert.ToDouble(num1) * Convert.ToDouble(num2);
        }

        public double Dividir(String num1, String num2)
        {
            return Convert.ToDouble(num1) / Convert.ToDouble(num2);
        }


    }
}

   

