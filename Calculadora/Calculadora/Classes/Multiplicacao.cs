using Calculadora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    internal class Multiplicacao : IOperacao
    {

        public static void Executar(decimal num1, decimal num2)
        {

            decimal resultado = num1*num2;

            Console.WriteLine($"O seu resultado da multiplicação de {num1} e {num2} é {resultado}");

            Console.WriteLine("\n Aperte qualquer tecla para voltar");
            Console.ReadKey();

        }

    }
}
