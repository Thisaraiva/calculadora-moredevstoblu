using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Utils
{
    public static class Validador
    {
        public static decimal LerNumero(string mensagem)
        {
            decimal valor;
            Console.Write(mensagem);

            while (!decimal.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Entrada inválida. Tente novamente: ");
            }

            return valor;
        }
    }
}
