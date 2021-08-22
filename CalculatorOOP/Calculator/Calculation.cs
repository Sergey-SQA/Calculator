using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Calculation        
    {
        private static readonly IDictionary<string, IOperation> Operations = new Dictionary<string, IOperation>
        {
            { "+", new Addition() },
            { "-", new Substraction() },
            { "*", new Multiplication() },
            { "/", new Division() }
        };

        public static float CalculateEpression(Expression expression)
        {
            if (Operations.TryGetValue(expression.MathOperation, out IOperation ioperation))
                return ioperation.Calculate(expression.FirstNumber, expression.SecondNumber);
            throw new InvalidMathOperatorException("Неверный математический оператор");
        }
    }
}
