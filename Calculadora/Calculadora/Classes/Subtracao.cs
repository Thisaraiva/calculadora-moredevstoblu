using Calculadora.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    internal class Subtracao : IOperacao
    {
        public static void Executar(decimal num1, decimal num2)
        {
            decimal resultado = num1 - num2;

            Console.WriteLine($"O seu resultado da subtração de {num1} e {num2} é {resultado}");

        }
    }
}
