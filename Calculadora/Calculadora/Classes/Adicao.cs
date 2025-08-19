using Calculadora.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Classes
{
    internal class Adicao : IOperacao
    {
        public static void Executar(decimal num1, decimal num2)
        {
            decimal resultado = num1 + num2;

            Console.WriteLine($"O seu resultado da adição de {num1} e {num2} é {resultado}");

            Console.WriteLine("\n Aperte qualquer tecla para voltar");
            Console.ReadKey();
        }
    }
}
