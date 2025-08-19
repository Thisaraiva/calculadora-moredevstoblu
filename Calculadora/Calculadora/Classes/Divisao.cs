using Calculadora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    public class Divisao : IOperacao
    {
        public decimal Calcular(decimal num1, decimal num2)
        {
            while (num2 == 0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");

            }
            return num1 / num2;
        }
    }
}
