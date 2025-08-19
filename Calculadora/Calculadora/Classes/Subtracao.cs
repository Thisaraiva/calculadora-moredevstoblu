using Calculadora.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    public class Subtracao : IOperacao
    {
        public decimal Calcular(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
    }
}
