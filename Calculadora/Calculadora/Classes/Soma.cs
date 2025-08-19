using Calculadora.Interfaces;

namespace Calculadora.Classes
{
    public class Soma : IOperacao
    {
        public decimal Calcular(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
    }
}
