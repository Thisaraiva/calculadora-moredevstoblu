using Calculadora.Interfaces;

namespace Calculadora.Classes
{
    public class Divisao : IOperacao
    {
        public decimal Calcular(decimal num1, decimal num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");

            }
            return num1 / num2;
        }
    }
}
