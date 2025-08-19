using Calculadora.Interfaces;

namespace Calculadora.Classes
{
    public class Subtracao : IOperacao
    {
        public decimal Calcular(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
    }
}
