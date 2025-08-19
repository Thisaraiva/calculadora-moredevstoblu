using Calculadora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    internal class Divisao : IOperacao
    {
        public static void Executar(decimal num1, decimal num2)
        {
            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("Impossivel Dividir por 0");
            }
            else {
                decimal resultado = num1 / num2;
                Console.WriteLine($"O seu Resultado da divisão de {num1} e {num2} é {resultado}");
            };

            

        }
    }
}
