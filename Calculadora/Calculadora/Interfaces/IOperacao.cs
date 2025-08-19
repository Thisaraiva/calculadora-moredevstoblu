using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Interfaces
{
    internal interface IOperacao
    {
        public decimal Calcular(decimal num1, decimal num2);
    }
}
