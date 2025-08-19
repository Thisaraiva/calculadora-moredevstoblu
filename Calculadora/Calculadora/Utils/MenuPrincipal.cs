using Calculadora.Classes;
using Calculadora.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculadora.Utils
{
    public class MenuPrincipal
    {
        public static void Executar()
        {
            bool continuar = true;
            do
            {
                MostrarTelaCalculadora();
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Adicao.Executar(num1, num2);
                        break;
                    case "2":
                        Subtracao.Executar(num1, num2);
                        break;
                    case "3":
                        Multiplicacao.Executar(num1, num2);
                        break;
                    case "4":
                        Divisao.Executar(num1, num2);
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Encerrando...");
                        Thread.Sleep(1000);
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        Thread.Sleep(1000);
                        break;
                }
            } while (continuar);
        }

        public static void MostrarTelaCalculadora()
        {
            Console.Title = "Calculadora GitHub";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();

            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║       CALCULADORA GITHUB          ║");
            Console.WriteLine("╠═══════════════════════════════════╣");
            Console.WriteLine("║ Escolha uma operação:             ║");
            Console.WriteLine("║                                   ║");
            Console.WriteLine("║  [1] Soma                         ║");
            Console.WriteLine("║  [2] Subtração                    ║");
            Console.WriteLine("║  [3] Multiplicação                ║");
            Console.WriteLine("║  [4] Divisão                      ║");
            Console.WriteLine("║  [0] Sair                         ║");
            Console.WriteLine("║                                   ║");
            Console.WriteLine("╚═══════════════════════════════════╝");
            Console.Write("Digite a opção desejada: ");
        }

        public static (decimal, decimal) SolicitarNumeros()
        {
            Console.Clear();
            decimal num1 = Validador.LerNumero("Digite o primeiro número: ");
            decimal num2 = Validador.LerNumero("Digite o segundo número: ");
            return (num1, num2);
        }
    }
}
