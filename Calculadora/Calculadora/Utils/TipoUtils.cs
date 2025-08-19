using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Utils
{

    public static class TipoUtils
    {
        public static void AguardarEntrada()
        {
            Console.Write("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public static void LimparTela()
        {
            Console.Clear();
        }

        public static decimal InteragirEntradaDecimal(string mensagem)
        {
            decimal resultado;
            Console.Write(mensagem);

            while (!decimal.TryParse(Console.ReadLine(), out resultado))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                Console.Write(mensagem);
            }
            return resultado;
        }

        public static int InteragirEntradaInt(string mensagem)
        {
            int resultado;
            Console.Write(mensagem);

            while (!int.TryParse(Console.ReadLine(), out resultado))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                Console.Write(mensagem);
            }
            return resultado;
        }

        public static decimal InteragirEntradaDivisao(string mensagem)
        {
            decimal resultado;
            Console.Write(mensagem);

            while (!decimal.TryParse(Console.ReadLine(), out resultado) || resultado == 0)
            {
                if (resultado == 0)
                {
                    Console.WriteLine("Erro: O divisor não pode ser zero. Por favor, digite um número diferente de zero.");
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                }
                Console.Write(mensagem);
            }
            return resultado;
        }
    }
}

