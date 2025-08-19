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
        // O dicionário agora está pronto para ser inicializado com as classes.
        private static Dictionary<int, IOperacao> _operacoes = new Dictionary<int, IOperacao>()
        {
            { 1, new Soma() },
            { 2, new Subtracao() },
            { 3, new Multiplicacao() },
            { 4, new Divisao() }
        };

        public static void Executar()
        {
            bool continuar = true;
            do
            {
                MostrarTelaCalculadora();
                int opcao = TipoUtils.InteragirEntradaInt("Digite a opção desejada: ");

                if (_operacoes.ContainsKey(opcao))
                {
                    TipoUtils.LimparTela();

                    decimal num1 = TipoUtils.InteragirEntradaDecimal("Digite o primeiro número: ");
                    decimal num2;

                    if (opcao == 4)
                    {
                        num2 = TipoUtils.InteragirEntradaDivisao("Digite o segundo número: ");
                    }
                    else
                    {
                        num2 = TipoUtils.InteragirEntradaDecimal("Digite o segundo número: ");
                    }

                    IOperacao operacao = _operacoes[opcao];
                    decimal resultado = operacao.Calcular(num1, num2);

                    Console.WriteLine($"O resultado da operação é: {resultado}");

                    TipoUtils.AguardarEntrada();
                }
                else if (opcao == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Encerrando...");
                    Thread.Sleep(1000);
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                    Thread.Sleep(1000);
                }
            } while (continuar);
        }

        public static void MostrarTelaCalculadora()
        {
            Console.Title = "Calculadora GitHub";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();

            Console.WriteLine("╔═══════════════════════════════════╗");
            Console.WriteLine("║        CALCULADORA GITHUB         ║");
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
    }
}
