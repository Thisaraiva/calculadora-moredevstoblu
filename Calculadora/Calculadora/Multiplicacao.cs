using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Multiplicacao 
    {

        public static void Executar(decimal num1, decimal num2)
        {

            decimal resultado = num1*num2;

            Console.WriteLine($"O seu Resultado da Multiplicação de {num1} e {num2} é {resultado}");

        }

    }
}
