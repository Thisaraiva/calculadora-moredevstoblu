using Calculadora.Classes;
using Calculadora.Interfaces;


namespace Calculadora.Utils
{
    public class MenuPrincipal
    {
        // O dicionário mapeia as opções do menu para as classes de operação.
        private static readonly Dictionary<int, IOperacao> _operacoes = new Dictionary<int, IOperacao>()
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
                    string nomeOperacao = "";
                    switch (opcao)
                    {
                        case 1: nomeOperacao = "soma"; break;
                        case 2: nomeOperacao = "subtração"; break;
                        case 3: nomeOperacao = "multiplicação"; break;
                        case 4: nomeOperacao = "divisão"; break;
                    }

                    Console.WriteLine($"O resultado da {nomeOperacao} é: {resultado}");


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
        }
    }
}

